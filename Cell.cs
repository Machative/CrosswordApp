using System;
using System.Collections.Generic;
using System.Text;

namespace CrosswordApp
{
    public class Cell
    {
        public int ClueNum;
        public char Character;
        public String acrossClue;
        public String downClue;
        public Cell(char ch = ' ', String aClue = "", String dClue = "", int num=-1)
        {
            ClueNum = num;
            Character = ch;
            acrossClue = aClue;
            downClue = dClue;
        }
        public bool isBlack()
        {
            return Character == '~';
        }
        public void blackOut()
        {
            Character = '~';
        }
        public void toggleBlack()
        {
            if (Character == '~') Character = ' ';
            else Character = '~';
        }
    }
}
