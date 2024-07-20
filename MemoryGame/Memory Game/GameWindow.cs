using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class GameWindow : Form
    {
        Random random = new Random();
        List<int> icons = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6,7,7,0,0};
        Label firstClicked, secondClicked;
        string language;
        public GameWindow(string Language)
        {
            InitializeComponent();
            this.language = Language;
            SetIconsToSquares();
        }

        private void label_click(object sender, EventArgs e)
        {
            if(firstClicked!=null&&secondClicked!=null)
            {
                return;
            }
            Label clickedLabel = sender as Label;
            if(clickedLabel.ForeColor!=Color.LightBlue)
            {
                if(language=="bulgarian")
                {
                    MessageBox.Show("Вече сте отворили тази карта!");
                }
                else
                {
                    MessageBox.Show("Card already opened!");
                }
                return;
            }
            switch (int.Parse(clickedLabel.Text))
            {
                case 1:
                    clickedLabel.Image = Properties.Resources.smallAceOfHearts;
                    break;
                case 2:
                    clickedLabel.Image = Properties.Resources.superSmallAceOfSpades;
                    break;
                case 3:
                    clickedLabel.Image = Properties.Resources.smallAceOfDiamonds;
                    break;
                case 4:
                    clickedLabel.Image = Properties.Resources.smallAceOfClubs;
                    break;
                case 5:
                    clickedLabel.Image = Properties.Resources.smallQueen;
                    break;
                case 6:
                    clickedLabel.Image = Properties.Resources.smallJack;
                    break;
                case 7:
                    clickedLabel.Image = Properties.Resources.smallJoker;
                    break;
                case 0:
                    clickedLabel.Image = Properties.Resources.extraSmallKing;
                    break;
            }
            if (firstClicked==null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Transparent;
                return;
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Transparent;
            CheckWinner();
            if(firstClicked.Text==secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
            {
                timer1.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.Image = null;
            secondClicked.Image = null;
            firstClicked.ForeColor = Color.LightBlue;
            secondClicked.ForeColor = Color.LightBlue;
            firstClicked = null; 
            secondClicked = null;
            
        }

        private void SetIconsToSquares()
        {
            Label label;
            int randomNumber;
            for (int i = 0; i <table.Controls.Count; i++)
            {
                if(table.Controls[i] is Label)
                {
                    label = (Label)table.Controls[i];  
                }
                else
                {
                    continue;
                }
                randomNumber = random.Next(0, icons.Count);
                label.Text = icons[randomNumber].ToString();
                icons.RemoveAt(randomNumber);
            }
        }
        private void CheckWinner()
        {
            Label label;
            for (int i = 0; i <table.Controls.Count; i++)
            {
                label = table.Controls[i] as Label;
                if(label!=null&&label.Image==null)
                {
                    return;
                }
            }
            if(language=="bulgarian")
            {
                MessageBox.Show("Браво!Спечелихте!");
            }
            else
            {
                MessageBox.Show("You won!Congratulations!");
            }
            this.Close();
        }

    }
}
