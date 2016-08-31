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
    public partial class FrmFinalShowDown : Form
    {
        DataSet myDataset = new DataSet("Item");
        FinalShowDown fsd = new FinalShowDown();
        double sum;
        public FrmFinalShowDown()
        {
            InitializeComponent();
            string strConnect = "provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=DatabaseProject.accdb";
            string SQL = "SELECT ID, Item_Name, Item_Price FROM item";
            OleDbConnection myConnection = new OleDbConnection(strConnect);
            OleDbCommand myCommand = new OleDbCommand(SQL, myConnection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(SQL, myConnection);
            myDataAdapter.Fill(myDataset, "Item");
            double Item1Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[30][2].ToString());
            double Item2Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[31][2].ToString());
            double Item3Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[32][2].ToString());
            fsd.firstItemPrice = Item1Price;
            fsd.secondItemPrice = Item2Price;
            fsd.thirdItemPrice = Item3Price;
            fsd.sum = Item1Price + Item2Price + Item3Price;
            sum = fsd.sum;
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            bool result1, result2, result3;
            if (pbPlayer2.Visible == false && pbPlayer3.Visible == false && !string.IsNullOrWhiteSpace(txtPlayer1Answer.Text))
            {
                txtPlayer1Answer.Text = string.Format("{0:#,##0.00}", double.Parse(txtPlayer1Answer.Text));
                result1 = fsd.CheckAnswer(Convert.ToDouble(txtPlayer1Answer.Text), sum);
                if (result1 == true)
                {
                    string win = fsd.DisplayWinAnnouce();
                    MessageBox.Show("Player 1 - " + win + " " + "The total price is: " + sum);
                    Application.Exit();
                } if (result1 == false)
                {
                    string lose = fsd.DisplayLoseAnnouce();
                    MessageBox.Show("Player 1 - " + lose + " " + "The total price is: " + sum);
                    Application.Exit();
                }
            }
            else if (pbPlayer3.Visible == false && pbPlayer1.Visible == false && !string.IsNullOrWhiteSpace(txtPlayer2Answer.Text))
            {
                txtPlayer2Answer.Text = string.Format("{0:#,##0.00}", double.Parse(txtPlayer2Answer.Text));
                result2 = fsd.CheckAnswer(Convert.ToDouble(txtPlayer2Answer.Text), sum);
                if (result2 == true)
                {
                    string win = fsd.DisplayWinAnnouce();
                    MessageBox.Show("Player 2 - " + win + " " + "The total price is: " + sum);
                    Application.Exit();
                } if (result2 == false)
                {
                    string lose = fsd.DisplayLoseAnnouce();
                    MessageBox.Show("Player 2 - " + lose + " " + "The total price is: " + sum);
                    Application.Exit();
                }
            }
            else if (pbPlayer2.Visible == false && pbPlayer1.Visible == false && !string.IsNullOrWhiteSpace(txtPlayer3Answer.Text))
            {
                txtPlayer3Answer.Text = string.Format("{0:#,##0.00}", double.Parse(txtPlayer3Answer.Text));
                result3 = fsd.CheckAnswer(Convert.ToDouble(txtPlayer3Answer.Text), sum);
                if (result3 == true)
                {
                    string win = fsd.DisplayWinAnnouce();
                    MessageBox.Show("Player 3 - " + win + " " + "The total price is: " + sum);
                    Application.Exit();
                } if (result3 == false)
                {
                    string lose = fsd.DisplayLoseAnnouce();
                    MessageBox.Show("Player 3 - " + lose + " " + "The total price is: " + sum);
                    Application.Exit();
                }
            }
            else if (pbPlayer3.Visible == false && !string.IsNullOrWhiteSpace(txtPlayer2Answer.Text) && !string.IsNullOrWhiteSpace(txtPlayer1Answer.Text))
            {
                txtPlayer1Answer.Text = string.Format("{0:#,##0.00}", double.Parse(txtPlayer1Answer.Text));
                txtPlayer2Answer.Text = string.Format("{0:#,##0.00}", double.Parse(txtPlayer2Answer.Text));
                result1 = fsd.CheckAnswer(Convert.ToDouble(txtPlayer1Answer.Text), sum);
                if (result1 == true)
                {
                    string win = fsd.DisplayWinAnnouce();
                    MessageBox.Show("Player 1 - " + win + " " + "The total price is: " + sum);

                } if (result1 == false)
                {
                    string lose = fsd.DisplayLoseAnnouce();
                    MessageBox.Show("Player 1 - " + lose + " " + "The total price is: " + sum);

                } result2 = fsd.CheckAnswer(Convert.ToDouble(txtPlayer2Answer.Text), sum);
                if (result2 == true)
                {
                    string win = fsd.DisplayWinAnnouce();
                    MessageBox.Show("Player 2 - " + win + " " + "The total price is: " + sum);

                } if (result2 == false)
                {
                    string lose = fsd.DisplayLoseAnnouce();
                    MessageBox.Show("Player 2 - " + lose + " " + "The total price is: " + sum);

                } Application.Exit();
            }
            else if (pbPlayer2.Visible == false && !string.IsNullOrWhiteSpace(txtPlayer3Answer.Text) && !string.IsNullOrWhiteSpace(txtPlayer1Answer.Text))
            {
                txtPlayer1Answer.Text = string.Format("{0:#,##0.00}", double.Parse(txtPlayer1Answer.Text));
                txtPlayer3Answer.Text = string.Format("{0:#,##0.00}", double.Parse(txtPlayer3Answer.Text));
                result1 = fsd.CheckAnswer(Convert.ToDouble(txtPlayer1Answer.Text), sum);
                if (result1 == true)
                {
                    string win = fsd.DisplayWinAnnouce();
                    MessageBox.Show("Player 1 - " + win + " " + "The total price is: " + sum);

                } if (result1 == false)
                {
                    string lose = fsd.DisplayLoseAnnouce();
                    MessageBox.Show("Player 1 - " + lose + " " + "The total price is: " + sum);

                } result3 = fsd.CheckAnswer(Convert.ToDouble(txtPlayer3Answer.Text), sum);
                if (result3 == true)
                {
                    string win = fsd.DisplayWinAnnouce();
                    MessageBox.Show("Player 3 - " + win + " " + "The total price is: " + sum);

                } if (result3 == false)
                {
                    string lose = fsd.DisplayLoseAnnouce();
                    MessageBox.Show("Player 3 - " + lose + " " + "The total price is: " + sum);

                } Application.Exit();
            }
            else if (!string.IsNullOrWhiteSpace(txtPlayer2Answer.Text) && !string.IsNullOrWhiteSpace(txtPlayer3Answer.Text) && !string.IsNullOrWhiteSpace(txtPlayer1Answer.Text))
            {
                txtPlayer1Answer.Text = string.Format("{0:#,##0.00}", double.Parse(txtPlayer1Answer.Text));
                txtPlayer2Answer.Text = string.Format("{0:#,##0.00}", double.Parse(txtPlayer2Answer.Text));
                txtPlayer3Answer.Text = string.Format("{0:#,##0.00}", double.Parse(txtPlayer3Answer.Text));
                result1 = fsd.CheckAnswer(Convert.ToDouble(txtPlayer1Answer.Text), sum);
                if (result1 == true)
                {
                    string win = fsd.DisplayWinAnnouce();
                    MessageBox.Show("Player 1 - " + win + " " + "The total price is: " + sum);
                } if (result1 == false)
                {
                    string lose = fsd.DisplayLoseAnnouce();
                    MessageBox.Show("Player 1 - " + lose + " " + "The total price is: " + sum);
                } result2 = fsd.CheckAnswer(Convert.ToDouble(txtPlayer2Answer.Text), sum);
                if (result2 == true)
                {
                    string win = fsd.DisplayWinAnnouce();
                    MessageBox.Show("Player 2 - " + win + " " + "The total price is: " + sum);
                } if (result2 == false)
                {
                    string lose = fsd.DisplayLoseAnnouce();
                    MessageBox.Show("Player 2 - " + lose + " " + "The total price is: " + sum);
                } result3 = fsd.CheckAnswer(Convert.ToDouble(txtPlayer3Answer.Text), sum);
                if (result3 == true)
                {
                    string win = fsd.DisplayWinAnnouce();
                    MessageBox.Show("Player 3 - " + win + " " + "The total price is: " + sum);
                } if (result3 == false)
                {
                    string lose = fsd.DisplayLoseAnnouce();
                    MessageBox.Show("Player 3 - " + lose + " " + "The total price is: " + sum);
                } Application.Exit();
            }
            else
            {
                MessageBox.Show("Please enter the price into the text box", "Error");
            }
        }

        private void txtPlayer1Answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 57 && e.KeyChar >= 48) || e.KeyChar == 13 || e.KeyChar == 8 || e.KeyChar == 46)
            {
                //ASCII Code 48 - 57 represent from 0 - 9 | 8 represent Backspace | 13 represent Enter | 46 represent '.'
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}