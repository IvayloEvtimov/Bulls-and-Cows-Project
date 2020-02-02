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
    // First screen to be loaded when starting the game
    public partial class Form1 : Form
    {
        readonly XmlSerializer mySerial = new XmlSerializer(typeof(GameRules));

        public bool easyDiff = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            using (StreamReader File = new StreamReader(@"..\How to play.xml"))
            {
                GameRules gamebook = (GameRules)mySerial.Deserialize(File);
                File.Close();
                MessageBox.Show(gamebook.ToString());
            }

        }

        private void EasyBtn_Click(object sender, EventArgs e)
        {
            Form2 gameScreen = new Form2();
            this.Hide();
            gameScreen.easyDiff = true;
            gameScreen.Show();
            
        }

        private void HardBtn_Click(object sender, EventArgs e)
        {
            Form2 gameScreen = new Form2();
            this.Hide();
            gameScreen.easyDiff = false;
            gameScreen.Show();
        }
    }
}
