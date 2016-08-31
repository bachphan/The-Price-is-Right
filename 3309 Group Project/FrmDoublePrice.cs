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
    public partial class FrmDoublePrice : Form
    {
        Random ranNum = new Random();
        DataSet myDataset = new DataSet("Item");
        double item1Price, item2Price, item3Price;
        ArrayPictureItems arrayPicture = new ArrayPictureItems();
        DoublePrice dp; 

        public FrmDoublePrice()
        {
            InitializeComponent();
            string strConnect = "provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=DatabaseProject.accdb";
            string SQL = "SELECT ID, Item_Name, Item_Price FROM item";
            OleDbConnection myConnection = new OleDbConnection(strConnect);
            OleDbCommand myCommand = new OleDbCommand(SQL, myConnection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(SQL, myConnection);

            myDataAdapter.Fill(myDataset, "Item");
            string item1Name = myDataset.Tables["Item"].Rows[12][1].ToString();
            //string item1Price = myDataset.Tables["Item"].Rows[8][2].ToString();
            double item1Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[13][2]); 
            dp = new DoublePrice(item1Price, item1Name);
           

            item1Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[23][2].ToString());
            item2Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[24][2].ToString());
            item3Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[25][2].ToString());

            lblPrice1.Text = dp.GetRealPrice().ToString();
            lblPrice2.Text = dp.GetFakePrice().ToString();
            lblItemName.Text = dp.GetName();
            lblCorrectPrice.Text = dp.GetRealPrice().ToString(); 

            pictureBox3.Image = ArrayPictureItems.GetItemPicture(7);
         
    }

        private void btnChoose1_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(lblPrice1.Text) == dp.GetRealPrice()){
                MessageBox.Show("You won!");
                if (GameSys.WhoseTurnPlayer == 1)
                    GameSys.Player1Score++;
                else if (GameSys.WhoseTurnPlayer == 2)
                    GameSys.Player2Score++;
                else
                    GameSys.Player3Score++;
                //=========================
                FrmPlayerScore s = new FrmPlayerScore(); 
                FrmChooseGame choose = new FrmChooseGame();
                
                this.Close();
                s.ShowDialog(); 
            }
            else{
                MessageBox.Show("You lose!"); 
                this.Close(); 
            }
        }

        private void btnChoose2_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(lblPrice2.Text) == dp.GetRealPrice())
            {
                FrmPlayerScore s = new FrmPlayerScore();
                FrmChooseGame choose = new FrmChooseGame();
                if (choose.lblTurnP1.Visible)
                {

                    int score = Convert.ToInt32(s.lblScore1.Text);
                    score++;
                    s.lblScore1.Text = score.ToString();
                }
                else if (choose.lblTurnP2.Visible)
                {

                    int score = Convert.ToInt32(s.lblScore2.Text);
                    score++;
                    s.lblScore2.Text = score.ToString();
                }
                else
                {
                    int score = Convert.ToInt32(s.lblScore3.Text);
                    score++;
                    s.lblScore3.Text = score.ToString();
                }
                MessageBox.Show("You won!");
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
                MessageBox.Show("You lose!");
                this.Close();
            }
        }
}
}