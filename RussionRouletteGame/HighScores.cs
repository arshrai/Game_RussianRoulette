using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussionRouletteGame
{
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
        }

        string executableLocation = Path.GetDirectoryName(
        Assembly.GetExecutingAssembly().Location); //makes the location readable even if you move the folder from my computer to another one.

        private void HighScores_Load(object sender, EventArgs e)
        {
            try
            {
                string statsLocation = Path.Combine(executableLocation, "PlayerStats.txt"); //looks for the PlayerStats file inside the game folder.

                using (StreamReader sr = new StreamReader(statsLocation)) //reads the file
                {
                    string line;

                    while ((line = sr.ReadLine()) != null) //if its not empty than it reads the lines
                    {
                        var lineArray = line.Split('|'); //splits it into two pieces of information
                        int lineConvert = Convert.ToInt16(lineArray[1]); //converts the scores into interger
                        DGScores.Rows.Add(lineArray[0], lineConvert); //displays the scores in the datagrid 
                        this.DGScores.Sort(this.HighestScores, ListSortDirection.Descending); //sorts the datagrid to highest scores.
                        DGScores.RowCount = 10; //limits the rows to only show top ten
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("file cannot be read: " + ex.Message); //try/catch error message.
            }

        }
    }
}

