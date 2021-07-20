using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueSeraSera
{
    public partial class Form1 : Form
    {
        public List<int> BuiltPattern = new List<int>();
        public List<int> AttemptedPattern = new List<int>();
        public int RoundNumber = 0;
        public int difficulty = 500;
        public bool gameOn = false;

        public Form1()
        {
            InitializeComponent();
            //BuildPattern();
        }

        public void BuildPattern()
        {
            //start with length of 4 and then increment by one for each win?
            Random rd = new Random();
            if (RoundNumber == 0)
            {
                for (int index = 0; index < 4; index++)
                {
                    int PieceOfPattern = rd.Next(0,4);
                    BuiltPattern.Add(PieceOfPattern);
                }
            } else
            {
                int PieceOfPattern = rd.Next(0, 4);
                BuiltPattern.Add(PieceOfPattern);
            }
        }

        private void BeginClicked(object sender, EventArgs e)
        {
            BuildPattern();
            PlayPattern();
            gameOn = true;
        }

        public async void PlayPattern()
        {
            foreach (int item in BuiltPattern)
            {
                switch (item)
                {
                    case 0:
                        RedBtn.BackColor = Color.Red;
                        await Task.Delay(difficulty);
                        RedBtn.BackColor = Color.DarkRed;
                        await Task.Delay(difficulty);
                        break;
                    case 1:
                        BlueBtn.BackColor = Color.Blue;
                        await Task.Delay(difficulty);
                        BlueBtn.BackColor = Color.DarkBlue;
                        await Task.Delay(difficulty);
                        break;
                    case 2:
                        GreenBtn.BackColor = Color.LimeGreen;
                        await Task.Delay(difficulty);
                        GreenBtn.BackColor = Color.DarkGreen;
                        await Task.Delay(difficulty);
                        break;
                    case 3:
                        YellowBtn.BackColor = Color.Yellow;
                        await Task.Delay(difficulty);
                        YellowBtn.BackColor = Color.Olive;
                        await Task.Delay(difficulty);
                        break;
                    default:
                        break;
                }
            }
            
        }
        
        private void ButtonClicked(object sender, EventArgs e)
        {
            if (gameOn == true)
            {
                Button thisBtn = (Button)sender;
                AttemptedPattern.Add(thisBtn.TabIndex);
                CheckPattern();
            }
        }

        public async void CheckPattern()
        {
            //Check attempted versus built
            for (int i = 0; i < AttemptedPattern.Count; i++)
            {
                if (BuiltPattern[i] != AttemptedPattern[i])
                {
                    MessageBox.Show($"Game over, Highscore of {RoundNumber} rounds");
                    gameOn = false;
                    return;
                }
            }
            if (BuiltPattern.Count == AttemptedPattern.Count)
            {
                MessageBox.Show("Round Passed");
                RoundNumber++;
                difficulty -= 50;
                BuildPattern();
                AttemptedPattern.Clear();
                await Task.Delay(difficulty);
                PlayPattern();
            }
        }


        
        // These 'light' the buttons up when clicked
        private void RedBtn_MouseDown(object sender, MouseEventArgs e)
        {
            RedBtn.BackColor = Color.Red;
        }
        private void RedBtn_MouseUp(object sender, MouseEventArgs e)
        {
            RedBtn.BackColor = Color.DarkRed;
        }
        private void BlueBtn_MouseDown(object sender, MouseEventArgs e)
        {
            BlueBtn.BackColor = Color.Blue;
        }
        private void BlueBtn_MouseUp(object sender, MouseEventArgs e)
        {
            BlueBtn.BackColor = Color.DarkBlue;
        }
        private void GreenBtn_MouseDown(object sender, MouseEventArgs e)
        {
            GreenBtn.BackColor = Color.LimeGreen;
        }
        private void GreenBtn_MouseUp(object sender, MouseEventArgs e)
        {
            GreenBtn.BackColor = Color.DarkGreen;
        }
        private void YellowBtn_MouseDown(object sender, MouseEventArgs e)
        {
            YellowBtn.BackColor = Color.Yellow;
        }
        private void YellowBtn_MouseUp(object sender, MouseEventArgs e)
        {
            YellowBtn.BackColor = Color.Olive;
        }
        //-------------------------------------------
    }
}
