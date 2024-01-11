using System;
using System.Messaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            if (SignIn.balance >= 5)
            {

                int randomNumber1 = random.Next(1, 10);
                tbx_nb_3.Text = randomNumber1.ToString();

                int randomNumber2 = random.Next(1, 10);
                tbx_nb_2.Text = randomNumber2.ToString();

                int randomNumber3 = random.Next(1, 10);
                tbx_nb_1.Text = randomNumber3.ToString();

                string title = "";
                string message = "";

                // ACHAT DU TICKET
                double perdre = SignIn.balance - 5;

                if (randomNumber == 1)
                {
                    title = "DOMMAGE...";
                    message = "Vous avez perdu 5$";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, button);
                }
                else if (randomNumber == 2)
                {
                    double total = SignIn.balance + 10;
                    title = "BRAVO";
                    message = "VOUS AVEZ GAGNÉ " + randomNumber1;
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, button);
                }
            }

            else
            {
                MessageBox.Show("Vous n'avez pas asser pour jouer");
            }

        }

        private void tbx_nb_3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      
        }

        //argent restant
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            

        }

        private void frmLoterie_Load(object sender, EventArgs e)
        {
            textBox1.Text = SignIn.balance.ToString();

        }
    }
}
