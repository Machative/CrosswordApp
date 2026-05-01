using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace CrosswordApp
{
    public partial class Puzzle : UserControl
    {
        XWDObject xwd;
        int cellWidth;
        int cellHeight;

        public struct selection
        {
            public int row;
            public int col;
            public direction dir;
            public selection(int row, int col, direction dir=direction.ACROSS)
            {
                this.row = row;
                this.col = col;
                this.dir = dir;
            }
            public selection(position pos, direction dir = direction.ACROSS)
            {
                this.row = pos.row;
                this.col = pos.col;
                this.dir = dir;
            }
            public position asPos()
            {
                return new position(row, col);
            }

            public enum direction
            {
                ACROSS,
                DOWN
            }
        }
        public struct position
        {
            public int row;
            public int col;
            public position(int row, int col)
            {
                this.row = row;
                this.col = col;
            }
            public static bool operator ==(position pos1, position pos2)
            {
                return pos1.row == pos2.row && pos1.col == pos2.col;
            }
            public static bool operator !=(position pos1, position pos2) {
                return pos1.row != pos2.row || pos1.col != pos2.col;
            }
        }

        selection selected;
        public Puzzle(XWDObject obj=null)
        {
            InitializeComponent();

            if (obj == null) loadXWD(new XWDObject(15, 15));
            else loadXWD(obj);
        }

        public void loadXWD(XWDObject xwdObj)
        {
            xwd = xwdObj;

            selected = new selection(0, 0, selection.direction.ACROSS);
            cellWidth = this.Width / xwd.getWidth();
            cellHeight = this.Height / xwd.getHeight();

            Refresh();
        }

        public void EnterChar(char key)
        {
            if (!xwd.getCell(selected.row, selected.col).isBlack()) //shouldn't ever be able to select blacked out cell, but just in case
            {
                xwd.getCell(selected.row, selected.col).Character = key;
                //Go to the next cell after entering this one
                selected = nextCell(selected);
                Refresh();
            }
        }

        public void Select(int x, int y)
        {
            selection sel = new selection(pixelsToPosition(x, y), selected.dir);

            if (xwd.getCell(sel.row, sel.col).isBlack()) return;
            //If the same cell is already selected, change the direction
            if ((sel.row == selected.row && sel.col == selected.col))
            {
                selected.dir = (selected.dir == selection.direction.ACROSS ? selection.direction.DOWN : selection.direction.ACROSS);
            }
            else
            {
                selected = sel;
            }
            Refresh();
        }

        public void Blackout(int x, int y)
        {
            position pos = pixelsToPosition(x, y);
            if (selected.asPos() == pos) return;

            xwd.getCell(pos.row, pos.col).toggleBlack();
            Refresh();
        }

        private selection nextCell(selection sel)
        {
            if(sel.dir == selection.direction.DOWN)
            {
                sel.row++;
                while(sel.row >= xwd.getHeight() || xwd.getCell(sel.row,sel.col).isBlack())
                {
                    if (sel.row >= xwd.getHeight())
                    {
                        sel.row=0;
                        sel.col++;
                        if (sel.col >= xwd.getWidth()) sel.col = 0;
                    }
                    else
                    {
                        sel.row++;
                    }
                }
            }
            else
            {
                sel.col++;
                while (sel.col >= xwd.getWidth() || xwd.getCell(sel.row, sel.col).isBlack())
                {
                    if (sel.col >= xwd.getWidth())
                    {
                        sel.col = 0;
                        sel.row++;
                        if (sel.row >= xwd.getWidth()) sel.row = 0;
                    }
                    else
                    {
                        sel.col++;
                    }
                }
            }
            return sel;
        }

        private void puzzle_Paint(object sender, PaintEventArgs e)
        {
            xwd.updateNumbers();

            Graphics g = e.Graphics;

            //Gridlines
            Pen gridLinesPen = new Pen(Brushes.Black);
            gridLinesPen.Width = 1.0F;
            gridLinesPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Miter;
            int gridWidth = cellWidth * xwd.getWidth();
            int gridHeight = cellHeight * xwd.getHeight();
            for(int row = 0; row <= xwd.getHeight(); row++)
            {
                g.DrawLine(gridLinesPen, 0, cellHeight * row, gridWidth, cellHeight * row);
            }
            for(int col = 0; col <= xwd.getWidth(); col++)
            {
                g.DrawLine(gridLinesPen, cellWidth * col, 0, cellWidth * col, gridHeight);
            }

            //Draw cells
            position[] selectedCells = getSelectionPositions(selected);
            Font clueNumFont = new Font("Arial", 5); //TODO: Font size should depend on puzzle size
            Font charFont = new Font("Arial", 14); //TODO: Same as above

            for(int row = 0; row < xwd.getHeight(); row++) {
                for (int col = 0; col < xwd.getWidth(); col++)
                {
                    Cell curCell = xwd.getCell(row, col);
                    position curPos = new position(row, col);
                    Rectangle cellBounds = new Rectangle(1 + (col * cellWidth), 1 + (row * cellHeight), cellWidth - 1, cellHeight - 1);

                    //If cell is the selected cell
                    if(selected.row==row && selected.col == col)
                    {
                        g.FillRectangle(Brushes.DarkGray, cellBounds);
                    }else if(selectedCells.Contains(curPos)){
                        g.FillRectangle(Brushes.LightGray, cellBounds);
                    }
                    //If blacked out, blacken it
                    if (curCell.isBlack())
                    {
                        g.FillRectangle(Brushes.Black, cellBounds);
                    }//Otherwise, draw cell number and character where applicable
                    else
                    {
                        if(curCell.ClueNum>0) g.DrawString(""+curCell.ClueNum, clueNumFont, new SolidBrush(Color.Black), 1 + (col * cellWidth), 1 + (row * cellHeight));
                        if (curCell.Character >= 65 && curCell.Character <= 90) g.DrawString(""+curCell.Character, charFont, new SolidBrush(Color.Black), 3 + (col * cellWidth), 3 + (row * cellHeight));
                    }

                }
            }
            
        }
        private position[] getSelectionPositions(selection sel)
        {
            int first = 0;
            int last = 0;

            if (sel.dir == selection.direction.ACROSS)
            {
                for (int i = 1; i <= xwd.getWidth(); i++)
                {
                    if (sel.col + i == xwd.getWidth() || xwd.getCell(sel.row, sel.col + i).isBlack())
                    {
                        last = sel.col + i - 1;
                        break;
                    }
                }
                for(int i = -1; i >= -xwd.getWidth(); i--)
                {
                    if (sel.col + i == -1 || xwd.getCell(sel.row, sel.col + i).isBlack())
                    {
                        first = sel.col + i + 1;
                        break;
                    }
                }
                position[] positions = new position[(last - first)+1];
                for(int i = first; i <= last; i++)
                {
                    positions[i-first] = new position(sel.row, i);
                }
                return positions;
            }
            else
            {
                for (int i = 1; i <= xwd.getHeight(); i++)
                {
                    if (sel.row + i == xwd.getHeight() || xwd.getCell(sel.row+i, sel.col).isBlack())
                    {
                        last = sel.row + i - 1;
                        break;
                    }
                }
                for (int i = -1; i >= -xwd.getHeight(); i--)
                {
                    if (sel.row + i == -1 || xwd.getCell(sel.row + i, sel.col).isBlack())
                    {
                        first = sel.row + i + 1;
                        break;
                    }
                }
                position[] positions = new position[(last - first) + 1];
                for (int i = first; i <= last; i++)
                {
                    positions[i - first] = new position(i, sel.col);
                }
                return positions;
            }

        }
        private (int y, int x) positionToPixels(position pos)
        {
            return (cellHeight * pos.row, cellWidth * pos.col);
        }
        private position pixelsToPosition(int x, int y)
        {
            return new position(y / cellHeight, x / cellWidth);
        }
    }
}
