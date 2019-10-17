using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace RussionRouletteGame
{
    public class Game
    {
        public int chanceCount = 1; //creates a counter to keep track of how many times the fire button has been pressed
        public int checkCount = 0; //creates a count to check if the "Shoot Away" checkbox is ticked. Game only allows one option to shoot away.
        public int spinChambers; //stores what chamber the bullet is in
        public int bulletCounter = 0;


        public void bulletLoad() //defining the function
        {
            SoundPlayer bulletLoad = new SoundPlayer(RussionRouletteGame.Properties.Resources.bullet_load); //Here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            bulletLoad.Play();
        }

        public void barrelSpin() //Defining the function
        {
            SoundPlayer barrelSpin = new SoundPlayer(RussionRouletteGame.Properties.Resources.barrel_spin);
            barrelSpin.Play();
        }

        public void gunShot()
        {
            SoundPlayer gunShot = new SoundPlayer(RussionRouletteGame.Properties.Resources.gun_shot);
            gunShot.Play();
        }

        public void missShot()
        {
            SoundPlayer missShot = new SoundPlayer(RussionRouletteGame.Properties.Resources.miss_fire);
            missShot.Play();
        }
    }
}
