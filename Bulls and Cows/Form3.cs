using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulls_and_Cows
{
    // Used for saving a high score after successfully finishing a game
    public partial class Form3 : Form
    {
        public string getName
        {
            get
            {
                return textBox1.Text;
            }
        }


        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Button1_Click(sender, e);
        }
    }
}
