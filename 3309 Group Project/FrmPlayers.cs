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
    public partial class FrmPlayers : Form
    {
        public FrmPlayers()
        {
            InitializeComponent();
        }
        FrmChooseGame myFormChooseGame = new FrmChooseGame();
        FrmFinalShowDown FinalGame = new FrmFinalShowDown();
        private void btnOnePlayer_Click(object sender, EventArgs e)
        {
            GameSys.NumberOfPlayers = 1;

            myFormChooseGame.lblPlayer2.Visible = false;
           // myFormChooseGame.lblPlayer2Money.Visible = false; 
            myFormChooseGame.lblPlayer3.Visible = false;
           // myFormChooseGame.lblPlayer3Money.Visible = false;
            
            FinalGame.pbPlayer2.Visible = false;
            FinalGame.txtPlayer2Answer.Visible = false;
            FinalGame.pbPlayer3.Visible = false;
            FinalGame.txtPlayer3Answer.Visible = false;

            this.Hide(); 
            myFormChooseGame.ShowDialog();
        }
        private void btnTwoPlayer_Click(object sender, EventArgs e)
        {
            GameSys.NumberOfPlayers = 2;

            myFormChooseGame.lblPlayer3.Visible = false;
           // myFormChooseGame.lblPlayer3Money.Visible = false;

            FinalGame.pbPlayer3.Visible = false;
            FinalGame.txtPlayer3Answer.Visible = false;

            this.Hide(); 
            myFormChooseGame.ShowDialog();
        }

        private void btnThreePlayer_Click(object sender, EventArgs e)
        {
            GameSys.NumberOfPlayers = 3;

            this.Hide(); 
            myFormChooseGame.ShowDialog();
        }
    }
}
