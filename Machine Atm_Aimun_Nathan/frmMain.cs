using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_Atm_Aimun_Nathan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAjouter frm = new frmAjouter();
            frm.Show();
            SystemSounds.Question.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRetirer frm = new frmRetirer();
            frm.Show();
            SystemSounds.Asterisk.Play();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
