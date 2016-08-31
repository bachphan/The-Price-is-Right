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
    public partial class FrmMostExpensive : Form
    {
        Random ranNum = new Random();
        DataSet myDataset = new DataSet("Item");
        MostExpensive MostEx = new MostExpensive();
        double item1Price, item2Price, item3Price;

        public FrmMostExpensive()
        {
            InitializeComponent();
            string strConnect = "provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=DatabaseProject.accdb";
            string SQL = "SELECT ID, Item_Name, Item_Price FROM item";
            OleDbConnection myConnection = new OleDbConnection(strConnect);
            OleDbCommand myCommand = new OleDbCommand(SQL, myConnection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(SQL, myConnection);

            myDataAdapter.Fill(myDataset, "Item");
            string item1Name = myDataset.Tables["Item"].Rows[23][1].ToString();
            string item2Name = myDataset.Tables["Item"].Rows[24][1].ToString();
            string item3Name = myDataset.Tables["Item"].Rows[25][1].ToString();

            item1Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[23][2].ToString());
            item2Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[24][2].ToString());
            item3Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[25][2].ToString());

            rd1.Text = item1Name;
            rd2.Text = item2Name;
            rd3.Text = item3Name;

            pb2.Image = ArrayPictureItems.GetItemPicture(18);
            pb3.Image = ArrayPictureItems.GetItemPicture(19);
            pb4.Image = ArrayPictureItems.GetItemPicture(20);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            
            if (rd1.Checked)
            {
                MostEx.playerchoice = 1;
                bool result = MostEx.TestMostExpensive(item1Price, item2Price, item3Price);
                if (result == true)
                {
                    string win = MostEx.DisplayWinAnnoucement();
                    MessageBox.Show(win);
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
                    string lose = MostEx.DisplayLoseAnnoucement();
                    MessageBox.Show(lose);
                }
                this.Close();
            }
            else if (rd2.Checked)
            {
                MostEx.playerchoice = 2;
                bool result = MostEx.TestMostExpensive(item1Price, item2Price, item3Price);
                if (result == true)
                {
                    string win = MostEx.DisplayWinAnnoucement();
                    MessageBox.Show(win);
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
                    string lose = MostEx.DisplayLoseAnnoucement();
                    MessageBox.Show(lose);
                }
                this.Close();
            }
            else if (rd3.Checked)
            {
                MostEx.playerchoice = 3;
                bool result = MostEx.TestMostExpensive(item1Price, item2Price, item3Price);
                if (result == true)
                {
                    string win = MostEx.DisplayWinAnnoucement();
                    MessageBox.Show(win);
                    if (GameSys.WhoseTurnPlayer == 1)
                        GameSys.Player1Score++;
                    else if (GameSys.WhoseTurnPlayer == 2)
                        GameSys.Player2Score++;
                    else
                        GameSys.Player3Score++;
                    
                }
                else
                {
                    string lose = MostEx.DisplayLoseAnnoucement();
                    MessageBox.Show(lose);
                }
                this.Close();
            }
            
        }
    }
}
