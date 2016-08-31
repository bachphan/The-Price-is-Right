namespace _3309_Group_Project
{
    partial class FrmPlayers
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOnePlayer = new System.Windows.Forms.Button();
            this.btnTwoPlayer = new System.Windows.Forms.Button();
            this.btnThreePlayer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_3309_Group_Project.Properties.Resources.PIRBackgroundIMage1;
            this.pictureBox1.Location = new System.Drawing.Point(-12, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 478);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnOnePlayer
            // 
            this.btnOnePlayer.BackColor = System.Drawing.Color.Salmon;
            this.btnOnePlayer.Location = new System.Drawing.Point(228, 165);
            this.btnOnePlayer.Name = "btnOnePlayer";
            this.btnOnePlayer.Size = new System.Drawing.Size(149, 39);
            this.btnOnePlayer.TabIndex = 1;
            this.btnOnePlayer.Text = "One Player";
            this.btnOnePlayer.UseVisualStyleBackColor = false;
            this.btnOnePlayer.Click += new System.EventHandler(this.btnOnePlayer_Click);
            // 
            // btnTwoPlayer
            // 
            this.btnTwoPlayer.BackColor = System.Drawing.Color.Salmon;
            this.btnTwoPlayer.Location = new System.Drawing.Point(228, 224);
            this.btnTwoPlayer.Name = "btnTwoPlayer";
            this.btnTwoPlayer.Size = new System.Drawing.Size(149, 39);
            this.btnTwoPlayer.TabIndex = 2;
            this.btnTwoPlayer.Text = "Two Player";
            this.btnTwoPlayer.UseVisualStyleBackColor = false;
            this.btnTwoPlayer.Click += new System.EventHandler(this.btnTwoPlayer_Click);
            // 
            // btnThreePlayer
            // 
            this.btnThreePlayer.BackColor = System.Drawing.Color.Salmon;
            this.btnThreePlayer.Location = new System.Drawing.Point(228, 288);
            this.btnThreePlayer.Name = "btnThreePlayer";
            this.btnThreePlayer.Size = new System.Drawing.Size(149, 39);
            this.btnThreePlayer.TabIndex = 3;
            this.btnThreePlayer.Text = "ThreePlayer";
            this.btnThreePlayer.UseVisualStyleBackColor = false;
            this.btnThreePlayer.Click += new System.EventHandler(this.btnThreePlayer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(162, 75);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 33);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "How Many Players";
            // 
            // FrmPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 471);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnThreePlayer);
            this.Controls.Add(this.btnTwoPlayer);
            this.Controls.Add(this.btnOnePlayer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmPlayers";
            this.Text = "FrmPlayers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOnePlayer;
        private System.Windows.Forms.Button btnTwoPlayer;
        private System.Windows.Forms.Button btnThreePlayer;
        private System.Windows.Forms.Label lblTitle;
    }
}