using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace BasicThreading
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting threads-");
            Thread threadA = new Thread(ThreadClass.Thread1);
            threadA.Name = "Thread A";

            Thread threadB = new Thread(ThreadClass.Thread1);
            threadB.Name = "Thread B";

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            lblStatus.Text = "-End of Thread-";
            Console.WriteLine("-End of Thread-");

        }
    }
}
