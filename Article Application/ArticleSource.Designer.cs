
namespace Article_Application
{
    partial class ArticleSource
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
            this.button_Exit = new System.Windows.Forms.Button();
            this.panel_ArticlesSelection = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Exit.Location = new System.Drawing.Point(13, 418);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(92, 22);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // panel_ArticlesSelection
            // 
            this.panel_ArticlesSelection.AutoScroll = true;
            this.panel_ArticlesSelection.BackColor = System.Drawing.Color.Tan;
            this.panel_ArticlesSelection.Location = new System.Drawing.Point(12, 12);
            this.panel_ArticlesSelection.Name = "panel_ArticlesSelection";
            this.panel_ArticlesSelection.Size = new System.Drawing.Size(985, 400);
            this.panel_ArticlesSelection.TabIndex = 2;
            // 
            // ArticleSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1009, 445);
            this.Controls.Add(this.panel_ArticlesSelection);
            this.Controls.Add(this.button_Exit);
            this.Name = "ArticleSource";
            this.Text = "Source";
            this.Load += new System.EventHandler(this.Techspot_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Panel panel_ArticlesSelection;
    }
}