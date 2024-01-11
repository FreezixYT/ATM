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
        static public List <string> listUtilisateur=new List<string>();
        static public List<int> listCarteNbr = new List<int>();
        static public int carteNbr;
        static public double balance;
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
                    frmMain frmM = new frmMain();
                    frmM.Show();
                }
            }
            balance=Convert.ToDouble(tbxBalance.Text);
            utilisateur = Convert.ToString(tbxUtilisateur.Text);
            carteNbr = Convert.ToInt32(tbxCartenbr.Text);
            listUtilisateur.Add(SignIn.utilisateur);
            listBalance.Add(SignIn.balance);
            listCarteNbr.Add(SignIn.carteNbr);

            AfficheCompte frm = new AfficheCompte();
            frm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }
    }
}
