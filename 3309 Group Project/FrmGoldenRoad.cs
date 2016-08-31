using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _3309_Group_Project
{
    public partial class FrmGoldenRoad : Form
    {

        ItemList allItems = new ItemList();
        GoldenRoad gd = new GoldenRoad();
        Random ranNum = new Random();
        DataSet myDataset = new DataSet("Item");
        ArrayPictureItems a = new ArrayPictureItems();

        public FrmGoldenRoad()
        {
            InitializeComponent();
            pbItem2.Visible = false;
            pbItem3.Visible = false;
            allItems.ReadItem();

            string strConnect = "provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=DatabaseProject.accdb";
            string SQL = "SELECT ID, Item_Name, Item_Price FROM item";
            OleDbConnection myConnection = new OleDbConnection(strConnect);
            OleDbCommand myCommand = new OleDbCommand(SQL, myConnection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(SQL, myConnection);

            myDataAdapter.Fill(myDataset, "Item");
            string item1 = myDataset.Tables["Item"].Rows[20][2].ToString();
            gd.actualprice = Convert.ToDouble(item1);

            gd.FirstItem(1, gd.actualprice);
            int CorrectAnswer = ranNum.Next(1, 3);
            if (CorrectAnswer == 1)
            {
                rd1.Text = gd.actualprice.ToString();
                rd2.Text = gd.fakeprice1.ToString();
            }
            else if (CorrectAnswer == 2)
            {
                rd2.Text = gd.actualprice.ToString();
                rd1.Text = gd.fakeprice1.ToString();
            }
            pbitem1.Image = ArrayPictureItems.GetItemPicture(15);
            pbItem2.Image = ArrayPictureItems.GetItemPicture(16);
            pbItem3.Image = ArrayPictureItems.GetItemPicture(17);

            lblNameItem.Text = myDataset.Tables["Item"].Rows[20][1].ToString();
        }
        private void btnContinue1_Click(object sender, EventArgs e)
        {
            if (rd1.Text == gd.actualprice.ToString())
            {
                if (rd1.Checked)
                {
                    string win = gd.DisplayWinAnnoucementFor12();
                    MessageBox.Show(win);
                    string item2 = myDataset.Tables["Item"].Rows[21][2].ToString();
                    rd3.Visible = true;
                    pbItem2.Visible = true;
                    lblNameItem.Text = myDataset.Tables["Item"].Rows[21][1].ToString();
                    btnContinue1.Visible = false;
                    btnContinue2.Visible = true;
                    gd.actualprice = Convert.ToDouble(item2);
                    gd.SecondItem(1, gd.actualprice);
                    int CorrectAnswer = ranNum.Next(1, 4);
                    if (CorrectAnswer == 1)
                    {
                        rd1.Text = gd.actualprice.ToString();
                        rd2.Text = gd.fakeprice1.ToString();
                        rd3.Text = gd.fakeprice2.ToString();
                    }
                    else if (CorrectAnswer == 2)
                    {
                        rd2.Text = gd.actualprice.ToString();
                        rd1.Text = gd.fakeprice1.ToString();
                        rd3.Text = gd.fakeprice2.ToString();
                    }
                    else if (CorrectAnswer == 3)
                    {
                        rd2.Text = gd.fakeprice2.ToString();
                        rd1.Text = gd.fakeprice1.ToString();
                        rd3.Text = gd.actualprice.ToString();
                    }
                }
                else if (rd2.Checked)
                {
                    string lose = gd.DisplayLoseAnnoucement();
                    MessageBox.Show(lose);
                    this.Close();
                }
            }
            else if (rd2.Text == gd.actualprice.ToString())
            {
                if (rd2.Checked)
                {
                    string win = gd.DisplayWinAnnoucementFor12();
                    MessageBox.Show(win);
                    string item2 = myDataset.Tables["Item"].Rows[21][2].ToString();
                    rd3.Visible = true;
                    pbItem2.Visible = true;
                    lblNameItem.Text = myDataset.Tables["Item"].Rows[21][1].ToString();
                    btnContinue1.Visible = false;
                    btnContinue2.Visible = true;
                    gd.actualprice = Convert.ToDouble(item2);
                    gd.SecondItem(1, gd.actualprice);
                    int CorrectAnswer = ranNum.Next(1, 4);
                    if (CorrectAnswer == 1)
                    {
                        rd1.Text = gd.actualprice.ToString();
                        rd2.Text = gd.fakeprice1.ToString();
                        rd3.Text = gd.fakeprice2.ToString();
                    }
                    else if (CorrectAnswer == 2)
                    {
                        rd2.Text = gd.actualprice.ToString();
                        rd1.Text = gd.fakeprice1.ToString();
                        rd3.Text = gd.fakeprice2.ToString();
                    }
                    else if (CorrectAnswer == 3)
                    {
                        rd2.Text = gd.fakeprice2.ToString();
                        rd1.Text = gd.fakeprice1.ToString();
                        rd3.Text = gd.actualprice.ToString();
                    }
                }
                else if (rd1.Checked)
                {
                    string lose = gd.DisplayLoseAnnoucement();
                    MessageBox.Show(lose);
                    this.Close();
                }
            }
        }

        private void btnContinue2_Click_1(object sender, EventArgs e)
        {
            if (rd1.Text == gd.actualprice.ToString())
            {
                if (rd1.Checked)
                {
                    string win = gd.DisplayWinAnnoucementFor12();
                    MessageBox.Show(win);
                    string item3 = myDataset.Tables["Item"].Rows[22][2].ToString();
                    lblNameItem.Text = myDataset.Tables["Item"].Rows[22][1].ToString();
                    rd4.Visible = true;
                    pbItem3.Visible = true;
                    pbItem2.Visible = false;
                    btnContinue2.Visible = false;
                    btnFinal.Visible = true;
                    gd.actualprice = Convert.ToDouble(item3);
                    gd.ThirdItem(1, gd.actualprice);
                    int CorrectAnswer = ranNum.Next(1, 5);
                    if (CorrectAnswer == 1)
                    {
                        rd1.Text = gd.actualprice.ToString();
                        rd2.Text = gd.fakeprice1.ToString();
                        rd3.Text = gd.fakeprice2.ToString();
                        rd4.Text = gd.fakeprice3.ToString();
                    }
                    else if (CorrectAnswer == 2)
                    {
                        rd2.Text = gd.actualprice.ToString();
                        rd1.Text = gd.fakeprice1.ToString();
                        rd3.Text = gd.fakeprice2.ToString();
                        rd4.Text = gd.fakeprice3.ToString();
                    }
                    else if (CorrectAnswer == 3)
                    {
                        rd2.Text = gd.fakeprice2.ToString();
                        rd1.Text = gd.fakeprice1.ToString();
                        rd3.Text = gd.actualprice.ToString();
                        rd4.Text = gd.fakeprice3.ToString();
                    }
                    else if (CorrectAnswer == 4)
                    {
                        rd2.Text = gd.fakeprice2.ToString();
                        rd1.Text = gd.fakeprice1.ToString();
                        rd4.Text = gd.actualprice.ToString();
                        rd3.Text = gd.fakeprice3.ToString();
                    }
                }
                else if (rd2.Checked || rd3.Checked)
                {
                    string lose = gd.DisplayLoseAnnoucement();
                    MessageBox.Show(lose);
                    this.Close();
                }
            }
            else if (rd2.Text == gd.actualprice.ToString())
            {
                if (rd2.Checked)
                {
                    string win = gd.DisplayWinAnnoucementFor12();
                    MessageBox.Show(win);
                    string item3 = myDataset.Tables["Item"].Rows[22][2].ToString();
                    lblNameItem.Text = myDataset.Tables["Item"].Rows[22][1].ToString();
                    rd4.Visible = true;
                    pbItem3.Visible = true;
                    pbItem2.Visible = false;
                    btnContinue2.Visible = false;
                    btnFinal.Visible = true;
                    gd.actualprice = Convert.ToDouble(item3);
                    gd.ThirdItem(1, gd.actualprice);
                    int CorrectAnswer = ranNum.Next(1, 5);
                    if (CorrectAnswer == 1)
                    {
                        rd1.Text = gd.actualprice.ToString();
                        rd2.Text = gd.fakeprice1.ToString();
                        rd3.Text = gd.fakeprice2.ToString();
                        rd4.Text = gd.fakeprice3.ToString();
                    }
                    else if (CorrectAnswer == 2)
                    {
                        rd2.Text = gd.actualprice.ToString();
                        rd1.Text = gd.fakeprice1.ToString();
                        rd3.Text = gd.fakeprice2.ToString();
                        rd4.Text = gd.fakeprice3.ToString();
                    }
                    else if (CorrectAnswer == 3)
                    {
                        rd2.Text = gd.fakeprice2.ToString();
                        rd1.Text = gd.fakeprice1.ToString();
                        rd3.Text = gd.actualprice.ToString();
                        rd4.Text = gd.fakeprice3.ToString();
                    }
                    else if (CorrectAnswer == 4)
                    {
                        rd2.Text = gd.fakeprice2.ToString();
                        rd1.Text = gd.fakeprice1.ToString();
                        rd4.Text = gd.actualprice.ToString();
                        rd3.Text = gd.fakeprice3.ToString();
                    }
                }
                else if (rd1.Checked || rd3.Checked)
                {
                    string lose = gd.DisplayLoseAnnoucement();
                    MessageBox.Show(lose);
                    this.Close();
                }
            }
            else if (rd3.Text == gd.actualprice.ToString())
            {
                if (rd3.Checked)
                {
                    string win = gd.DisplayWinAnnoucementFor12();
                    MessageBox.Show(win);
                    string item3 = myDataset.Tables["Item"].Rows[22][2].ToString();
                    lblNameItem.Text = myDataset.Tables["Item"].Rows[22][1].ToString();
                    rd4.Visible = true;
                    pbItem3.Visible = true;
                    pbItem2.Visible = false;
                    btnContinue2.Visible = false;
                    btnFinal.Visible = true;
                    gd.actualprice = Convert.ToDouble(item3);
                    gd.ThirdItem(1, gd.actualprice);
                    int CorrectAnswer = ranNum.Next(1, 5);
                    if (CorrectAnswer == 1)
                    {
                        rd1.Text = gd.actualprice.ToString();
                        rd2.Text = gd.fakeprice1.ToString();
                        rd3.Text = gd.fakeprice2.ToString();
                        rd4.Text = gd.fakeprice3.ToString();
                    }
                    else if (CorrectAnswer == 2)
                    {
                        rd2.Text = gd.actualprice.ToString();
                        rd1.Text = gd.fakeprice1.ToString();
                        rd3.Text = gd.fakeprice2.ToString();
                        rd4.Text = gd.fakeprice3.ToString();
                    }
                    else if (CorrectAnswer == 3)
                    {
                        rd2.Text = gd.fakeprice2.ToString();
                        rd1.Text = gd.fakeprice1.ToString();
                        rd3.Text = gd.actualprice.ToString();
                        rd4.Text = gd.fakeprice3.ToString();
                    }
                    else if (CorrectAnswer == 4)
                    {
                        rd2.Text = gd.fakeprice2.ToString();
                        rd1.Text = gd.fakeprice1.ToString();
                        rd4.Text = gd.actualprice.ToString();
                        rd3.Text = gd.fakeprice3.ToString();
                    }
                }
                else if (rd1.Checked || rd2.Checked)
                {
                    string lose = gd.DisplayLoseAnnoucement();
                    MessageBox.Show(lose);
                    this.Close();
                }
            }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            FrmChooseGame ChooseGameForm = new FrmChooseGame();
            FrmPlayerScore s = new FrmPlayerScore(); 
            if (rd1.Text == gd.actualprice.ToString())
            {
                if (rd1.Checked)
                {
                    string win = gd.DisplayWinAnnoucement();
                    MessageBox.Show(win);
                    if (ChooseGameForm.lblTurnP1.Visible == true)
                    {
                        s.lblScore1.Text = (Convert.ToInt32(s.lblScore1.Text) + 1).ToString();
                    }
                    else if (ChooseGameForm.lblTurnP2.Visible == true)
                    {
                        s.lblScore2.Text = (Convert.ToInt32(s.lblScore2.Text) + 1).ToString();
                    }
                    else if (ChooseGameForm.lblTurnP3.Visible == true)
                    {
                        s.lblScore3.Text = (Convert.ToInt32(s.lblScore3.Text) + 1).ToString();
                    }
                    this.Hide();
                }
                else if (rd2.Checked || rd3.Checked || rd4.Checked)
                {
                    string lose = gd.DisplayLoseAnnoucement();
                    MessageBox.Show(lose);
                    this.Close();
                }
            }
            else if (rd2.Text == gd.actualprice.ToString())
            {
                if (rd2.Checked)
                {
                    string win = gd.DisplayWinAnnoucement();
                    MessageBox.Show(win);
                    if (ChooseGameForm.lblTurnP1.Visible == true)
                    {
                        s.lblScore1.Text = (Convert.ToInt32(s.lblScore1.Text) + 1).ToString();
                    }
                    else if (ChooseGameForm.lblTurnP2.Visible == true)
                    {
                        s.lblScore2.Text = (Convert.ToInt32(s.lblScore2.Text) + 1).ToString();
                    }
                    else if (ChooseGameForm.lblTurnP3.Visible == true)
                    {
                        s.lblScore3.Text = (Convert.ToInt32(s.lblScore3.Text) + 1).ToString();
                    }
                    this.Hide();
                }
                else if (rd1.Checked || rd3.Checked || rd4.Checked)
                {
                    string lose = gd.DisplayLoseAnnoucement();
                    MessageBox.Show(lose);
                    this.Close();
                }
            }
            else if (rd3.Text == gd.actualprice.ToString())
            {
                if (rd3.Checked)
                {
                    string win = gd.DisplayWinAnnoucement();
                    MessageBox.Show(win);
                    if (ChooseGameForm.lblTurnP1.Visible == true)
                    {
                        s.lblScore1.Text = (Convert.ToInt32(s.lblScore1.Text) + 1).ToString();
                    }
                    else if (ChooseGameForm.lblTurnP2.Visible == true)
                    {
                        s.lblScore2.Text = (Convert.ToInt32(s.lblScore2.Text) + 1).ToString();
                    }
                    else if (ChooseGameForm.lblTurnP3.Visible == true)
                    {
                        s.lblScore3.Text = (Convert.ToInt32(s.lblScore3.Text) + 1).ToString();
                    }
                    this.Hide();
                }
                else if (rd2.Checked || rd1.Checked || rd4.Checked)
                {
                    string lose = gd.DisplayLoseAnnoucement();
                    MessageBox.Show(lose);
                    this.Close();
                }
            }
            else if (rd4.Text == gd.actualprice.ToString())
            {
                if (rd4.Checked)
                {
                    string win = gd.DisplayWinAnnoucement();
                    MessageBox.Show(win);
                    /*
                    if (ChooseGameForm.lblTurnP1.Visible == true)
                    {
                        s.lblScore1.Text = (Convert.ToInt32(s.lblScore1.Text) + 1).ToString();
                    }
                    else if (ChooseGameForm.lblTurnP2.Visible == true)
                    {
                        s.lblScore2.Text = (Convert.ToInt32(s.lblScore2.Text) + 1).ToString();
                    }
                    else if (ChooseGameForm.lblTurnP3.Visible == true)
                    {
                        s.lblScore3.Text = (Convert.ToInt32(s.lblScore3.Text) + 1).ToString();
                    }
                     * */
                    if (GameSys.WhoseTurnPlayer == 1)
                        GameSys.Player1Score++;
                    else if (GameSys.WhoseTurnPlayer == 2)
                        GameSys.Player2Score++;
                    else
                        GameSys.Player3Score++;
                 
                    this.Hide();
                }
                else if (rd2.Checked || rd3.Checked || rd1.Checked)
                {
                    string lose = gd.DisplayLoseAnnoucement();
                    MessageBox.Show(lose);
                    this.Close();
                }
            }
        }
    }
}
