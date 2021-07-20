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
        public class OLDWay
        {
        //    public Button RedButton;
        //    public Button BlueButton;
        //    public Button GreenButton;
        //    public Button YellowButton;
        //    // TickTock sets the speed that the pattern is played at, this can be decreased for faster play of the pattern (increase difficulty)
        //    public Timer TickTock = new Timer() { Interval = 1000 };
        //    public Timer flashTimer;
        //    public int flashTimerTicks = 0;

        //    // not necessarily the way I want it, just some temporary bones
        //    ///////
        //    public List<string> Colors = new List<string>()
        //    {
        //    "red",
        //    "blue",
        //    "green",
        //    "yellow"
        //    };
        //    public Queue<int> MemoryPattern = new Queue<int>();
        //    ////////
        //    private void BeginBtn_Click(object sender, EventArgs e)
        //    {
        //        // Important that a new timer is instantiated everytime, otherwise the timer picks up from where it stopped, causing issues with the flashAllButtons
        //        flashTimer = new Timer() { Interval = 250 };
        //        flashTimerTicks = 0;
        //        flashTimer.Start();
        //        flashTimer.Tick += FlashAllButtons;
        //    }
        //    private void FlashAllButtons(object sender, EventArgs e)
        //    {
        //        // this replicates all the buttons flashing when a new game starts
        //        flashTimerTicks++;
        //        //Console.WriteLine(flashTimerTicks);
        //        if (flashTimerTicks >= 6)
        //        {
        //            // On and Off 3 times
        //            flashTimer.Stop();
        //        }
        //        //red
        //        FlashSinglebutton(RedButton);
        //        //blue
        //        FlashSinglebutton(BlueButton);
        //        //green
        //        FlashSinglebutton(GreenButton);
        //        //yellow
        //        FlashSinglebutton(YellowButton);
        //    }
        //    private void FlashSinglebutton(Button button)
        //    {
        //        //remake this so it doesn't need to be called twice
        //        //it can flash on, wait a second and then turn off
        //        //var unlitColor = button.BackColor;
        //        Console.WriteLine(button.Name);
        //        switch (button.Name)
        //        {
        //            case "RedBtn":
        //                if (button.BackColor == Color.DarkRed)
        //                {
        //                    button.BackColor = Color.Red;
        //                }
        //                else
        //                {
        //                    button.BackColor = Color.DarkRed;
        //                }
        //                break;
        //            case "BlueBtn":
        //                if (button.BackColor == Color.DarkBlue)
        //                {
        //                    button.BackColor = Color.Blue;
        //                }
        //                else
        //                {
        //                    button.BackColor = Color.DarkBlue;
        //                }
        //                break;
        //            case "GreenBtn":
        //                if (button.BackColor == Color.DarkGreen)
        //                {
        //                    button.BackColor = Color.LimeGreen;
        //                }
        //                else
        //                {
        //                    button.BackColor = Color.DarkGreen;
        //                }
        //                break;
        //            case "YellowBtn":
        //                if (button.BackColor == Color.Olive)
        //                {
        //                    button.BackColor = Color.Yellow;
        //                }
        //                else
        //                {
        //                    button.BackColor = Color.Olive;
        //                }
        //                break;

        //            default:
        //                break;
        //        }
        //        //button.BackColor = unlitColor;
        //    }
        //    private void BuildPattern()
        //    {
        //        //create a list/queue/array that will be checked against after every user click
        //        //MemoryPattern.Enqueue();
        //    }
        //    private void PlayPattern()
        //    {
        //        //foreach color in list, flashsinglebutton
        //    }
        //    private void CheckPattern()
        //    {
        //        //this will be called after user click, probably check the color at the current index is the same?
        //    }

        }

        public List<int> BuiltPattern = new List<int>();
        public int RoundNumber = 0;
        public List<int> AttemptedPattern = new List<int>();
        public int difficulty = 500;

        public Form1()
        {
            InitializeComponent();
            BuildPattern();
            //foreach (int piece in BuiltPattern) Console.WriteLine(piece);
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
                BuiltPattern.Add(rd.Next(0, 4));
            }
            //foreach (int piece in BuiltPattern) Console.WriteLine(piece);
        }

        public async void PlayPattern()
        {
            foreach (int item in BuiltPattern)
            {
                Console.WriteLine(item);
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
        
        public void CheckPattern()
        {
            //Check attempted versus built
            for (int i = 0; i < AttemptedPattern.Count; i++)
            {
                if (BuiltPattern[i] != AttemptedPattern[i])
                {
                    MessageBox.Show($"Game over, Highscore of {RoundNumber} rounds");
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
                PlayPattern();
            }
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button thisBtn = (Button)sender;
            Console.WriteLine(thisBtn.Name);
            AttemptedPattern.Add(thisBtn.TabIndex);
            CheckPattern();
        }

        private void BeginClicked(object sender, EventArgs e)
        {
            PlayPattern();
        }
        
        private void FlashButton(Button button)
        {
            var redOn = Color.Red;
            var redOff = Color.DarkRed;
            var blueOn = Color.Blue;
            var blueOff = Color.DarkBlue;
            var greenOn = Color.LimeGreen;
            var greenOff = Color.DarkGreen;
            var yellowOn = Color.Yellow;
            var yellowOff = Color.Olive;
            switch (button.TabIndex)
            {
                case 0:
                    if(button.BackColor == redOff)
                    {
                        button.BackColor = redOn;
                    } else
                    {
                        button.BackColor = redOff;
                    }
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                default:

                    break;
            }
        }
        private async void singleSequenceFlash(Button btn)
        {
            btn.BackColor = Color.Yellow;
            await Task.Delay(difficulty);
            btn.BackColor = Color.Black;
        }

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
    }
}
