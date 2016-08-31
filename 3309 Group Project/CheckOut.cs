using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309_Group_Project
{
    public class CheckOut
    {
        private bool win = false;
        private String itemName1, itemName2, itemName3, itemName4, itemName5;
        private double itemPrice1, itemPrice2, itemPrice3, itemPrice4, itemPrice5;
        private double totalItemPrice;
        private double guessItemPrice1, guessItemPrice2, guessItemPrice3, guessItemPrice4, guessItemPrice5;
        private int counter = 0;
        private double totalGuessItemPrice = 0;

        public CheckOut(String ItemName1, String ItemName2, String ItemName3, String ItemName4, String ItemName5,
            double ItemPrice1, double ItemPrice2, double ItemPrice3, double ItemPrice4, double ItemPrice5)
        {
            itemName1 = ItemName1;
            itemName2 = ItemName2;
            itemName3 = ItemName3;
            itemName4 = ItemName4;
            itemName5 = ItemName5;

            itemPrice1 = ItemPrice1;
            itemPrice2 = ItemPrice2;
            itemPrice3 = ItemPrice3;
            itemPrice4 = ItemPrice4;
            itemPrice5 = ItemPrice5;
        }
        public void GuessSet(double Guess1, double Guess2, double Guess3, double Guess4, double Guess5)
        {
            guessItemPrice1 = Guess1;
            guessItemPrice2 = Guess2;
            guessItemPrice3 = Guess3;
            guessItemPrice4 = Guess4;
            guessItemPrice5 = Guess5;
            totalGuessItemPrice = guessItemPrice1 + guessItemPrice2 + guessItemPrice3 + guessItemPrice4 + guessItemPrice5; 
        }

        public void GuessPrice(double GuessItemPrice)
        {
            counter++;
            if (counter <= 5)
            {
                if (counter == 1)
                {
                    guessItemPrice1 = GuessItemPrice;

                }
                else if (counter == 2)
                {
                    guessItemPrice2 = GuessItemPrice;
                }
                else if (counter == 3)
                {
                    guessItemPrice3 = GuessItemPrice;
                }
                else if (counter == 4)
                {
                    guessItemPrice4 = GuessItemPrice;
                }
                else
                {
                    guessItemPrice5 = GuessItemPrice;
                }
                totalGuessItemPrice += GuessItemPrice;
            }
            else
            {
                Console.WriteLine("NO MORE GUESSES");
            }
        }
        public bool WinOrNah()
        {
            if ((totalGuessItemPrice >= totalItemPrice - 2) && (totalGuessItemPrice <= totalItemPrice + 2))
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
        public double GetTotalPrice()
        {
            return totalItemPrice = itemPrice1 + itemPrice2 + itemPrice3 + itemPrice4 + itemPrice5;
        }
        public double GetTotalGuessItemPrice()
        {
            return totalGuessItemPrice;
        }
        public String GetItemName1()
        {
            return itemName1;
        }
        public String GetItemName2()
        {
            return itemName2;
        }
        public String GetItemName3()
        {
            return itemName3;
        }
        public String GetItemName4()
        {
            return itemName4;
        }
        public String GetItemName5()
        {
            return itemName5;
        }

        public double GetItemPrice1()
        {
            return itemPrice1;
        }
        public double GetItemPrice2()
        {
            return itemPrice2;
        }
        public double GetItemPrice3()
        {
            return itemPrice3;
        }
        public double GetItemPrice4()
        {
            return itemPrice4;
        }
        public double GetItemPrice5()
        {
            return itemPrice5;
        }
        public double GetGuessItemPrice1()
        {
            return guessItemPrice1;
        }
        public double GetGuessItemPrice2()
        {
            return guessItemPrice2;
        }
        public double GetGuessItemPrice3()
        {
            return guessItemPrice3;
        }
        public double GetGuessItemPrice4()
        {
            return guessItemPrice4;
        }
        public double GetGuessItemPrice5()
        {
            return guessItemPrice5;
        }

        public string DisplayWinAnnoucement()
        {
            return "Congratulation, you have won the 'CheckOut' game";
        }
        public string DisplayLoseAnnoucement()
        {
            return "Sorry, you have lose the game";
        }

    }
}