/*Tommy Huynh
 * 2/5/19
 * Purpose: holds selected numbers so we know not to call it again*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Classes
{
    public class selectedNumbers
    {
        public int[] arr = new int[76]; //76 instead of 75 for index to number correspondance
        int counter = 0;// used for debugging 
        public selectedNumbers()//constructor
        {
        }
        
        public bool isNumberUsed(int n) //if number is used return true
        {
            if (this.arr[n] == n) 
            {
                return true;
            }
            return false;
        }
        public void setUsedNumber(int n) //sets number as used
        {
            this.arr[n] = n;
            this.counter++; //counter incremented everytime a number is set to used
        }

        public void reset() //sets all indices in array to 0, to be used after creating cards to have new array for playing game
        {
            for(int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = 0;
            }
            this.counter = 0; //resets counter
        }
    }
}
