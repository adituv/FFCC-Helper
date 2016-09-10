namespace FFCC_Helper
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpBonus = new System.Windows.Forms.GroupBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.lblEnemiesKilled = new System.Windows.Forms.Label();
            this.txtEnemiesKilled = new System.Windows.Forms.TextBox();
            this.lblItemsPickedUp = new System.Windows.Forms.Label();
            this.txtItemsPickedUp = new System.Windows.Forms.TextBox();
            this.lblPointsPos = new System.Windows.Forms.Label();
            this.lblPointsNeg = new System.Windows.Forms.Label();
            this.txtPointsPos = new System.Windows.Forms.TextBox();
            this.txtPointsNeg = new System.Windows.Forms.TextBox();
            this.lblPointsTotal = new System.Windows.Forms.Label();
            this.txtPointsTotal = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grpBonus.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpBonus
            // 
            this.grpBonus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBonus.Controls.Add(this.txtPointsTotal);
            this.grpBonus.Controls.Add(this.lblPointsTotal);
            this.grpBonus.Controls.Add(this.txtPointsNeg);
            this.grpBonus.Controls.Add(this.txtPointsPos);
            this.grpBonus.Controls.Add(this.lblPointsNeg);
            this.grpBonus.Controls.Add(this.lblPointsPos);
            this.grpBonus.Controls.Add(this.txtItemsPickedUp);
            this.grpBonus.Controls.Add(this.lblItemsPickedUp);
            this.grpBonus.Controls.Add(this.txtEnemiesKilled);
            this.grpBonus.Controls.Add(this.lblEnemiesKilled);
            this.grpBonus.Controls.Add(this.txtCondition);
            this.grpBonus.Controls.Add(this.lblCondition);
            this.grpBonus.Location = new System.Drawing.Point(12, 12);
            this.grpBonus.Name = "grpBonus";
            this.grpBonus.Size = new System.Drawing.Size(272, 138);
            this.grpBonus.TabIndex = 0;
            this.grpBonus.TabStop = false;
            this.grpBonus.Text = "Bonus Points";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(6, 20);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(54, 13);
            this.lblCondition.TabIndex = 0;
            this.lblCondition.Text = "Condition:";
            // 
            // txtCondition
            // 
            this.txtCondition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCondition.Location = new System.Drawing.Point(66, 17);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.ReadOnly = true;
            this.txtCondition.Size = new System.Drawing.Size(200, 20);
            this.txtCondition.TabIndex = 1;
            // 
            // lblEnemiesKilled
            // 
            this.lblEnemiesKilled.AutoSize = true;
            this.lblEnemiesKilled.Location = new System.Drawing.Point(6, 46);
            this.lblEnemiesKilled.Name = "lblEnemiesKilled";
            this.lblEnemiesKilled.Size = new System.Drawing.Size(77, 13);
            this.lblEnemiesKilled.TabIndex = 2;
            this.lblEnemiesKilled.Text = "Enemies killed:";
            // 
            // txtEnemiesKilled
            // 
            this.txtEnemiesKilled.Location = new System.Drawing.Point(90, 43);
            this.txtEnemiesKilled.Name = "txtEnemiesKilled";
            this.txtEnemiesKilled.ReadOnly = true;
            this.txtEnemiesKilled.Size = new System.Drawing.Size(39, 20);
            this.txtEnemiesKilled.TabIndex = 3;
            // 
            // lblItemsPickedUp
            // 
            this.lblItemsPickedUp.AutoSize = true;
            this.lblItemsPickedUp.Location = new System.Drawing.Point(135, 46);
            this.lblItemsPickedUp.Name = "lblItemsPickedUp";
            this.lblItemsPickedUp.Size = new System.Drawing.Size(85, 13);
            this.lblItemsPickedUp.TabIndex = 4;
            this.lblItemsPickedUp.Text = "Items picked up:";
            // 
            // txtItemsPickedUp
            // 
            this.txtItemsPickedUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemsPickedUp.Location = new System.Drawing.Point(227, 43);
            this.txtItemsPickedUp.Name = "txtItemsPickedUp";
            this.txtItemsPickedUp.ReadOnly = true;
            this.txtItemsPickedUp.Size = new System.Drawing.Size(39, 20);
            this.txtItemsPickedUp.TabIndex = 5;
            // 
            // lblPointsPos
            // 
            this.lblPointsPos.AutoSize = true;
            this.lblPointsPos.Location = new System.Drawing.Point(6, 72);
            this.lblPointsPos.Name = "lblPointsPos";
            this.lblPointsPos.Size = new System.Drawing.Size(54, 13);
            this.lblPointsPos.TabIndex = 6;
            this.lblPointsPos.Text = "Points (+):";
            // 
            // lblPointsNeg
            // 
            this.lblPointsNeg.AutoSize = true;
            this.lblPointsNeg.Location = new System.Drawing.Point(136, 72);
            this.lblPointsNeg.Name = "lblPointsNeg";
            this.lblPointsNeg.Size = new System.Drawing.Size(51, 13);
            this.lblPointsNeg.TabIndex = 7;
            this.lblPointsNeg.Text = "Points (-):";
            // 
            // txtPointsPos
            // 
            this.txtPointsPos.Location = new System.Drawing.Point(90, 69);
            this.txtPointsPos.Name = "txtPointsPos";
            this.txtPointsPos.ReadOnly = true;
            this.txtPointsPos.Size = new System.Drawing.Size(39, 20);
            this.txtPointsPos.TabIndex = 8;
            // 
            // txtPointsNeg
            // 
            this.txtPointsNeg.Location = new System.Drawing.Point(227, 69);
            this.txtPointsNeg.Name = "txtPointsNeg";
            this.txtPointsNeg.ReadOnly = true;
            this.txtPointsNeg.Size = new System.Drawing.Size(39, 20);
            this.txtPointsNeg.TabIndex = 9;
            // 
            // lblPointsTotal
            // 
            this.lblPointsTotal.AutoSize = true;
            this.lblPointsTotal.Location = new System.Drawing.Point(81, 109);
            this.lblPointsTotal.Name = "lblPointsTotal";
            this.lblPointsTotal.Size = new System.Drawing.Size(65, 13);
            this.lblPointsTotal.TabIndex = 10;
            this.lblPointsTotal.Text = "Total points:";
            // 
            // txtPointsTotal
            // 
            this.txtPointsTotal.Location = new System.Drawing.Point(152, 106);
            this.txtPointsTotal.Name = "txtPointsTotal";
            this.txtPointsTotal.ReadOnly = true;
            this.txtPointsTotal.Size = new System.Drawing.Size(39, 20);
            this.txtPointsTotal.TabIndex = 11;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(88, 156);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect to Dolphin";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 191);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.grpBonus);
            this.MaximumSize = new System.Drawing.Size(312, 229);
            this.MinimumSize = new System.Drawing.Size(312, 229);
            this.Name = "frmMain";
            this.Text = "FFCC Helper";
            this.grpBonus.ResumeLayout(false);
            this.grpBonus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpBonus;
        private System.Windows.Forms.Label lblEnemiesKilled;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.TextBox txtPointsTotal;
        private System.Windows.Forms.Label lblPointsTotal;
        private System.Windows.Forms.TextBox txtPointsNeg;
        private System.Windows.Forms.TextBox txtPointsPos;
        private System.Windows.Forms.Label lblPointsNeg;
        private System.Windows.Forms.Label lblPointsPos;
        private System.Windows.Forms.TextBox txtItemsPickedUp;
        private System.Windows.Forms.Label lblItemsPickedUp;
        private System.Windows.Forms.TextBox txtEnemiesKilled;
        private System.Windows.Forms.Button btnConnect;
    }
}

