using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Bulls_and_Cows
{



    public partial class Form2 : Form
    {
        //Generates a digit used by the CPU
        public int GenDigit()
        {
            Random randomDigit = new Random();
            return randomDigit.Next(10);
        }

        // Checks if a digit is contained in the array
        bool HasDigitsinArray(int[] arr, int digit)
        {
            for (int counter = 0; counter < arr.Length; ++counter)
                if (arr[counter] == digit)
                    return true;
            return false;
        }

        //Generates a 4-digit number used by the CPU
        public int[] GenFourDigit()
        {
            int[] arr = new int[4] ;
            int digit;
            for (int counter = 0; counter < 4; ++counter)
            {
                digit = GenDigit();
                if (!HasDigitsinArray(arr, digit))
                    arr[counter] = digit;
                else
                    --counter;
            }
            return arr;
        }

        //Prepares the screen for a new game
        public void SetNewGame()
        {
            Game.cpuNum = GenFourDigit();
            StepsCounter.Text = "0";
            HintRes.Text = "";
            InputField.Text = "";
        }

        //Load a ListBox with past Scores
        public void LoadHighScores()
        {
            Player[] players;
            using (StreamReader File = new StreamReader(@"..\HighScores.xml"))
            {
                players=(Player[])new XmlSerializer(typeof(Player[])).Deserialize(File);
                File.Close();
            }

            for (int counter = 0; counter < players.Length; ++counter)
            {
                string[] row = new string[] { players[counter].Name, Convert.ToString(players[counter].Steps) };
                ListViewItem newItem = new ListViewItem(row);
                newItem.Tag = players[counter];
                HighScores.Items.Add(newItem);
            }
        }

        public String arrToString()
        {
            return Convert.ToString(Game.playerNum[0]) + Convert.ToString(Game.playerNum[1]) + Convert.ToString(Game.playerNum[2]) + Convert.ToString(Game.playerNum[3]);
        }

        public bool easyDiff=false;
        public int ticks = 0;

        public Form2()
        {
            InitializeComponent();

            LoadHighScores();
            SetNewGame();
        }

        //Processes the user input
        private void EnterField_Click(object sender, EventArgs e)
        {
            Array.Clear(Game.playerNum, 0, 4);

            int num;
            try
            {
                num = Convert.ToInt32(InputField.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            if (num > 9999 || num < 1000)
            {
                MessageBox.Show("Number is not 4 digit");
                return;
            }

            //Enters the Player number into a array by checking first if the numbers are unique 
            int counter = 0;
            int dec = 1000;
            while (num != 0)
            {
                if (HasDigitsinArray(Game.playerNum, num / dec))
                {
                    MessageBox.Show("Digits must be unique");
                    return;
                }
                Game.playerNum[counter++] = num / dec;
                num %= dec;
                dec /= 10;
            }

            int bulls = 0,
                cows = 0;

            for (int pos = 0; pos < 4; ++pos)
            {
                if (Game.playerNum[pos] == Game.cpuNum[pos])
                {
                    ++bulls;
                    continue;
                }

                if (HasDigitsinArray(Game.cpuNum, Game.playerNum[pos]))
                    ++cows;
            }

            // Four bulls means that all the digits are in the collect place
            if (bulls == 4)
            {
                MessageBox.Show("You win");

                using (Form3 playerInput = new Form3())
                {
                    playerInput.ShowDialog();
                    Player currPlayer = new Player(playerInput.getName, Convert.ToInt32(StepsCounter.Text));
                    string[] row = new string[] { currPlayer.Name, Convert.ToString(currPlayer.Steps) };
                    var newItem = new ListViewItem(row);
                    newItem.Tag = currPlayer;
                    HighScores.Items.Add(newItem);
                }
               
                ResultList.Sort();
                SetNewGame();
            }
            else // Notifies the Player of the progress of the game
            {
                if (!easyDiff)
                    if (ResultList.Items.Count == 1)
                        ResultList.Items[0].Remove();

                Result res = new Result(cows, bulls);
                string[] row = new string[] { arrToString(),Convert.ToString( bulls), Convert.ToString( cows) };
                ListViewItem newItem = new ListViewItem(row);
               // newItem.Tag = res;
                ResultList.Items.Insert(0, newItem);

                int convertedSteps = Convert.ToInt32(StepsCounter.Text) + 1;
                StepsCounter.Text = convertedSteps.ToString();

            }
            if (!easyDiff)
                hardTimer.Start();
        }

        // Button that displays a hint only once
        private void HelpButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int pos = rand.Next(4);

            for(int counter=0;counter<4;++counter)
            {
                if (counter == pos)
                    HintRes.Text += Game.cpuNum[pos];
                else
                    HintRes.Text += 'X';
            }

            if(!easyDiff)
                hardTimer.Start();

            HelpButton.Enabled = false;
        }

        // Stops the game and closes the app
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ListViewItem[] items = new ListViewItem[HighScores.Items.Count];
            HighScores.Items.CopyTo(items, 0);

            Player[] players = new Player[items.Length];
            for(int counter=0;counter<items.Length;++counter)
                players[counter] = (Player)items[counter].Tag;

            using (StreamWriter File = new StreamWriter(@"..\HighScores.xml"))               
                new XmlSerializer(typeof(Player[])).Serialize(File, players);

            this.Close();
        }

        // Timer used in Hard Difficulty to hide the results of each input after 10 seconds
        private void Timer1_Tick(object sender, EventArgs e)
        {
            ++ticks;
            if (ticks == 10)
            {
                HintRes.Hide();

                if(ResultList.Items.Count>0)
                    ResultList.Items[0].Remove();
                ticks = 0;
                hardTimer.Stop();
            }
        }

        // Enables the pressing of the Enter key to act as the Enter button
        private void InputField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EnterField_Click(sender,  e);
        }

        // Stops the game and takes the player back to the Main Menu to select the difficulty
        private void MainMenu_Click(object sender, EventArgs e)
        {
            Form1 newStart = new Form1();
            CloseBtn_Click(sender, e);
            newStart.Show();
        }
    }
}
