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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tbxArgentAEnvoyer_TextChanged(object sender, EventArgs e)
        {
            string somme = Convert.ToString(tbxArgentAEnvoyer);
        }
    }
}
