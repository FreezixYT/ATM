﻿
/*nom:yemane
 * prenom:aimun
 * nom:pache
 * prenom:nathan
 * classe:p1a
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Machine_Atm_Aimun_Nathan
{
    public partial class frmTwint : Form
    {
        public frmTwint()
        {
            InitializeComponent();
        }

        private void lblTwint_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            envoyerTwint envoyerTwint = new envoyerTwint();
            envoyerTwint.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRecevoir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VOTRE LOGGIN EST " + SignIn.utilisateur, "Confirmation", MessageBoxButtons.OK);

        }
    }
}

