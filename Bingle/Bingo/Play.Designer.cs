
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
         this.SuspendLayout();
         // 
         // pnlCard
         // 
         this.pnlCard.Location = new System.Drawing.Point(340, 48);
         this.pnlCard.Name = "pnlCard";
         this.pnlCard.Size = new System.Drawing.Size(403, 483);
         this.pnlCard.TabIndex = 0;
         // 
         // Play
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 572);
         this.Controls.Add(this.pnlCard);
         this.Name = "Play";
         this.Text = "Play";
         this.Load += new System.EventHandler(this.Play_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel pnlCard;
   }
}