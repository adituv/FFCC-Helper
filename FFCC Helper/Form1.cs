using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFCC_Helper
{
    using System.Diagnostics;

    public partial class Form1 : Form
    {
        private IntPtr processHandle;

        public Form1() {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (BonusPoints.bonusTexts.ContainsKey((int)numericUpDown1.Value))
            {
                label1.Text = BonusPoints.bonusTexts[(int)numericUpDown1.Value];
            }
            else
            {
                label1.Text = BonusPoints.bonusTexts[-1] + " " + (int)numericUpDown1.Value;
            }
        }

        private void updateBonus()
        {
            byte[] buffer = new byte[1];
            int bytesRead = 0;
            NativeMethods.ReadProcessMemory((int)processHandle, 0x8020FE14, buffer, 1, ref bytesRead);

            numericUpDown1.Value = buffer[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process p = Process.GetProcessesByName("Dolphin").FirstOrDefault();
            if (p == null)
            {
                MessageBox.Show("Could not find instance of Dolphin.");
                this.Close();
            }
            processHandle = NativeMethods.OpenProcess(0x10, false, p.Id);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.updateBonus();
        }
    }
}
