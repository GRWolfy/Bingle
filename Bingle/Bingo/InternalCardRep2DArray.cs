using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingle.Bingo
{
   class InternalCardRep2DArray
   {
      //board & size
      private const int size = 5;
      private bool[,] board = new bool[size, size];

      //Constructor that sets all the spots to false, except for the free space
      public InternalCardRep2DArray()
      {
         for (int i = 0; i < size; i++)
         {
            for (int j = 0; j < size; j++)
            {
               this.board[i, j] = false;
            }
         }
         this.board[2, 2] = true;
      }

      //sets arr to true where the user matched a call
      public void recordCalledNumber(int row, int col)
      {
         board[row, col] = true;
      }

      //This method parses through the entire board to see if there are 5 matched in a row
      public int isWinner(int a, int b)
      {
         if (checkRow(a) == true || checkCol(b) == true || checkDiag() == true)
         {
            return 1;
         }
         else
         {
            return 0;
         }


      }

      //checks the row clicked on for a bingo
      public bool checkRow(int row)
      {
         for (int i = 0; i < size; i++)
         {
            if (board[row, i] == false)
               return false;

         }
         return true;
      }

      //checks the col clicked on for a bingo
      public bool checkCol(int col)
      {
         for (int i = 0; i < size; i++)
         {
            if (board[i, col] == false)
               return false;

         }
         return true;
      }

      //checks both of the diagonals for a bingo
      public bool checkDiag()
      {
         for (int i = 0; i < size; i++)
         {
            if (board[i, i] == false)
               return false;

         }
         if (board[0, 4] == false || board[1, 3] == false || board[3, 1] == false || board[4, 0] == false)
            return false;

         return true;
      }
   }
}
