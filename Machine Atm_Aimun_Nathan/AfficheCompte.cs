﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_Atm_Aimun_Nathan
{
    public partial class AfficheCompte : Form
    {
        public AfficheCompte()
        {
            InitializeComponent();


        }

        private void lblUtilisateur_Click(object sender, EventArgs e)
        {
            lblUtilisateur.Text =SignIn.utilisateur;
        }

        private void btnReturner_Click(object sender, EventArgs e)
        {
            frmMain frm=new frmMain();
            frm.ShowDialog();
        }
    }
}
