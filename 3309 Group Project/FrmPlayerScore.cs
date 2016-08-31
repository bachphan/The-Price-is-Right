using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3309_Group_Project
{
    public partial class FrmPlayerScore : Form
    {
        public FrmPlayerScore()
        {
            InitializeComponent();
        }

        private void FrmPlayerScore_Load(object sender, EventArgs e)
        {
            if (GameSys.NumberOfPlayers == 1)
            {
                lblPlayer2.Visible = false;
                lblScore2.Visible = false;
                lblPlayer3.Visible = false;
                lblScore3.Visible = false;
            }
            else if (GameSys.NumberOfPlayers == 2)
            {
                lblPlayer3.Visible = false;
                lblScore3.Visible = false;
            }
            lblScore1.Text = GameSys.Player1Score.ToString();
            lblScore2.Text = GameSys.Player2Score.ToString();
            lblScore3.Text = GameSys.Player3Score.ToString();
        }
    }
}
