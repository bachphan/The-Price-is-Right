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
    public partial class FrmChooseGame : Form
    {
        Player player = new Player("Player");
        public FrmChooseGame()
        {
            InitializeComponent();
            //btnContinue.Visible = false;
            lblTurnP1.Visible = true;

            //lblPlayer1Money.Text = "0";
            //lblPlayer2Money.Text = "0";
            //lblPlayer3Money.Text = "0";
        }
        FrmCheckOut myFormCheckOut = new FrmCheckOut();
        FrmDoublePrice myFormDoublePrice = new FrmDoublePrice();
        FrmEasy123 myFormEasy123 = new FrmEasy123();
        FrmGoldenRoad myFormGoldenRoad = new FrmGoldenRoad();
        FrmMostExpensive myFormMostExpensive = new FrmMostExpensive();
        FrmOneWrongPrice myFormOneWrongPrice = new FrmOneWrongPrice();
        FrmFinalShowDown myFormFinalShowDown = new FrmFinalShowDown();
        FrmPlayerScore myFormPlayerScore = new FrmPlayerScore(); 
        int counter = 6;
        int turn = 1;
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            myFormCheckOut.ShowDialog();
            btnCheckOut.Visible = false;
            counter--;
            turn++;
            if (lblPlayer2.Visible == true && lblPlayer3.Visible == true)
            {
                if (turn == 2 || turn == 5)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = true;
                    lblTurnP3.Visible = false;
                    GameSys.WhoseTurnPlayer = 2;
                }
                else if (turn == 3 || turn == 6)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = false;
                    lblTurnP3.Visible = true;
                    GameSys.WhoseTurnPlayer = 3;
                }
                else if (turn == 1 || turn == 4)
                {
                    lblTurnP1.Visible = true;
                    lblTurnP2.Visible = false;
                    lblTurnP3.Visible = false;
                    GameSys.WhoseTurnPlayer = 1;
                }
            }
            if (lblPlayer2.Visible == true && lblPlayer3.Visible == false)
            {
                if (turn == 2 || turn == 4 || turn == 6)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = true;
                    GameSys.WhoseTurnPlayer = 2;
                }
                else if (turn == 1 || turn == 3 || turn == 5)
                {
                    lblTurnP1.Visible = true;
                    lblTurnP2.Visible = false;
                    GameSys.WhoseTurnPlayer = 1;
                }
            }
        }

        private void btnEasyAs123_Click(object sender, EventArgs e)
        {
            myFormEasy123.ShowDialog();
            btnEasyAs123.Visible = false;
            counter--;
            turn++;
            if (lblPlayer2.Visible == true && lblPlayer3.Visible == true)
            {
                if (turn == 2 || turn == 5)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = true;
                    lblTurnP3.Visible = false;
                    GameSys.WhoseTurnPlayer = 2;
                }
                else if (turn == 3 || turn == 6)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = false;
                    lblTurnP3.Visible = true; 
                    GameSys.WhoseTurnPlayer = 3;

                }
                else if (turn == 1 || turn == 4)
                {
                    lblTurnP1.Visible = true;
                    lblTurnP2.Visible = false;
                    lblTurnP3.Visible = false; GameSys.WhoseTurnPlayer = 1;

                }
            }
            if (lblPlayer2.Visible == true && lblPlayer3.Visible == false)
            {
                if (turn == 2 || turn == 4 || turn == 6)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = true;
                    GameSys.WhoseTurnPlayer = 2;
                }
                else if (turn == 1 || turn == 3 || turn == 5)
                {
                    lblTurnP1.Visible = true;
                    lblTurnP2.Visible = false; 
                    GameSys.WhoseTurnPlayer = 1;

                }
            }
        }

        private void btnDoublePrice_Click(object sender, EventArgs e)
        {
            myFormDoublePrice.ShowDialog();
            btnDoublePrice.Visible = false;
            counter--;
            turn++;
            if (lblPlayer2.Visible == true && lblPlayer3.Visible == true)
            {
                if (turn == 2 || turn == 5)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = true;
                    lblTurnP3.Visible = false; 
                    GameSys.WhoseTurnPlayer = 2;

                }
                else if (turn == 3 || turn == 6)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = false;
                    lblTurnP3.Visible = true;
                    GameSys.WhoseTurnPlayer = 3;
                }
                else if (turn == 1 || turn == 4)
                {
                    lblTurnP1.Visible = true;
                    lblTurnP2.Visible = false;
                    lblTurnP3.Visible = false;
                    GameSys.WhoseTurnPlayer = 1;
                }
                
            }
            if (lblPlayer2.Visible == true && lblPlayer3.Visible == false)
            {
                if (turn == 2 || turn == 4 || turn == 6)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = true;
                    GameSys.WhoseTurnPlayer = 2;
                }
                else if (turn == 1 || turn == 3 || turn == 5)
                {
                    lblTurnP1.Visible = true;
                    lblTurnP2.Visible = false;
                    GameSys.WhoseTurnPlayer = 1;
                }
            }
        }

        private void btnGoldenRoad_Click(object sender, EventArgs e)
        {
            myFormGoldenRoad.ShowDialog();
            btnGoldenRoad.Visible = false;
            counter--;
            turn++;
            if (lblPlayer2.Visible == true && lblPlayer3.Visible == true)
            {
                if (turn == 2 || turn == 5)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = true;
                    lblTurnP3.Visible = false;
                    GameSys.WhoseTurnPlayer = 2;
                }
                else if (turn == 3 || turn == 6)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = false;
                    lblTurnP3.Visible = true;
                    GameSys.WhoseTurnPlayer = 3;
                }
                else if (turn == 1 || turn == 4)
                {
                    lblTurnP1.Visible = true;
                    lblTurnP2.Visible = false;
                    lblTurnP3.Visible = false;
                    GameSys.WhoseTurnPlayer = 1;
                }
            }
            if (lblPlayer2.Visible == true && lblPlayer3.Visible == false)
            {
                if (turn == 2 || turn == 4 || turn == 6)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = true;
                    GameSys.WhoseTurnPlayer = 2;
                }
                else if (turn == 1 || turn == 3 || turn == 5)
                {
                    lblTurnP1.Visible = true;
                    lblTurnP2.Visible = false;
                    GameSys.WhoseTurnPlayer = 1;
                }
            }
        }

        private void btnOneWrongPrice_Click(object sender, EventArgs e)
        {
            myFormOneWrongPrice.ShowDialog();
            btnOneWrongPrice.Visible = false;
            counter--;
            turn++;
            if (lblPlayer2.Visible == true && lblPlayer3.Visible == true)
            {
                if (turn == 2 || turn == 5)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = true;
                    lblTurnP3.Visible = false;
                    GameSys.WhoseTurnPlayer = 2;
                }
                else if (turn == 3 || turn == 6)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = false;
                    lblTurnP3.Visible = true;
                    GameSys.WhoseTurnPlayer = 3;
                }
                else if (turn == 1 || turn == 4)
                {
                    lblTurnP1.Visible = true;
                    lblTurnP2.Visible = false;
                    lblTurnP3.Visible = false;
                    GameSys.WhoseTurnPlayer = 1;
                }
            }
            if (lblPlayer2.Visible == true && lblPlayer3.Visible == false)
            {
                if (turn == 2 || turn == 4 || turn == 6)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = true;
                    GameSys.WhoseTurnPlayer = 2;
                }
                else if (turn == 1 || turn == 3 || turn == 5)
                {
                    lblTurnP1.Visible = true;
                    lblTurnP2.Visible = false;
                    GameSys.WhoseTurnPlayer = 1;
                }
            }
        }

        private void btnMostExpensive_Click(object sender, EventArgs e)
        {
            myFormMostExpensive.ShowDialog();
            btnMostExpensive.Visible = false;
            counter--;
            turn++;
            if (lblPlayer2.Visible == true && lblPlayer3.Visible == true)
            {
                if (turn == 2 || turn == 5)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = true;
                    lblTurnP3.Visible = false;
                    GameSys.WhoseTurnPlayer = 2;
                }
                else if (turn == 3 || turn == 6)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = false;
                    lblTurnP3.Visible = true;
                    GameSys.WhoseTurnPlayer = 3;
                }
                else if (turn == 1 || turn == 4)
                {
                    lblTurnP1.Visible = true;
                    lblTurnP2.Visible = false;
                    lblTurnP3.Visible = false;
                    GameSys.WhoseTurnPlayer = 1;
                }
            }
            if (lblPlayer2.Visible == true && lblPlayer3.Visible == false)
            {
                if (turn == 2 || turn == 4 || turn == 6)
                {
                    lblTurnP1.Visible = false;
                    lblTurnP2.Visible = true;
                    GameSys.WhoseTurnPlayer = 2;
                }
                else if (turn == 1 || turn == 3 || turn == 5)
                {
                    lblTurnP1.Visible = true;
                    lblTurnP2.Visible = false;
                    GameSys.WhoseTurnPlayer = 1;
                }
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            FrmPlayerScore thisScore = new FrmPlayerScore(); 
            int p1Score = Convert.ToInt32(thisScore.lblScore1.Text);
            int p2Score = Convert.ToInt32(thisScore.lblScore2.Text);
            int p3Score = Convert.ToInt32(thisScore.lblScore3.Text);
            if (lblPlayer2.Visible == false && lblPlayer3.Visible == false)
            {
                myFormFinalShowDown.pbPlayer2.Visible = false;
                myFormFinalShowDown.txtPlayer2Answer.Visible = false;
                myFormFinalShowDown.pbPlayer3.Visible = false;
                myFormFinalShowDown.txtPlayer3Answer.Visible = false;
                if (counter == 0)
                {
                    myFormFinalShowDown.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please finish all of the games");
                }
            
            }
            else if (lblPlayer3.Visible == false)
            {
                myFormFinalShowDown.pbPlayer3.Visible = false;
                myFormFinalShowDown.txtPlayer3Answer.Visible = false;
                if (counter == 0)
                {
                    if (p1Score > p2Score)
                    {
                        myFormFinalShowDown.pbPlayer2.Visible = false;
                        myFormFinalShowDown.txtPlayer2Answer.Visible = false;
                        myFormFinalShowDown.ShowDialog();
                        this.Hide();
                    }
                    else if (p1Score < p2Score)
                    {
                        myFormFinalShowDown.pbPlayer1.Visible = false;
                        myFormFinalShowDown.txtPlayer1Answer.Visible = false;
                        myFormFinalShowDown.ShowDialog();
                        this.Hide();
                    }
                    else if (p1Score == p2Score)
                    {
                        myFormFinalShowDown.ShowDialog();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Please finish all of the games");
                }
            }
            else if (lblPlayer3.Visible == true)
            {
                if (counter == 0)
                {
                    if (p1Score > p2Score && p1Score > p3Score)
                    {
                        myFormFinalShowDown.pbPlayer2.Visible = false;
                        myFormFinalShowDown.txtPlayer2Answer.Visible = false;
                        myFormFinalShowDown.pbPlayer3.Visible = false;
                        myFormFinalShowDown.txtPlayer3Answer.Visible = false;
                        myFormFinalShowDown.ShowDialog();
                        this.Hide();
                    }
                    else if (p1Score > p2Score && p1Score == p3Score)
                    {
                        myFormFinalShowDown.pbPlayer2.Visible = false;
                        myFormFinalShowDown.txtPlayer2Answer.Visible = false;
                        myFormFinalShowDown.ShowDialog();
                        this.Hide();
                    }
                    else if (p1Score == p2Score && p1Score > p3Score)
                    {
                        myFormFinalShowDown.pbPlayer3.Visible = false;
                        myFormFinalShowDown.txtPlayer3Answer.Visible = false;
                        myFormFinalShowDown.ShowDialog();
                        this.Hide();
                    }
                    else if (p2Score == p3Score && p2Score > p1Score)
                    {
                        myFormFinalShowDown.pbPlayer1.Visible = false;
                        myFormFinalShowDown.txtPlayer1Answer.Visible = false;
                        myFormFinalShowDown.ShowDialog();
                        this.Hide();
                    }
                    else if (p2Score > p1Score && p2Score > p3Score)
                    {
                        myFormFinalShowDown.pbPlayer1.Visible = false;
                        myFormFinalShowDown.txtPlayer1Answer.Visible = false;
                        myFormFinalShowDown.pbPlayer3.Visible = false;
                        myFormFinalShowDown.txtPlayer3Answer.Visible = false;
                        myFormFinalShowDown.ShowDialog();
                        this.Hide();
                    }
                    else if (p3Score > p2Score && p3Score > p1Score)
                    {
                        myFormFinalShowDown.pbPlayer1.Visible = false;
                        myFormFinalShowDown.txtPlayer1Answer.Visible = false;
                        myFormFinalShowDown.pbPlayer2.Visible = false;
                        myFormFinalShowDown.txtPlayer2Answer.Visible = false;
                        myFormFinalShowDown.ShowDialog();
                        this.Hide();
                    }
                    else if (p1Score == p2Score && p1Score == p3Score)
                    {
                        myFormFinalShowDown.ShowDialog();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Please finish all of the games");
                }
            }
        }
        private void btnShowScore_Click(object sender, EventArgs e)
        {
            myFormPlayerScore.ShowDialog(); 
        }
    }
}
