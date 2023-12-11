﻿using System;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Machine_Atm_Aimun_Nathan
{
    public partial class frmMain : Form
    {
        private bool isAlarmOn = false;
        private Thread alarmThread;

        public frmMain()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!isAlarmOn)
            {
                isAlarmOn = true;
                alarmThread = new Thread(PlayAlarm);
                alarmThread.Start();
            }
            else
            {
                isAlarmOn = false;
                
            }
        }

        private void PlayAlarm()
        {
            while (isAlarmOn)
            {
                
                this.Invoke((MethodInvoker)delegate
                {
                    Console.Beep(1000, 500); 
                });
                Thread.Sleep(200); 
            }   

                Thread.Sleep(20); 
        }

        private void btnCompte_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
        }

        private void btnTwint_Click(object sender, EventArgs e)
        {
            frmTwint frm = new frmTwint();
            frm.Show();
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjouter frm = new frmAjouter();
            frm.Show();
        }

        private void retirerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRetirer frm = new frmRetirer();
        }

        private void twintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTwint twint = new frmTwint();  
            twint.Show();
        }

        private void lotterieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTwint lotterie = new frmTwint();
            lotterie.Show();
        }
    }
}

