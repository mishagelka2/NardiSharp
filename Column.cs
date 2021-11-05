using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NardiSharp
{
    class Column // stack for bomzhi
    {
        private char [] col;
        private char columnLetter;
        private int positionOnY;

        public char ColumnLetter
        {
            get
            {
                return columnLetter;
            }
            set
            {
                columnLetter = value;
            }
        }

        public Column(char letter, int relativePosition)
        {
            columnLetter = letter;
            positionOnY = relativePosition;
            col = new char[12];
            col = col.Select(x => ' ').ToArray();
        }

        public void PutLetterInColumn(char letter) // later
        {
            //Validate();
            int lastPosition = -1;
            try
            {
                for (int i = 0; i < 12; i++)
                {
                    if (i == ' ')
                        lastPosition = i;

                }
                if (lastPosition == -1)
                    throw new Exception("");
                col[lastPosition] = letter; 
            }
            catch (Exception e)
            {
                Console.WriteLine("aaa");
            }

        }
    }
}
