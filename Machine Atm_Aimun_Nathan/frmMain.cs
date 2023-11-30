using System;
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

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        }
    }
}
