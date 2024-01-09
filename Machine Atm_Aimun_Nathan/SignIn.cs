using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Machine_Atm_Aimun_Nathan
{
    public partial class SignIn : Form
    {
        static public List<double> listBalance = new List<double>();
        static public List<int> listMdp = new List<int>();
        static public List <string> listUtilisateur=new List<string>();
        static public double balance;
        static public int mdp;
        static public int age;
        static public string utilisateur;

        public SignIn()
        {
            InitializeComponent();
            
            
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            age = Convert.ToInt32(tbxAge.Text);
            if (age < 12)
            {
                string title = "ERROR";
                string message = "vous etes trop jeune ";
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, button);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            int mdp = Convert.ToInt32(tbxMdp);
            if (SignIn.mdp < 8)
            {
                string title = "ERROR";
                string message = "Le mot de passe est trop court ";
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, button);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    frmMain frm = new frmMain();
                    frm.Show();
                }
            }
            double balance = Convert.ToDouble(tbxBalance);
            listMdp.Add(SignIn.mdp);
            listUtilisateur.Add(SignIn.utilisateur);
            listBalance.Add(SignIn.balance);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        
        }
    }
}
