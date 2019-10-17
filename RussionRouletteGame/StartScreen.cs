using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussionRouletteGame
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the application
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            PlayerProfile enterName = new PlayerProfile(); //links new form to this form
            enterName.ShowDialog(); //Opens the form that was created
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            HighScores scoresScreen = new HighScores();
            scoresScreen.ShowDialog();
        }
    }
}
