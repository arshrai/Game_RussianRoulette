using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussionRouletteGame
{
    public partial class PlayerProfile : Form
    {
        public PlayerProfile()
        {
            InitializeComponent();
        }

        MainGame gameScreen = new MainGame(); //Creates the new form for the main game screen #Global Scope
        public static string playerName;

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {

            playerName = txtName.Text;

            if (txtName.Text != "") //If textbox is not empty then proceed to the keyevent
            {
                if (e.KeyCode == Keys.Enter) //Creates a keyevent so you can press enter on your keyboard
                {
                    this.Hide();
                    gameScreen.ShowDialog();
                }
            }

        }
    }
}
