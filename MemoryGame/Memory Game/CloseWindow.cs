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
    public partial class CloseWindow : Form
    {
        public CloseWindow()
        {
            InitializeComponent();
        }
        public CloseWindow(string language)
        {
            InitializeComponent();
            if (language == "bulgarian")
            {
                lblMessage.Text = "Сигурни ли сте,че искате да затворите играта?";
                button1.Text = "Да";
                button2.Text = "Не";
            }
            else
            {
                lblMessage.Text = "Are you sure you want to close the game?";
                button1.Text = "Yes";
                button2.Text = "No";
            }
        }
    }
}
