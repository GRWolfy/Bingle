using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingle.Bingo
{
   public class SelectedNumbersListType
   {
      private int[] arr = new int[76];

      public void reset()
      {
         for (int i = 0; i < 76; i++)
         {
            arr[i] = 0;
         }
      }

      public void setUsedNumber(int n)
      {
         arr[n] = n;
      }

      public bool isNumberUsed(int n)
      {
         if (arr[n] == n)
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
