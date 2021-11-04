using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NardiSharp
{
    public class Field
    {
        public int Height { get; private set; }
        public int Length { get; private set; }

        private char[,] field;

        public Field(int h, int l)
        {
            Height = h;
            Length = l;
            field = new char[Height, Length];
            FillField();
            DrawField();
        }

        private void FillField()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    if (i == 0)
                    { // first row
                        field[i, j] = j % 2 == 0 ? Convert.ToChar(j + 65) : field[i, j] = ' ';
                    }
                    else if (i == 1 || i == Height - 2)
                    { //2nd + predposledniy
                        field[i, j] = '-';
                    }
                    else if (i == Height - 1)
                    { //last row
                        field[i, j] = j % 2 == 0 ? Convert.ToChar(j + 97) : field[i, j] = ' ';
                    }
                    else
                    {
                        if (j == 1 || j == Length - 2 || IsMiddle(j)) // this last satan should always draw in the center
                        {
                            field[i, j] = '|';
                        } 
                        else
                        {
                            field[i, j] = ' ';
                        }

                        if ((i > 1 && i < 5) || (i > 11 && i < 15) && j % 2 == 0)
                        { // drawing borders for slots for fishkas
                            field[i, j] = '|';
                        }
                        else
                        {
                            field[i, j] = ' ';
                        }
                    }
                }
            }
        }

        private void DrawField()
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

        private bool IsMiddle(int j) => ((Length % 2 == 0 && j == Length / 2) || (Length % 2 == 1 && j == (Length / 2) + 1));
    }
}
