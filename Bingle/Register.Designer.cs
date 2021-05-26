
namespace Bingle
{
   partial class Register
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
         this.btnRegister = new System.Windows.Forms.Button();
         this.txtFirstname = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.txtUsername = new System.Windows.Forms.TextBox();
         this.txtLastname = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnRegister
         // 
         this.btnRegister.Location = new System.Drawing.Point(350, 330);
         this.btnRegister.Name = "btnRegister";
         this.btnRegister.Size = new System.Drawing.Size(75, 23);
         this.btnRegister.TabIndex = 0;
         this.btnRegister.Text = "Register";
         this.btnRegister.UseVisualStyleBackColor = true;
         this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
         // 
         // txtFirstname
         // 
         this.txtFirstname.Location = new System.Drawing.Point(325, 107);
         this.txtFirstname.Name = "txtFirstname";
         this.txtFirstname.Size = new System.Drawing.Size(100, 20);
         this.txtFirstname.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(231, 110);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(49, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Firsname";
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(325, 217);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Size = new System.Drawing.Size(100, 20);
         this.txtPassword.TabIndex = 3;
         // 
         // txtUsername
         // 
         this.txtUsername.Location = new System.Drawing.Point(325, 180);
         this.txtUsername.Name = "txtUsername";
         this.txtUsername.Size = new System.Drawing.Size(100, 20);
         this.txtUsername.TabIndex = 5;
         // 
         // txtLastname
         // 
         this.txtLastname.Location = new System.Drawing.Point(325, 145);
         this.txtLastname.Name = "txtLastname";
         this.txtLastname.Size = new System.Drawing.Size(100, 20);
         this.txtLastname.TabIndex = 6;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(231, 152);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(53, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "Lastname";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(231, 187);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(55, 13);
         this.label3.TabIndex = 8;
         this.label3.Text = "Username";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(231, 220);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(53, 13);
         this.label4.TabIndex = 9;
         this.label4.Text = "Password";
         // 
         // Register
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtLastname);
         this.Controls.Add(this.txtUsername);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtFirstname);
         this.Controls.Add(this.btnRegister);
         this.Name = "Register";
         this.Text = "Register";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnRegister;
      private System.Windows.Forms.TextBox txtFirstname;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.TextBox txtUsername;
      private System.Windows.Forms.TextBox txtLastname;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
   }
}