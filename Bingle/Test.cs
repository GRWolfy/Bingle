using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingle
{
   public partial class Test : Form
   {
      public Test()
      {
         InitializeComponent();
      }

      private void Test_Load(object sender, EventArgs e)
      {
  
      }
     

      private void btnBingo_Click(object sender, EventArgs e)
      {
         var bingo = new Bingo.Play();
         bingo.Show();
         Hide();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "INSERT INTO Test(playerid, bingonumber, cardnumber) VALUES(1, )";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void testSave()
      {
         for (int i = 0; i < 5; i++)
         {
            try
            {
               Connection.Connection.DB();
               Functions.Function.gen = "UPDATE Test SET bingonumber = (SELECT productid FROM product WHERE playerid = 1) WHERE cardid = 1 ";
               Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
               Functions.Function.command.ExecuteNonQuery();
               MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Connection.Connection.con.Close();
            }

            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
         }
      }
   }
}
