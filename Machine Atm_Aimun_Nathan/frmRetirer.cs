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
    public partial class frmRetirer : Form
    {
        public frmRetirer()
        {
            InitializeComponent();
        }

       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //afficher le montantqui reste (retirer-montant)
        }

        private void tbxRetirer_TextChanged(object sender, EventArgs e)
        {
            //afficher un message box qui dis de recommencer si l'argent retirer est plus grnd que le montant
            double demandeRetire=Convert.ToDouble(tbxRetirer.Text);
            if (demandeRetire < listBalance(montant))
            {

            }
            //faire un meesage box avec 2 bouttons.
            //un qui dit recommencer pour recommencer et l'aure pour quitter
        }
        private void btnRetirer_Click(object sender, EventArgs e)
        {
            //afficher dans le tbxMontantReste le reste montant apres avoir retirer de 'argent
        }
    }
}
