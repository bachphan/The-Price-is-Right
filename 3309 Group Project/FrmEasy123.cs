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
    public partial class FrmEasy123 : Form
    {
        Random ranNum = new Random();
        DataSet myDataset = new DataSet("Item");
        //double item1Price, item2Price, item3Price;
        ArrayPictureItems arrayPicture = new ArrayPictureItems();
        Easy123 e123;
        public FrmEasy123()
        {
            InitializeComponent();
            string strConnect = "provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=DatabaseProject.accdb";
            string SQL = "SELECT ID, Item_Name, Item_Price FROM item";
            OleDbConnection myConnection = new OleDbConnection(strConnect);
            OleDbCommand myCommand = new OleDbCommand(SQL, myConnection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(SQL, myConnection);

            myDataAdapter.Fill(myDataset, "Item");

            double item1Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[14][2]);
            double item2Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[15][2]);
            double item3Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[16][2]);

            String item1Name = myDataset.Tables["Item"].Rows[14][1].ToString();
            String item2Name = myDataset.Tables["Item"].Rows[15][1].ToString();
            String item3Name = myDataset.Tables["Item"].Rows[16][1].ToString();

            e123 = new Easy123(item1Price, item2Price, item3Price);


            //item1Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[23][2].ToString());
            //item2Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[24][2].ToString());
            // item3Price = Convert.ToDouble(myDataset.Tables["Item"].Rows[25][2].ToString());

            lblItem1.Text = item1Name;
            lblItem2.Text = item2Name;
            lblItem3.Text = item3Name;
            //lblItemName.Text = dp.GetName(); 

            pictureBox2.Image = ArrayPictureItems.GetItemPicture(9);
            pictureBox3.Image = ArrayPictureItems.GetItemPicture(10);
            pictureBox4.Image = ArrayPictureItems.GetItemPicture(11);
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            int counter = 0;
            ////item1
            if (rad1Choice1.Checked)
            {
                if (e123.GetItem1Price() == 1)
                {
                    counter++;
                }
            }
            else if (rad1Choice2.Checked)
            {
                if (e123.GetItem1Price() == 2)
                {
                    counter++;
                }
            }
            else if (rad1Choice3.Checked)
            {
                if (e123.GetItem1Price() == 3)
                {
                    counter++;
                }
            }
            else
            {
                MessageBox.Show("Blank or Invalid Selection");
            }
            ////item2
            if (rad2Choice1.Checked)
            {
                if (e123.GetItem2Price() == 1)
                {
                    counter++;
                }
            }
            else if (rad2Choice2.Checked)
            {
                if (e123.GetItem2Price() == 2)
                {
                    counter++;
                }
            }
            else if (rad2Choice3.Checked)
            {
                if (e123.GetItem2Price() == 3)
                {
                    counter++;
                }
            }
            else
            {
                MessageBox.Show("Blank or Invalid Selection");
            }
            ////item3
            if (rad3Choice1.Checked)
            {
                if (e123.GetItem3Price() == 1)
                {
                    counter++;
                }
            }
            else if (rad3Choice2.Checked)
            {
                if (e123.GetItem3Price() == 2)
                {
                    counter++;
                }
            }
            else if (rad3Choice3.Checked)
            {
                if (e123.GetItem3Price() == 3)
                {
                    counter++;
                }
            }
            else
            {
                MessageBox.Show("Blank or Invalid Selection");
            }

            //win or not
            if (counter == 3)
            {
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
                MessageBox.Show("You lose");
                this.Close();
            }
        }
    }
}