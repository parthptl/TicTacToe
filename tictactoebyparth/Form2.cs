using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoebyparth
{
    public partial class Form2 : Form
    {
        bool play_against_computer = true;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.playerNames(pp1.Text, pp2.Text);
            this.Close();
           

        }

        private void pp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            button1.PerformClick();
        }

        private void pp2_TextChanged(object sender, EventArgs e)
        {

           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pp1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
