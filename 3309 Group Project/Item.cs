using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309_Group_Project
{
    public class Item
    {
        private int itemId;
        private string itemName;
        private double itemPrice;

        public Item()
        {
            itemId = 0;
            itemName = "";
            itemPrice = 0;
        }
        public int IDOfItem
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public string NameOfItem
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public double PriceOfItem
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }
    }
}

