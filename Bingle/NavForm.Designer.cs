
namespace Bingle
{
   partial class NavForm
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
         this.btnBingo = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btnBingo
         // 
         this.btnBingo.Location = new System.Drawing.Point(502, 106);
         this.btnBingo.Name = "btnBingo";
         this.btnBingo.Size = new System.Drawing.Size(75, 23);
         this.btnBingo.TabIndex = 0;
         this.btnBingo.Text = "Bingo";
         this.btnBingo.UseVisualStyleBackColor = true;
         this.btnBingo.Click += new System.EventHandler(this.btnBingo_Click);
         // 
         // Test
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.btnBingo);
         this.Name = "Test";
         this.Text = "Test";
         this.Load += new System.EventHandler(this.Test_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnBingo;
   }
}