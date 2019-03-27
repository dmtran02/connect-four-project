using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Classes
{
    public class InternalBoard
    {
        int height = 7;
        int width = 8;

        int player1 = 1;
        int player2 = 2;

        int[,] array2D = new int[8,9];

        //constructor
        public InternalBoard()
        {
            for(int i = 0; i < 8; i++)
            {
                for( int j = 0; j<9; j++)
                {
                    array2D[i, j] = 0;
                }
            }
        }

        public int getHeight()
        {
            return height;
        }

        public int getWidth()
        {
            return width;
        }

        //marks cell
        public void markCell(int row, int column, int currentPlayer)
        {
            if(currentPlayer == 1)
            {
                this.array2D[row, column] = 1;
            }
            else if(currentPlayer == 2)
            {
                this.array2D[row, column] = 2;
            }
        }

        public Boolean checkConnectFour()
        {
            // player 1 horizontal check
            for(int j = 0; j < getHeight() - 3; j++)
            {
                for(int i = 0; i < getWidth(); i++)
                {
                    if(this.array2D[i,j] == player1 && this.array2D[i,j+1] == player1 
                        && this.array2D[i,j+2] == player1 && this.array2D[i, j+3] == player1)
                    {
                        return true;
                    }
                }
            }
            //
            // player 1 vertical check
            for(int i = 0; i< getWidth() - 3; i++)
            {
                for (int j = 0; j < getHeight(); j++)
                {
                    if(this.array2D[i,j] == player1 && this.array2D[i+1,j] == player1 
                        && this.array2D[i+2,j] == player1 && this.array2D[i+3,j] == player1)
                    {
                        return true;
                    }
                }
            }

            // player 1 ascending diagonal check
            for(int i = 3; i<getWidth(); i++)
            {
                for(int j = 0; j<getHeight()-3; j++)
                {
                    if(this.array2D[i,j] == player1 && this.array2D[i-1,j+1] == player1 
                        && this.array2D[i-2,j+2] == player1 && this.array2D[i-3,j+3] == player1)
                    {
                        return true;
                    }
                }
            }

            // player 1 descending diagonal check
            for(int i = 3; i<getWidth(); i++)
            {
                for(int j = 3; j<getHeight(); j++)
                {
                    if(this.array2D[i,j] == player1 && this.array2D[i-1,j-1] == player1 
                        && this.array2D[i-2,j-2] == player1 && this.array2D[i-3,j-3] == player1)
                    {
                        return true;
                    }
                }
            }

            // player 2 horizontal check
            for (int j = 0; j < getHeight() - 3; j++)
            {
                for (int i = 0; i < getWidth(); i++)
                {
                    if (this.array2D[i, j] == player2 && this.array2D[i, j + 1] == player2
                        && this.array2D[i, j + 2] == player2 && this.array2D[i, j + 3] == player2)
                    {
                        return true;
                    }
                }
            }

            // player 2 vertical check
            for (int i = 0; i < getWidth() - 3; i++)
            {
                for (int j = 0; j < getHeight(); j++)
                {
                    if (this.array2D[i, j] == player2 && this.array2D[i + 1, j] == player2
                        && this.array2D[i + 2, j] == player2 && this.array2D[i + 3, j] == player2)
                    {
                        return true;
                    }
                }
            }

            // player 2 ascending diagonal check
            for (int i = 3; i < getWidth(); i++)
            {
                for (int j = 0; j < getHeight() - 3; j++)
                {
                    if (this.array2D[i, j] == player2 && this.array2D[i - 1, j + 1] == player2
                        && this.array2D[i - 2, j + 2] == player2 && this.array2D[i - 3, j + 3] == player2)
                    {
                        return true;
                    }
                }
            }

            // player 2 descending diagonal check
            for (int i = 3; i < getWidth(); i++)
            {
                for (int j = 3; j < getHeight(); j++)
                {
                    if (this.array2D[i, j] == player2 && this.array2D[i - 1, j - 1] == player2
                        && this.array2D[i - 2, j - 2] == player2 && this.array2D[i - 3, j - 3] == player2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void resetBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    array2D[i, j] = 0;
                }
            }
        }
    }
}
