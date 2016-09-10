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

    public partial class frmMain : Form
    {
        private IntPtr processHandle;

        private Bonus bonus;

        private void FindDolphin()
        {
            Process p = Process.GetProcessesByName("Dolphin").FirstOrDefault();
            if (p == null) {
                MessageBox.Show("Could not find instance of Dolphin.");
                return;
            }
            btnConnect.Enabled = false;
            processHandle = NativeMethods.OpenProcess(0x10, false, p.Id);
            timer1.Start();
        }

        public frmMain() {
            InitializeComponent();
            bonus = new Bonus(0);

            txtCondition.DataBindings.Add("Text", bonus, "Text");
            txtEnemiesKilled.DataBindings.Add("Text", bonus, "EnemiesDefeated");
            txtItemsPickedUp.DataBindings.Add("Text", bonus, "ItemsPickedUp");
            txtPointsPos.DataBindings.Add("Text", bonus, "BonusPosPoints");
            txtPointsNeg.DataBindings.Add("Text", bonus, "BonusNegPoints");
            txtPointsTotal.DataBindings.Add("Text", bonus, "Points");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool updated = bonus.Update(processHandle);
            if (!updated)
            {
                btnConnect.Enabled = true;
                timer1.Stop();
                MessageBox.Show("Lost instance of Dolphin");
            }
        }

        private void btnConnect_Click(object sender, EventArgs e) {
            this.FindDolphin();
        }
    }
}
