
namespace Bingle.Bingo
{
   partial class Play
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.pnlCard = new System.Windows.Forms.Panel();
         this.btnPlay = new System.Windows.Forms.Button();
         this.txtRandNum = new System.Windows.Forms.TextBox();
         this.btnDontHave = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // pnlCard
         // 
         this.pnlCard.Location = new System.Drawing.Point(524, 23);
         this.pnlCard.Name = "pnlCard";
         this.pnlCard.Size = new System.Drawing.Size(610, 555);
         this.pnlCard.TabIndex = 0;
         // 
         // btnPlay
         // 
         this.btnPlay.Location = new System.Drawing.Point(284, 188);
         this.btnPlay.Name = "btnPlay";
         this.btnPlay.Size = new System.Drawing.Size(88, 32);
         this.btnPlay.TabIndex = 1;
         this.btnPlay.Text = "PLAY";
         this.btnPlay.UseVisualStyleBackColor = true;
         this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
         // 
         // txtRandNum
         // 
         this.txtRandNum.Location = new System.Drawing.Point(272, 267);
         this.txtRandNum.Name = "txtRandNum";
         this.txtRandNum.Size = new System.Drawing.Size(100, 20);
         this.txtRandNum.TabIndex = 2;
         // 
         // btnDontHave
         // 
         this.btnDontHave.Location = new System.Drawing.Point(284, 324);
         this.btnDontHave.Name = "btnDontHave";
         this.btnDontHave.Size = new System.Drawing.Size(88, 38);
         this.btnDontHave.TabIndex = 3;
         this.btnDontHave.Text = "DONT HAVE";
         this.btnDontHave.UseVisualStyleBackColor = true;
         this.btnDontHave.Click += new System.EventHandler(this.btnDontHave_Click);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(296, 52);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 4;
         this.button1.Text = "button1";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // Play
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1165, 618);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.btnDontHave);
         this.Controls.Add(this.txtRandNum);
         this.Controls.Add(this.btnPlay);
         this.Controls.Add(this.pnlCard);
         this.Name = "Play";
         this.Text = "Play";
         this.Load += new System.EventHandler(this.Play_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel pnlCard;
      private System.Windows.Forms.Button btnPlay;
      private System.Windows.Forms.TextBox txtRandNum;
      private System.Windows.Forms.Button btnDontHave;
      private System.Windows.Forms.Button button1;
   }
}