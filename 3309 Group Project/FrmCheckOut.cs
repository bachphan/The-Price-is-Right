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
    public partial class FrmCheckOut : Form
    {
        
        Random ranNum = new Random();
        DataSet myDataset = new DataSet("Item");
        //double item1Price, item2Price, item3Price;
        ArrayPictureItems arrayPicture = new ArrayPictureItems();
        CheckOut checkOut;
        FrmPlayerScore score = new FrmPlayerScore(); 

        public FrmCheckOut()
        {
            InitializeComponent();
            string strConnect = "provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=DatabaseProject.accdb";
            string SQL = "SELECT ID, Item_Name, Item_Price FROM item";
            OleDbConnection myConnection = new OleDbConnection(strConnect);
            OleDbCommand myCommand = new OleDbCommand(SQL, myConnection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(SQL, myConnection);

            myDataAdapter.Fill(myDataset, "Item");

            double item1Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[0][2]);
            double item2Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[1][2]);
            double item3Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[2][2]);
            double item4Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[3][2]);
            double item5Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[4][2]);


            String item1Name = myDataset.Tables["Item"].Rows[0][1].ToString();
            String item2Name = myDataset.Tables["Item"].Rows[1][1].ToString();
            String item3Name = myDataset.Tables["Item"].Rows[2][1].ToString();
            String item4Name = myDataset.Tables["Item"].Rows[3][1].ToString();
            String item5Name = myDataset.Tables["Item"].Rows[4][1].ToString();
            checkOut = new CheckOut(item1Name, item2Name, item3Name, item4Name, item5Name, item1Price,
                item2Price, item3Price, item4Price, item5Price);
            


            //item1Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[23][2].ToString());
            //item2Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[24][2].ToString());
            // item3Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[25][2].ToString());

            lblItem1.Text = checkOut.GetItemName1();
            lblItem2.Text = checkOut.GetItemName2();
            lblItem3.Text = checkOut.GetItemName3();
            lblItem4.Text = checkOut.GetItemName4();
            lblItem5.Text = checkOut.GetItemName5();

            lblActualPrice1.Text = item1Price.ToString();
            lblActualPrice2.Text = item2Price.ToString();
            lblActualPrice3.Text = item3Price.ToString();
            lblActualPrice4.Text = item4Price.ToString();
            lblActualPrice5.Text = item5Price.ToString();
            lblActualPrice1.Visible = false;
            lblActualPrice2.Visible = false;
            lblActualPrice3.Visible = false;
            lblActualPrice4.Visible = false;
            lblActualPrice5.Visible = false; 

            lblTotalPrice.Text = checkOut.GetTotalPrice().ToString();
            lblTotalPrice.Visible = false;
            lblTotalGuess.Visible = false; 

            pictureBox1.Image = ArrayPictureItems.GetItemPicture(0);
            pictureBox2.Image = ArrayPictureItems.GetItemPicture(1);
            pictureBox3.Image = ArrayPictureItems.GetItemPicture(2);
            pictureBox4.Image = ArrayPictureItems.GetItemPicture(3);
            pictureBox5.Image = ArrayPictureItems.GetItemPicture(4);
        } 

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtGuess1.Text) &&
                !string.IsNullOrWhiteSpace(txtGuess2.Text) &&
                !string.IsNullOrWhiteSpace(txtGuess3.Text) &&
                !string.IsNullOrWhiteSpace(txtGuess4.Text) &&
                !string.IsNullOrWhiteSpace(txtGuess5.Text)) 
            {
                double storeGuess1 = Convert.ToDouble(txtGuess1.Text);
                double storeGuess2 = Convert.ToDouble(txtGuess2.Text);
                double storeGuess3 = Convert.ToDouble(txtGuess3.Text);
                double storeGuess4 = Convert.ToDouble(txtGuess4.Text);
                double storeGuess5 = Convert.ToDouble(txtGuess5.Text);
                checkOut.GuessSet(storeGuess1, storeGuess2, storeGuess3, storeGuess4,storeGuess5); 

                lblActualPrice1.Visible = true;
                lblActualPrice2.Visible = true;
                lblActualPrice3.Visible = true;
                lblActualPrice4.Visible = true;
                lblActualPrice5.Visible = true;

                lblTotalGuess.Text = checkOut.GetTotalGuessItemPrice().ToString(); 
                lblTotalGuess.Visible = true;
                lblTotalPrice.Visible = true;

                if (checkOut.WinOrNah())
                {
                    MessageBox.Show("You won!");
                    FrmChooseGame ChooseGameForm = new FrmChooseGame();
                    FrmPlayerScore thisScore = new FrmPlayerScore();
                    if (GameSys.WhoseTurnPlayer == 1)
                        GameSys.Player1Score++;
                    else if (GameSys.WhoseTurnPlayer == 2)
                        GameSys.Player2Score++;
                    else
                        GameSys.Player3Score++;
                    
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("You Lose!");
                    this.Close(); 
                }
            }
            else
            {
                MessageBox.Show("You left one blank!"); 
            }
        }
    }
}