/*Tommy Huynh
 * 2/5/19
 * Purpose: internal representation of bingo board used to mark cells and check for bingo*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Classes
{
    public class InternalBoard
    {
        int[,] array2D = new int[5,5];

        //constructor
        public InternalBoard()
        {
            array2D[2, 2] = 1; //free space 
        }

        //marks cell
        public void markCell(int row,int column)
        {
            this.array2D[row, column] = 1;
 
        }

        ////checks for bingo
        public Boolean checkBingo()
        {
            if (this.across() == true || this.down() == true || this.leftDiag() == true || this.rightDiag() == true) //if any of the 4 ways is true user wins
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean across()//win condition left to right
        {
            int counter = 0;
            for (int i = 0; i < 5; i++)
            {
                for(int k = 0; k < 5; k++)
                {
                    if (array2D[i, k] == 1)
                    {
                        counter++;
                    }
                    if (counter == 5)
                    {
                        return true;
                    }
                }//end inner loop
                counter = 0;//reset counter for each row
            }//end outer loop
            return false;
        }

        public Boolean down()//win condition top to bottom
        {
            int counter = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    if (array2D[k,i] == 1)
                    {
                        counter++;
                    }
                    if (counter == 5)
                    {
                        return true;
                    }
                }//end inner loop
                counter = 0;
            }//end outer loop
            return false;
        }
        public Boolean leftDiag() //left diagnol win condition
        {
            if(array2D[0,0]==1&& array2D[1,1] == 1&& array2D[2,2] == 1&& array2D[3,3] == 1&& array2D[4,4] == 1) //indices in the left diagnol
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean rightDiag() //right diagnol win condition
        {
            if (array2D[0, 4] == 1 && array2D[1, 3] == 1 && array2D[2, 2] == 1 && array2D[3, 1] == 1 && array2D[4, 0] == 1)//indices in the right diagnol
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
