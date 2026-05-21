using System;
using System.Collections.Generic;
using System.Text;

namespace CrosswordApp
{
    public class Cell
    {
        public int ClueNum;
        public char SolutionChar;
        public char GuessChar;
        public String acrossClue;
        public String downClue;
        public Cell(char ch = ' ', String aClue = null, String dClue = null, int num=-1)
        {
            ClueNum = num;
            SolutionChar = ch;
            GuessChar = '-';
            acrossClue = aClue;
            downClue = dClue;
        }
        public bool isBlack()
        {
            return SolutionChar == '~';
        }
        public void blackOut()
        {
            SolutionChar = '~';
        }
        public void toggleBlack()
        {
            if (SolutionChar == '~') SolutionChar = ' ';
            else SolutionChar = '~';
        }
    }
}
