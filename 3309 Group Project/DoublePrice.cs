using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309_Group_Project
{
    public class DoublePrice
    {
        private bool win;
        private double realPrice; //need database
        private double fakePrice;
        //double fakeprice = realprice * 1.13;
        private Random rand = new Random();
        //int rands = rand.Next(1,3);  
        private int realPricePosition;
        private int fakePricePosition;
        private String name; 

        public DoublePrice(double itemPrice, String Name)
        {

            realPrice = itemPrice;
            fakePrice = realPrice + 50 ;
            name = Name; 
        }
        //1 or 2
        public bool Guess(double guessPrice)
        {
            if (guessPrice == realPrice)
            {
                win = true;
                return win;
            }
            else
            {
                win = false;
                return win;
            }
        }
        public String GetName()
        {
            return name; 
        }
        public double GetRealPrice()
        {
            return realPrice;
        }
        public double GetFakePrice()
        {
            return fakePrice;
        }

        
        public void GeneratePricePosition(){
            int rands = rand.Next(1,3);
            realPricePosition = rands;
            if(realPricePosition == 1){
                fakePricePosition = 2;
                realPricePosition = 1;
            }
            else{
                fakePricePosition = 1;
                realPricePosition =2;
            }
        }
        
        public string DisplayWinAnnoucement()
        {
            String output = "Congratulation, you have won the Double Price game";
            return output;
        }
        public string DisplayLoseAnnoucement()
        {
            return "Sorry, you have lose the game";
        }

    }
}
