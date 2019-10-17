using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussionRouletteGame
{
    public partial class MainGame : Form
    {
        public MainGame()
        {
            InitializeComponent();
        }

        string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); //Gets the location of where your application is stored.

        Random rnd = new Random(); //creates a random number
        Game obj_game = new Game();
        public static int Score = 0; //this is a Score counter, I made it a public static variable because I want it to carry across all forms.

        private void btnLoadBullet_Click(object sender, EventArgs e)
        {
            obj_game.bulletLoad();
            btnSpinChambers.Enabled = true; //when this button is pressed Spin Chambers button becomes available
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            btnSpinChambers.Enabled = false; //buttons will be enabled and disabled through out the game so the player doesn't click buttons I dont want them to.
            btnFire.Enabled = false;
            btnPlayAgain.Enabled = false;
            cbPointAway.Visible = false;
            cbPointAway.Enabled = false;
            lbPlayer.Text = PlayerProfile.playerName; //gets the name that the player inputs.
        }

        private void btnSpinChambers_Click(object sender, EventArgs e)
        {
            obj_game.barrelSpin();
            obj_game.spinChambers = rnd.Next(1, 7); //Creates a random number between 1 & 6 and stores it in spinChambers
            btnLoadBullet.Enabled = false; //Disables all the buttons that the user doesn't require at the start of the game.
            btnSpinChambers.Enabled = false;
            btnFire.Enabled = true;
            cbPointAway.Visible = true;
            cbPointAway.Enabled = true;

            obj_game.bulletCounter = 0; //Bullet counter to use later with if statment
            bullet1.Visible = true; //To make the bullets visible when the game starts.
            bullet2.Visible = true;
            bullet3.Visible = true;
            bullet4.Visible = true;
            bullet5.Visible = true;
            bullet6.Visible = true;

        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            pbImage2.Visible = false;
            obj_game.bulletCounter++;

            if (cbPointAway.Checked) //If the shootaway checkbox is ticked than check counter will go up. once it reaches its limit it will be disabled
            {
                obj_game.checkCount++;
                pbImage2.Show();
            }

            if (obj_game.bulletCounter == 1) //Creates a if statment for the bullet images dissapearing from screen.
            {
                bullet1.Visible = false;
            }
            else if (obj_game.bulletCounter == 2)
            {
                bullet2.Visible = false;
            }
            else if (obj_game.bulletCounter == 3)
            {
                bullet3.Visible = false;
            }
            else if (obj_game.bulletCounter == 4)
            {
                bullet4.Visible = false;
            }
            else if (obj_game.bulletCounter == 5)
            {
                bullet5.Visible = false;
            }

            if (obj_game.spinChambers == obj_game.chanceCount) //If the player fires and the bullet is in the chamber than they loose.
            {
                if (cbPointAway.Checked) //But if the shoot away is ticked than they win.
                {
                    obj_game.gunShot();
                    pbImage2.Show();
                    MessageBox.Show("CONGRATULATIONS YOU SURVIVED");

                    Score++; //Scores goes up by one if the player survives.

                    lbWins.Text = Score.ToString(); //Updates the score on the form.

                    cbPointAway.Enabled = false; //Makes the radio button unusable after the player wins. game need restarting to use again.
                    cbPointAway.Visible = false;
                    cbPointAway.Checked = false;
                    btnFire.Enabled = false;
                    btnPlayAgain.Enabled = true;
                    return; //Returns to the form so the player can choose what to do next.

                }
                else if (cbPointAway.Checked == false) //If the shoot away checkbox is not ticked than player looses.
                {
                    pbImage3.Show(); //Shows the game over image I saved
                    obj_game.gunShot(); //Gunshot noise 
                    MessageBox.Show("YOU GOT SHOT!" + "\nGAME OVER"); //Messagebox to show that the player lost
                    btnPlayAgain.Enabled = true; //Buttons are enabled again for the player to start a new game
                    btnFire.Enabled = false;
                    cbPointAway.Visible = false;
                    cbPointAway.Enabled = false;
                    return; //Returns the player to the game screen instead of the other lines of codes executing.
                }

            }
            else
            {
                obj_game.missShot();
                //MessageBox.Show(spinChambers.ToString()); //enable maeesagebox to check random number generator
                obj_game.chanceCount++;
            }

            if (obj_game.checkCount == 2) //Disables the checkbox after it has been checked once. 
            {
                cbPointAway.Checked = false;
                cbPointAway.Visible = false;
                cbPointAway.Enabled = false;
                lblWaitingToDIe.Visible = true;
            }

        }

        private void btnPlayAgain_Click(object sender, EventArgs e) //Resets the information on the form so the player can start again
        {
            obj_game.chanceCount = 1; //I've only resetted buttons and counters but not the score so the game knows to track all the scores. 
            obj_game.checkCount = 0;
            rnd.Next(); //resets the random number to store the bullet in another chamber for the next round.
            btnLoadBullet.Enabled = true;
            cbPointAway.Enabled = false;
            cbPointAway.Visible = false;
            btnFire.Enabled = false;
            pbImage2.Visible = false;
            pbImage3.Visible = false;
            lblWaitingToDIe.Visible = false;

            bullet1.Visible = false;
            bullet2.Visible = false;
            bullet3.Visible = false;
            bullet4.Visible = false;
            bullet5.Visible = false;
            bullet6.Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btn_Score_Click(object sender, EventArgs e)
        {
            string statsLocation = Path.Combine(executableLocation, "PlayerStats.txt"); //Tells the location and stores the score as a text file in the /bin folder

            using (StreamWriter sw = File.AppendText(statsLocation))
            {
                sw.WriteLine(PlayerProfile.playerName + "|" + Score);
            }
        }
    }
}
