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
    public partial class InfoWindow : Form
    {
        public InfoWindow()
        {
            InitializeComponent();
        }
        public InfoWindow(string language)
        {
            InitializeComponent();
            if (language == "bulgarian")
            {
                lblHeading.Text = "Правилата са лесни:";
                lblRules.Text = "Дадена ви е част от тесте карти. На всеки ход избирате по две карти. Ако лицата на картите съвпадат, те остават така до края на играта. Опитайте се да запомните къде е всяка карта!";
                btnGoBack.Text = "Връщане назад";
            }
            else
            {
                lblHeading.Text = "The rules are simple:";
                lblRules.Text = "You are given a set of cards.Each turn you can open up to two cards. If the cards have matching faces, then they stay revealed till the end of the game. Try and remember where each card is!";
                btnGoBack.Text = "Go back";
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
