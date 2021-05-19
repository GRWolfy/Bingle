using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

      /*
      private RNG RNGObj = new RNG();
      private SelectedNumbersListType sn = new SelectedNumbersListType();
      private InternalCardRep2DArray internalCardRep2DArray = new InternalCardRep2DArray();
      Player player = new Player();
      Random rand = new Random();*/

      private const int BINGOCARDSIZE = 5;
      private const int NUMBERSPERCOLUMN = 15;
      private const int MAXBINGONUMBER = 75;
      private char[] bingoLetters = { 'B', 'I', 'N', 'G', 'O' };
      private int nextCalledNumber = 0;
      private int counter = 0; //counts number of time a new number was given, so when it gets to 75, arr can reset
      private int counter2 = 0; //this counter counts how many times it took the player to get a bingo

                                // This next statement does three things.  See if you can figure out what they are
      private Button[,] newButton = new Button[BINGOCARDSIZE, BINGOCARDSIZE];

      private int cardCellWidth = 75;
      private int cardCellHeight = 75;
      private int barWidth = 6;  // Width or thickness of horizontal and vertical bars
      private int xCardUpperLeft = 45;
      private int yCardUpperLeft = 45;
      private int padding = 20;

      private void createCard()
      {
         Size size = new Size(75, 75);
         Point loc = new Point(0, 0);
         int topMargin = 60;

         int x;
         int y = 0;
         DrawColumnLabels();

         x = xCardUpperLeft;
         y = yCardUpperLeft;
      }

      private void DrawColumnLabels()
      {
         Label lblColID = new Label();
         lblColID.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)24.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
         lblColID.ForeColor = System.Drawing.Color.Orange;
         lblColID.Location = new System.Drawing.Point(cardCellWidth, 0);
         lblColID.Name = "lblColIDBINGO";
         lblColID.Size = new System.Drawing.Size(488, 32);
         lblColID.TabIndex = 0;
         lblColID.Text = "B       I        N       G       O";
         pnlCard.Controls.Add(lblColID);
         lblColID.Visible = true;
         lblColID.CreateControl();
         lblColID.Show();
      } // end drawColumnLabels
   }
}