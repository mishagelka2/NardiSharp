using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NardiSharp
{
    class Field
    {
        public int Height { get; private set; }
        public int Length { get; private set; }

        private List<Fishka> whiteFishkas;
        private List<Fishka> blackFishkas;

        private char[,] field;

        public Field(int h, int l)
        {
            Height = h;
            Length = l;
            field = new char[Height, Length];
            FillFieldInit();
            DrawFiskas();
            RefreshField("Start of the game, P1 throws kubicks");
        }

        private void FillFieldInit()
        {
            FillLetters(0, 'A');
            FillStraightLine(1);
            FillMainPart(2, Height - 3);
            FillStraightLine(Height - 2);
            FillLetters(Height - 1, 'a');
        }

        public void RefreshField(string incomingMessage = "")
        {
            DrawField();
            Console.WriteLine();
            Console.WriteLine(incomingMessage);
        }

        public void DrawField()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }

        private void FillStraightLine(int x)
        {
            for(int i = 0; i < Length; i++)
            {
                field[x, i] = '-';
            }
        }

        private void FillLetters(int x, char startLetter)
        {
            for(int i = 1; i < Length; i++)
            {
                if (i % 2 == 0)
                    field[x, i] = Convert.ToChar(startLetter + i);
                else
                    field[x, i] = ' ';
            }
           
        }

        private void FillMainPart(int top, int bottom)
        {
            int middle = Length % 2 == 0 ? Length / 2 : (Length - 1) / 2;
            for(int i = top; i <= bottom; i++)
            {
                for(int j = 0; j < Length; j++)
                {
                    if(j % 2 == 0 && (i <= top + 2 || i >= bottom - 2))
                    {
                        field[i, j] = '|';
                    }
                    else if (j == 0 || j == Length - 1)
                    {
                        field[i, j] = '|';
                    }
                    else if (j == middle)
                    {
                        field[i, j] = '|';
                    }
                    else
                    {
                        field[i, j] = ' ';
                    }
                }
            }
        }

        public char GetFieldValue(int x, int y) => field[x, y]; // or private


        public void ReadIncomingValues(/*out int x, out int y*/)
        {
            string valuesGot = Console.ReadLine();

        }

        public void DrawFiskas()
        {

        }

        private void FillEmptyFieldWithStart()
        {

        }


    }
}
