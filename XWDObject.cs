using System;
using System.Collections.Generic;
using System.Text;

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
            int prevNum = 0;
            for(int row = 0; row < height; row++)
            {
                for(int col = 0; col < height; col++)
                {
                    if(!grid[row,col].isBlack() && (row==0 || col == 0 || grid[row - 1,col].Character=='~' || grid[row,col-1].Character=='~'))
                    {
                        grid[row,col].ClueNum = ++prevNum;
                    }
                    else
                    {
                        grid[row, col].ClueNum = -1;
                    }
                }
            }
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
    }
}
