using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _3309_Group_Project
{
    public class ItemList
    {
        private List<Item> item;

        public ItemList()
        {
            item = new List<Item>();
        }

        public int CountNo
        {
            get { return item.Count; }
        }

        public void AddItem(Item a)
        {
            item.Add(a);
        }
        public void RemoveItem(Item a)
        {
            item.Remove(a);
        }

        public void ReadItem()
        {
            string strConnect = "provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=DatabaseProject.accdb";
            string SQL = "SELECT ID, Item_Name, Item_Price FROM item";
            OleDbConnection myConnection = new OleDbConnection(strConnect);
            OleDbCommand myCommand = new OleDbCommand(SQL, myConnection);
            //DataSet myDataset = new DataSet("Item");
            OleDbDataReader myDataReader;
            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                Item theItem = new Item();

                while (myDataReader.Read())
                {
                    theItem.NameOfItem = myDataReader["Item_Name"].ToString();
                    theItem.PriceOfItem = Convert.ToInt64(myDataReader["Item_Price"].ToString());
                    theItem.IDOfItem = Convert.ToInt32(myDataReader["ID"].ToString());
                    item.Add(theItem);
                }
            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
        }
    }
}
