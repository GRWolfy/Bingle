using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingle.Bingo
{
   public class RNG
   {
      private Random RandomObj;

      public RNG()
      {
         RandomObj = new Random();
      }

      public int getRandomValue(char columnHeader)
      {
         int r;

         switch (columnHeader)
         {
            case 'B':
               r = getNextUniqueRandomNumber(1, 15);
               if (r < 1 || r > 15)
               {
                  MessageBox.Show("Program Error! Selected random number out of range 1-15",
                       "Click to terminate program.", MessageBoxButtons.OK);
                  return -1;
               }  // end if
               break;
            case 'I':
               r = getNextUniqueRandomNumber(16, 30);
               if (r < 16 || r > 30)
               {
                  MessageBox.Show("Program Error! Selected random number out of range 16-30",
                       "Click to terminate program.", MessageBoxButtons.OK);
                  return -1;
               }  // end if
               break;
            case 'N':
               r = getNextUniqueRandomNumber(31, 45);
               if (r < 31 || r > 45)
               {
                  MessageBox.Show("Program Error! Selected random number out of range 31-45",
                       "Click to terminate program.", MessageBoxButtons.OK);
                  return -1;
               } // end if
               break;
            case 'G':
               r = getNextUniqueRandomNumber(46, 60);
               if (r < 46 || r > 60)
               {
                  MessageBox.Show("Program Error! Selected random number out of range 46-60",
                       "Click to terminate program.", MessageBoxButtons.OK);
                  return -1;
               } // end if
               break;
            case 'O':
               r = getNextUniqueRandomNumber(61, 75);
               if (r < 61 || r > 75)
               {
                  MessageBox.Show("Program Error! Selected random number out of range 61-75",
                       "Click to terminate program.", MessageBoxButtons.OK);
                  return -1;
               } // end if
               break;
            default:
               MessageBox.Show("Program Error! Selected Letter no B I N G or O!",
                   "Click to terminate program.", MessageBoxButtons.OK);
               return -1;
         }

         return r;
      }

      public int getNextUniqueRandomNumber(int minVal, int maxVal)
      {
         Boolean isUnique = false;
         int rn = 0;

         while (isUnique == false)
         {
            rn = RandomObj.Next(minVal, maxVal);

            if (!Globals.selectedNumbersListObj.isNumberUsed(rn))
            {
               isUnique = true;
               Globals.selectedNumbersListObj.setUsedNumber(rn);
            }
         }

         return rn;
      }
   }
}
