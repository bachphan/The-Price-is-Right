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
    public partial class FrmOneWrongPrice : Form
    {
        Random ranNum = new Random();
        DataSet myDataset = new DataSet("Item");
        OneWrongPrice owp = new OneWrongPrice();
        public FrmOneWrongPrice()
        {
            InitializeComponent();
            string strConnect = "provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=DatabaseProject.accdb";
            string SQL = "SELECT ID, Item_Name, Item_Price FROM item";
            OleDbConnection myConnection = new OleDbConnection(strConnect);
            OleDbCommand myCommand = new OleDbCommand(SQL, myConnection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(SQL, myConnection);

            myDataAdapter.Fill(myDataset, "Item");
            string item1Name = myDataset.Tables["Item"].Rows[27][1].ToString();
            string item2Name = myDataset.Tables["Item"].Rows[28][1].ToString();
            string item3Name = myDataset.Tables["Item"].Rows[29][1].ToString();

            lblItem1.Text = item1Name;
            lblItem2.Text = item2Name;
            lblItem3.Text = item3Name;

            int CorrectAnswer = ranNum.Next(1, 4);
            owp.priceWrong = CorrectAnswer;

            double item1Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[27][2].ToString());
            double item2Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[28][2].ToString());
            double item3Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[29][2].ToString());

            picItem1.Image = ArrayPictureItems.GetItemPicture(21);
            picItem2.Image = ArrayPictureItems.GetItemPicture(23);
            picItem3.Image = ArrayPictureItems.GetItemPicture(24);

            //rd1.Text = item1Price;
            //rd2.Text = item2Price;
            //rd3.Text = item3Price;

            owp = new OneWrongPrice(item1Price, item2Price, item3Price);
            rd1.Text = owp.price1.ToString();
            rd2.Text = owp.price2.ToString();
            rd3.Text = owp.price3.ToString();
  
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (owp.priceWrong == 1)
            {
                if (rd1.Checked)
                {
                    string win = owp.DisplayWinAnnoucement();
                    MessageBox.Show(win);
                    if (GameSys.WhoseTurnPlayer == 1)
                        GameSys.Player1Score++;
                    else if (GameSys.WhoseTurnPlayer == 2)
                        GameSys.Player2Score++;
                    else
                        GameSys.Player3Score++;
                    this.Close();
                }
                else if (rd2.Checked || rd3.Checked)
                {
                    string lose = owp.DisplayLoseAnnoucement();
                    MessageBox.Show(lose);
                }
                this.Close();
            }
            else if (owp.priceWrong == 2)
            {
                if (rd2.Checked)
                {
                    string win = owp.DisplayWinAnnoucement();
                    MessageBox.Show(win);
                    if (GameSys.WhoseTurnPlayer == 1)
                        GameSys.Player1Score++;
                    else if (GameSys.WhoseTurnPlayer == 2)
                        GameSys.Player2Score++;
                    else
                        GameSys.Player3Score++;
                    this.Close();
                }
                else if (rd1.Checked || rd3.Checked)
                {
                    string lose = owp.DisplayLoseAnnoucement();
                    MessageBox.Show(lose);
                }
                this.Close();
            }
            else if (owp.priceWrong == 3)
            {
                if (rd3.Checked)
                {
                    string win = owp.DisplayWinAnnoucement();
                    MessageBox.Show(win);
                    if (GameSys.WhoseTurnPlayer == 1)
                        GameSys.Player1Score++;
                    else if (GameSys.WhoseTurnPlayer == 2)
                        GameSys.Player2Score++;
                    else
                        GameSys.Player3Score++;
                    
                }
                else if (rd2.Checked || rd1.Checked)
                {
                    string lose = owp.DisplayLoseAnnoucement();
                    MessageBox.Show(lose);
                }
                this.Close();
            }
        }
    }
}