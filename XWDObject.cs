using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

//Internal Formatting
//-1 for the value of int in grid indicates a space with no number, hence no clue
//'~' for the value of char in grid indicates a black space


//Crossword Logic
//A space is numbered only if: the space to the left of it is black or a puzzle edge, OR the space above it is black or a puzzle edge

namespace CrosswordApp
{
    public class XWDObject
    {
        private int height;
        private int width;
        private int numClues;

        private Cell[,] grid;

        public XWDObject(int height, int width)
        {
            this.height = height;
            this.width = width;
            grid = new Cell[height,width];
            for(int row = 0; row < height; row++)
            {
                for(int col = 0; col < width; col++)
                {
                    grid[row,col] = new Cell();
                }
            }
            updateNumbers();
        }

        public void updateNumbers()
        {
            numClues = 0;
            for(int row = 0; row < height; row++)
            {
                for(int col = 0; col < height; col++)
                {
                    if(!grid[row,col].isBlack() && (row==0 || col == 0 || grid[row - 1,col].SolutionChar=='~' || grid[row,col-1].SolutionChar=='~'))
                    {
                        grid[row,col].ClueNum = ++numClues;
                    }
                    else
                    {
                        grid[row, col].ClueNum = -1;
                    }
                }
            }
        }
        public Cell getCellByNumber(int num)
        {
            for(int row = 0; row < height; row++)
            {
                for(int col=0; col<width; col++)
                {
                    if (grid[row, col].ClueNum == num) return grid[row, col];
                }
            }
            return null;
        }
        public int getWidth()
        {
            return width;
        }
        public int getHeight()
        {
            return height;
        }
        public Cell getCell(int row, int col)
        {
            if (row < height && col < width && row >= 0 && col >= 0) return grid[row, col];
            else return null;
        }

        /*File Format:
         * height, width
         * row 1 characters - puzzle
         * row 2 characters - puzzle
         * ...
         * row n characters - puzzle
         * row 1 characters - solution
         * row 2 characters - solution
         * ...
         * row n characters - solution
         * 1 across clue
         * 1 down clue
         * 2 across clue
         * 2 down clue
         * ...
         * N across clue
         * N down clue
         */

        public static XWDObject loadFromFile(String[] contents)
        {
            int height = int.Parse(contents[0].Split(',')[0]);
            int width = int.Parse(contents[0].Split(',')[1]);
            XWDObject newXWD = new XWDObject(height, width);
            for(int i = 1; i <= height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    newXWD.grid[i - 1, j] = new Cell(char.Parse(contents[i].Split(',')[j]));
                }
            }
            for (int i = 1+height; i <= height*2; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    newXWD.grid[i - 1, j].GuessChar = char.Parse(contents[i].Split(',')[j]);
                }
            }
            newXWD.updateNumbers();
            for(int i = 1; i <= newXWD.numClues*2; i++)
            {
                if((i) % 2 == 0)
                {
                    newXWD.getCellByNumber((i) / 2).downClue = contents[i+height*2];
                }
                else
                {
                    newXWD.getCellByNumber((i + 1) / 2).acrossClue = contents[i+height*2];
                }                
            }
            return newXWD;
        }
        public string[] toXWDFile()
        {
            int lines = 1 + height + (2 * numClues);
            string[] xwdFile = new string[lines];
            xwdFile[0] = height + "," + width;
            for(int i = 1; i <= height; i++)
            {
                string rowChars = "";
                for(int j = 0; j < width; j++)
                {
                    rowChars += grid[i - 1, j].SolutionChar;
                    if (j < width - 1) rowChars += ',';
                }
                xwdFile[i] = rowChars;
            }
            for (int i = height+1; i <= height*2; i++)
            {
                string rowChars = "";
                for (int j = 0; j < width; j++)
                {
                    rowChars += grid[i - 1, j].GuessChar;
                    if (j < width - 1) rowChars += ',';
                }
                xwdFile[i] = rowChars;
            }
            for (int i = 1; i<numClues*2;i++)
            {
                if(i%2==1) xwdFile[2*height + i] = getCellByNumber((i+1) / 2).acrossClue;
                else xwdFile[2*height + i] = getCellByNumber(i / 2).downClue;
            }
            return xwdFile;
        }
    }
}
