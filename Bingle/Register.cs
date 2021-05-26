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
   public partial class Register : Form
   {
      public Register()
      {
         InitializeComponent();
      }

      private void btnRegister_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "INSERT INTO user(firstname, lastname, username, password, datetime) VALUES('" + txtFirstname.Text + ", '" + txtLastname.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '"+ DateTime.Now.ToString() +"')";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            Connection.Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
