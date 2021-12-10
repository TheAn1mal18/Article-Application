
namespace Article_Application
{
    partial class HomeScreen
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
            this.button_Techspot = new System.Windows.Forms.Button();
            this.button_Engagdet = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Signout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Techspot
            // 
            this.button_Techspot.Location = new System.Drawing.Point(12, 99);
            this.button_Techspot.Name = "button_Techspot";
            this.button_Techspot.Size = new System.Drawing.Size(185, 87);
            this.button_Techspot.TabIndex = 0;
            this.button_Techspot.Text = "Techspot";
            this.button_Techspot.UseVisualStyleBackColor = true;
            this.button_Techspot.Click += new System.EventHandler(this.button_Techspot_Click);
            // 
            // button_Engagdet
            // 
            this.button_Engagdet.Location = new System.Drawing.Point(204, 99);
            this.button_Engagdet.Name = "button_Engagdet";
            this.button_Engagdet.Size = new System.Drawing.Size(192, 87);
            this.button_Engagdet.TabIndex = 1;
            this.button_Engagdet.Text = "Engadget";
            this.button_Engagdet.UseVisualStyleBackColor = true;
            this.button_Engagdet.Click += new System.EventHandler(this.button_Engagdet_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(12, 192);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(384, 87);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_SignUp
            // 
            this.button_SignUp.Location = new System.Drawing.Point(12, 13);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(75, 23);
            this.button_SignUp.TabIndex = 3;
            this.button_SignUp.Text = "Sign Up";
            this.button_SignUp.UseVisualStyleBackColor = true;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click);
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(93, 13);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome Guest";
            // 
            // button_Signout
            // 
            this.button_Signout.Enabled = false;
            this.button_Signout.Location = new System.Drawing.Point(321, 12);
            this.button_Signout.Name = "button_Signout";
            this.button_Signout.Size = new System.Drawing.Size(75, 23);
            this.button_Signout.TabIndex = 6;
            this.button_Signout.Text = "Sign Out";
            this.button_Signout.UseVisualStyleBackColor = true;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 291);
            this.Controls.Add(this.button_Signout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.button_SignUp);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Engagdet);
            this.Controls.Add(this.button_Techspot);
            this.Name = "HomeScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Techspot;
        private System.Windows.Forms.Button button_Engagdet;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Signout;
    }
}

