namespace Memory_Game
{
    public partial class EntryWindow : Form
    {
        double font =28;
        string language = "english";
        public EntryWindow()
        {
            InitializeComponent();
        }

        private void EntryWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            CloseWindow close = new CloseWindow(language);
            DialogResult result = close.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            this.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBegin_MouseHover(object sender, EventArgs e)
        {
            lblBegin.Font = new Font("Lucida Calligraphy", lblBegin.Font.Size+5);
        }

        private void lblBegin_MouseLeave(object sender, EventArgs e)
        {
            if(lblBegin.Font.Size>font)
            {
                lblBegin.Font = new Font("Lucida Calligraphy", lblBegin.Font.Size - 5);
            } 
        }

        private void lblHowToPlay_MouseHover(object sender, EventArgs e)
        {
            lblHowToPlay.Font = new Font("Lucida Calligraphy", lblBegin.Font.Size + 5);
        }

        private void lblHowToPlay_MouseLeave(object sender, EventArgs e)
        {
            if(lblHowToPlay.Font.Size>font)
            {
                lblHowToPlay.Font = new Font("Lucida Calligraphy", lblBegin.Font.Size - 5);
            } 
        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            lblExit.Font = new Font("Lucida Calligraphy", lblBegin.Font.Size + 5);
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            if(lblExit.Font.Size>font)
            {
                lblExit.Font = new Font("Lucida Calligraphy", lblBegin.Font.Size - 5);
            }
      
        }

        private void lblHowToPlay_Click(object sender, EventArgs e)
        {
            InfoWindow info = new InfoWindow(language);
            this.Hide();
            info.ShowDialog();
            this.Show();
        }

        private void lblBegin_Click(object sender, EventArgs e)
        {
            GameWindow game = new GameWindow(language);
            this.Hide();
            game.ShowDialog();
            this.Show();
        }

        private void lblTranslate_Click(object sender, EventArgs e)
        {
            if(language=="english")
            {
                language = "bulgarian";
                lblBegin.Text = "Започни игра";
                lblExit.Text = "Напусни игра";
                lblHowToPlay.Text = "Как се играе:";
                lblTranslate.Text = "Преведи на английски";
                lblGameName.Text = "Добре дошли в Игра за памет...";
            }
            else
            {
                language = "english";
                lblBegin.Text = "Begin";
                lblHowToPlay.Text = "How to play";
                lblExit.Text = "Exit";
                lblTranslate.Text = "Translate to bulgarian";
                lblGameName.Text = "Welcome to the Memory Game...";
            }
            
        }
    }
}