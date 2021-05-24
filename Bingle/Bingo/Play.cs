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

namespace Bingle.Bingo
{
   public partial class Play : Form
   {
      public Play()
      {
         InitializeComponent();
      }

      private void Play_Load(object sender, EventArgs e)
      {

      }

      private RNG RNGObj = new RNG();
      private SelectedNumbersListType sn = new SelectedNumbersListType();
      private InternalCardRep2DArray internalCardRep2DArray = new InternalCardRep2DArray();
      //Player player = new Player();
      Random rand = new Random();

      // Named constants
      private const int BINGOCARDSIZE = 5;
      private const int NUMBERSPERCOLUMN = 15;
      private const int MAXBINGONUMBER = 75;
      private char[] bingoLetters = { 'B', 'I', 'N', 'G', 'O' };
      private int nextCalledNumber = 0;
      private int counter = 0; //counts number of time a new number was given, so when it gets to 75, arr can reset
      private int counter2 = 0; //this counter counts how many times it took the player to get a bingo
                                // This next statement does three things.  See if you can figure out what they are
      private Button[,] newButton = new Button[BINGOCARDSIZE, BINGOCARDSIZE];

      int cardCellWidth = 75;
      int cardCellHeight = 75;
      int barWidth = 6;  
      int xcardUpperLeft = 45;
      int ycardUpperLeft = 45;
      int padding = 20;

      private void createCard()
      {
         Size size = new Size(75, 75);
         Point loc = new Point(0, 0);
         int topMargin = 60;

         int x, y = 0;

         DrawColumnLabel();

         x = xcardUpperLeft;
         y = ycardUpperLeft;

         DrawHorizontalBar(x, y, BINGOCARDSIZE);
         y = y + barWidth;

         DrawVerticalBar(x, y);

         for (int row = 0; row < BINGOCARDSIZE; row++)
         {
            loc.Y = topMargin + row * (size.Height + padding);
            int extraLeftPadding = 50;
            for (int col = 0; col < BINGOCARDSIZE; col++)
            {
               newButton[row, col] = new Button();
               newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth, loc.Y);
               newButton[row, col].Size = size;
               newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);

               if (row == BINGOCARDSIZE / 2 && col == BINGOCARDSIZE / 2)
               {
                  newButton[row, col].Font = new Font("Arial", 10, FontStyle.Bold);
                  newButton[row, col].Text = "Free \n Space";
                  newButton[row, col].BackColor = System.Drawing.Color.Orange;
               }
               else
               {
                  newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                  newButton[row, col].Text = RNGObj.getRandomValue(bingoLetters[col]).ToString();
               }

               newButton[row, col].Enabled = true;
               newButton[row, col].Name = "btn" + row.ToString() + col.ToString();
               newButton[row, col].Click += new EventHandler(Button_Click);
               pnlCard.Controls.Add(newButton[row, col]);

               x += cardCellWidth + padding;

               if (row == 0) DrawVerticalBar(x - 5, y);
            }

            x = xcardUpperLeft - 20;
            y = y + cardCellHeight + padding;

            DrawHorizontalBar(x + 25, y - 10, BINGOCARDSIZE - 10);
         }

         y += barWidth - 1;
         DrawColumnLabel();
         Globals.selectedNumbersListObj.reset();
      }

      private void DrawColumnLabel()
      {
         Label l = new Label();
         l.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)24.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
         l.ForeColor = System.Drawing.Color.Orange;
         l.Location = new System.Drawing.Point(cardCellWidth, 0);
         l.Name = "lBINGO";
         l.Size = new System.Drawing.Size(488, 32);
         l.TabIndex = 0;
         l.Text = "B       I        N       G       O";
         pnlCard.Controls.Add(l);
         l.Visible = true;
         l.CreateControl();
         l.Show();
      }

      private void DrawHorizontalBar(int x, int y, int cardSize) 
      {
         int currentx;
         currentx = x;

         Label l = new Label();
         l.BackColor = System.Drawing.SystemColors.ControlText;
         l.Location = new System.Drawing.Point(currentx, y);
         l.Name = "lHorizontalBar";
         l.Size = new System.Drawing.Size((cardCellWidth + padding - 1) * BINGOCARDSIZE, barWidth);
         l.TabIndex = 20;
         pnlCard.Controls.Add(l);
         l.Visible = true;
         l.CreateControl();
         l.Show();
         currentx = currentx + cardCellWidth;
      }

      private void DrawVerticalBar(int x, int y)
      {
         Label l = new Label();
         l.BackColor = System.Drawing.SystemColors.ControlText;
         l.Location = new System.Drawing.Point(x, y);
         l.Name = "lVerticalBar" + x.ToString();
         l.Size = new System.Drawing.Size(barWidth, (cardCellHeight + padding - 1) * BINGOCARDSIZE);
         l.TabIndex = 19;
         pnlCard.Controls.Add(l);
         l.Visible = true;
         l.CreateControl();
         l.Show();
      }

      private void Button_Click(object sender, EventArgs e)
      {
         int bingoCount2D;
         int selectedNumber;

         int rowID = convertCharToInt(((Button)sender).Name[3]);
         int colID = convertCharToInt(((Button)sender).Name[4]);
         MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected!");
         int cellID = rowID * 3 + colID;

         try
         {
            selectedNumber = Convert.ToInt32(newButton[rowID, colID].Text);

            if (selectedNumber == nextCalledNumber)
            {
               newButton[rowID, colID].BackColor = System.Drawing.Color.Orange;
               internalCardRep2DArray.recordCalledNumber(rowID, colID);

               Globals.selectedNumbersListObj.setUsedNumber(selectedNumber);
               bingoCount2D = internalCardRep2DArray.isWinner(rowID, colID);

               if ((bingoCount2D > 0))
               {
                  MessageBox.Show("You are a Winner!!", "Winner Found! \n"
                      + "Bingos count = " + (bingoCount2D) + ". Game over!");
                  MessageBox.Show("It took you " + counter + " calls to get a bingo");
               }

               playTheGame();
            }
            else
            {
               MessageBox.Show("Called number does not match the one in the box you selected." + "Try again!", "Numbers Do Not Match");
            }
         }
         catch
         {

         }
      }

      public void playTheGame()
      {
         int num = rand.Next(1, 76);//gets a random number between and 1 and 75 (inclusive)

         if (counter == 75 || counter == 150)
         {
            MessageBox.Show("GAME OVER.");
         }

         if (sn.isNumberUsed(num) == false)
         {
            counter++;
            if (num > 0 && num <= 15)
            {
               txtRandNum.Text = "B " + num;
               nextCalledNumber = num;
            }
            else if (num > 15 && num <= 30)
            {
               txtRandNum.Text = "I " + num;
               nextCalledNumber = num;
            }
            else if (num > 30 && num <= 45)
            {
               txtRandNum.Text = "N " + num;
               nextCalledNumber = num;
            }
            else if (num > 45 && num <= 60)
            {
               txtRandNum.Text = "G " + num;
               nextCalledNumber = num;
            }
            else
            {
               txtRandNum.Text = "O " + num;
               nextCalledNumber = num;
            }

            string s = getBingoNumber() + num.ToString() + ",";
            try
            {
               Connection.Connection.DB();
               Functions.Function.gen = "UPDATE Test SET bingonumber =  '" + s +"' WHERE playerid = 1 ";
               Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
               Functions.Function.command.ExecuteNonQuery();
               Connection.Connection.con.Close();
            }

            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
         }
         else
         {
            playTheGame();
         }
         sn.setUsedNumber(num);

      }

      private string getBingoNumber()
      {
         string s = "";
         
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT bingonumber FROM Test WHERE playerid = 1 ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.reader = Functions.Function.command.ExecuteReader();

            if (Functions.Function.reader.HasRows)
            {
               Functions.Function.reader.Read();
               s = Functions.Function.reader["bingonumber"].ToString();
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }

         return s;
      }

         public int convertCharToInt(char c)
      {
         int bar = int.Parse(c.ToString());
         return bar;
      }



      private void btnPlay_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "INSERT INTO test(playerid, bingonumber, cardnumber) VALUES(1, 0, 0 )";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            Connection.Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }

         createCard();
         playTheGame();
      }

      private void btnDontHave_Click(object sender, EventArgs e)
      {
         //if (txtName.Text != "")
            playTheGame();
      }
   }
}