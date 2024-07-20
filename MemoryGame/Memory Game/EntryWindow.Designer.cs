namespace Memory_Game
{
    partial class EntryWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBegin = new System.Windows.Forms.Label();
            this.lblHowToPlay = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblTranslate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBegin
            // 
            this.lblBegin.BackColor = System.Drawing.Color.Transparent;
            this.lblBegin.Font = new System.Drawing.Font("Lucida Calligraphy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBegin.ForeColor = System.Drawing.Color.Red;
            this.lblBegin.Location = new System.Drawing.Point(12, 145);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(277, 48);
            this.lblBegin.TabIndex = 0;
            this.lblBegin.Text = "Begin";
            this.lblBegin.Click += new System.EventHandler(this.lblBegin_Click);
            this.lblBegin.MouseLeave += new System.EventHandler(this.lblBegin_MouseLeave);
            this.lblBegin.MouseHover += new System.EventHandler(this.lblBegin_MouseHover);
            // 
            // lblHowToPlay
            // 
            this.lblHowToPlay.BackColor = System.Drawing.Color.Transparent;
            this.lblHowToPlay.Font = new System.Drawing.Font("Lucida Calligraphy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHowToPlay.ForeColor = System.Drawing.Color.Red;
            this.lblHowToPlay.Location = new System.Drawing.Point(12, 232);
            this.lblHowToPlay.Name = "lblHowToPlay";
            this.lblHowToPlay.Size = new System.Drawing.Size(344, 48);
            this.lblHowToPlay.TabIndex = 1;
            this.lblHowToPlay.Text = "How to play";
            this.lblHowToPlay.Click += new System.EventHandler(this.lblHowToPlay_Click);
            this.lblHowToPlay.MouseLeave += new System.EventHandler(this.lblHowToPlay_MouseLeave);
            this.lblHowToPlay.MouseHover += new System.EventHandler(this.lblHowToPlay_MouseHover);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Lucida Calligraphy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExit.ForeColor = System.Drawing.Color.Red;
            this.lblExit.Location = new System.Drawing.Point(12, 337);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(277, 48);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.lblExit_MouseHover);
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.BackColor = System.Drawing.Color.Transparent;
            this.lblGameName.Font = new System.Drawing.Font("Lucida Calligraphy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGameName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGameName.Location = new System.Drawing.Point(50, 9);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(685, 48);
            this.lblGameName.TabIndex = 4;
            this.lblGameName.Text = "Welcome to the Memory Game...";
            // 
            // lblTranslate
            // 
            this.lblTranslate.AutoSize = true;
            this.lblTranslate.BackColor = System.Drawing.Color.Transparent;
            this.lblTranslate.Font = new System.Drawing.Font("Lucida Calligraphy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTranslate.ForeColor = System.Drawing.Color.Red;
            this.lblTranslate.Location = new System.Drawing.Point(273, 432);
            this.lblTranslate.Name = "lblTranslate";
            this.lblTranslate.Size = new System.Drawing.Size(497, 48);
            this.lblTranslate.TabIndex = 5;
            this.lblTranslate.Text = "Translate to Bulgarian";
            this.lblTranslate.Click += new System.EventHandler(this.lblTranslate_Click);
            // 
            // EntryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory_Game.Properties.Resources.cardPhoto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 489);
            this.Controls.Add(this.lblTranslate);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblHowToPlay);
            this.Controls.Add(this.lblBegin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntryWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntryWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBegin;
        private Label lblHowToPlay;
        private Label lblExit;
        private Label lblGameName;
        private Label lblTranslate;
    }
}