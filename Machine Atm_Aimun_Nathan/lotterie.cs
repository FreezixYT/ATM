using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_Atm_Aimun_Nathan
{

    public partial class frmLoterie : Form
    {

        static Random random = new Random();
 

        public frmLoterie()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int randomNumber = random.Next(1, 3);

            string title = "";
            string message = "";

            if (randomNumber == 1) 
            {
                title = "DOMMAGE...";
                message = "Vous avez perdu 5$";
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, button);
            }
           
            else if (randomNumber == 2) 
            {
                title = "BRAVO";
                message = "VOUS AVEZ GAGNER " + randomNumber;
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, button);
            }
           
        }

        private void tbx_nb_3_TextChanged(object sender, EventArgs e)
        {
            int randomNumber = random.Next(1, 10);

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int randomNumber = random.Next(1, 10);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int randomNumber = random.Next(1, 10);
        }

    }
}
