namespace _3309_Group_Project
{
    partial class FrmPlayerScore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlayerScore));
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayer2
            // 
            resources.ApplyResources(this.lblPlayer2, "lblPlayer2");
            this.lblPlayer2.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblPlayer2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlayer2.Name = "lblPlayer2";
            // 
            // lblPlayer3
            // 
            resources.ApplyResources(this.lblPlayer3, "lblPlayer3");
            this.lblPlayer3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPlayer3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlayer3.Name = "lblPlayer3";
            // 
            // lblPlayer1
            // 
            resources.ApplyResources(this.lblPlayer1, "lblPlayer1");
            this.lblPlayer1.BackColor = System.Drawing.Color.Red;
            this.lblPlayer1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlayer1.Name = "lblPlayer1";
            // 
            // lblScore1
            // 
            resources.ApplyResources(this.lblScore1, "lblScore1");
            this.lblScore1.Name = "lblScore1";
            // 
            // lblScore2
            // 
            resources.ApplyResources(this.lblScore2, "lblScore2");
            this.lblScore2.Name = "lblScore2";
            // 
            // lblScore3
            // 
            resources.ApplyResources(this.lblScore3, "lblScore3");
            this.lblScore3.Name = "lblScore3";
            // 
            // FrmPlayerScore
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3309_Group_Project.Properties.Resources.PIRBackgroundIMage1;
            this.Controls.Add(this.lblScore3);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer3);
            this.Controls.Add(this.lblPlayer1);
            this.Name = "FrmPlayerScore";
            this.Load += new System.EventHandler(this.FrmPlayerScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblPlayer2;
        public System.Windows.Forms.Label lblPlayer3;
        public System.Windows.Forms.Label lblPlayer1;
        public System.Windows.Forms.Label lblScore1;
        public System.Windows.Forms.Label lblScore2;
        public System.Windows.Forms.Label lblScore3;
    }
}