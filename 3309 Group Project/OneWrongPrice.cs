using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Data.OleDb;
using System.IO;

namespace _3309_Group_Project
{
    public class OneWrongPrice
    {
        Random wrong = new Random();
        public double price1, price2, price3;
        public int priceWrong, playerChoice;
        public OneWrongPrice()
        {
            price1 = 0;
            price2 = 0;
            price3 = 0;
        }
        public OneWrongPrice(double first, double second, double third)
        {
            price1 = first;
            price2 = second;
            price3 = third;

            priceWrong = wrong.Next(1, 3);

            if (priceWrong == 1)
            {
                price1 = price1 + wrong.Next(100, 1000);
                //if (playerChoice == 1)
                //{
                //    DisplayWinAnnoucement();
                //}
                //else
                //    DisplayLoseAnnoucement();
            }
            else if (priceWrong == 2)
            {
                price2 = price2 + wrong.Next(100, 1000);
                //if (playerChoice == 2)
                //{
                //    DisplayWinAnnoucement();
                //}
                //else
                //    DisplayLoseAnnoucement();
            }
            else if (priceWrong == 3)
            {
                price3 = price3 + wrong.Next(100, 1000);
                //if (playerChoice == 3)
                //{
                //    DisplayWinAnnoucement();
                //}
                //else
                //    DisplayLoseAnnoucement();
            }
        }
        public string DisplayWinAnnoucement()
        {
            return "Congratulation, you win the One Wrong Price game";
        }

        public string DisplayLoseAnnoucement()
        {
            return "Sorry, you have lost the game";
        }
    }

}
