﻿
namespace Bingle
{
   partial class Test
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
         this.txtCard = new System.Windows.Forms.TextBox();
         this.btnSave = new System.Windows.Forms.Button();
         this.txtNumber = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.btnUpdate = new System.Windows.Forms.Button();
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
         // txtCard
         // 
         this.txtCard.Location = new System.Drawing.Point(288, 155);
         this.txtCard.Name = "txtCard";
         this.txtCard.Size = new System.Drawing.Size(100, 20);
         this.txtCard.TabIndex = 1;
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(277, 232);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(75, 23);
         this.btnSave.TabIndex = 2;
         this.btnSave.Text = "SAVE";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.button1_Click);
         // 
         // txtNumber
         // 
         this.txtNumber.Location = new System.Drawing.Point(288, 191);
         this.txtNumber.Name = "txtNumber";
         this.txtNumber.Size = new System.Drawing.Size(100, 20);
         this.txtNumber.TabIndex = 3;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(216, 161);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(62, 13);
         this.label1.TabIndex = 4;
         this.label1.Text = "Bingo Card ";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(216, 198);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(44, 13);
         this.label2.TabIndex = 5;
         this.label2.Text = "Number";
         // 
         // btnUpdate
         // 
         this.btnUpdate.Location = new System.Drawing.Point(358, 232);
         this.btnUpdate.Name = "btnUpdate";
         this.btnUpdate.Size = new System.Drawing.Size(75, 23);
         this.btnUpdate.TabIndex = 6;
         this.btnUpdate.Text = "UPDATE";
         this.btnUpdate.UseVisualStyleBackColor = true;
         // 
         // Test
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.btnUpdate);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtNumber);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.txtCard);
         this.Controls.Add(this.btnBingo);
         this.Name = "Test";
         this.Text = "Test";
         this.Load += new System.EventHandler(this.Test_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnBingo;
      private System.Windows.Forms.TextBox txtCard;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.TextBox txtNumber;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btnUpdate;
   }
}