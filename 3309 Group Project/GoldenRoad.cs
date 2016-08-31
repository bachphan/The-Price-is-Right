using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309_Group_Project
{
    public class GoldenRoad
    {
        Random fake = new Random();

        public double fakeprice1, fakeprice2, fakeprice3;

        public double actualprice;


        public void FirstItem(double playerchoice, double Actualprice)
        {
            fakeprice1 = actualprice + fake.Next(10, 100);
            actualprice = Actualprice;


            //if (playerchoice == actualprice)
            //    DisplayWinAnnoucementFor12();
            //if (playerchoice == fakeprice1)
            //    DisplayLoseAnnoucement();
        }
        public void SecondItem(int playerchoice, double Actualprice)
        {
            fakeprice1 = actualprice + fake.Next(100, 1000);
            fakeprice2 = actualprice + fake.Next(100, 1000);
            actualprice = Actualprice;

            //if (playerchoice == actualprice)
            //    DisplayWinAnnoucementFor12();
            //if (playerchoice == fakeprice1 || playerchoice == fakeprice2)
            //    DisplayLoseAnnoucement();
        }
        public void ThirdItem(int playerchoice, double Actualprice)
        {
            fakeprice1 = actualprice + fake.Next(1000, 10000);
            fakeprice2 = actualprice + fake.Next(1000, 10000);
            fakeprice3 = actualprice + fake.Next(1000, 10000);
            actualprice = Actualprice;

            //if (playerchoice == actualprice)
            //    DisplayWinAnnoucement();
            //if (playerchoice == fakeprice1 || playerchoice == fakeprice2 || playerchoice == fakeprice3)
            //    DisplayLoseAnnoucement();
        }



        public string DisplayWinAnnoucementFor12()
        {
            return "Congratulation, you won this round, please continue to the next round.";
        }
        public string DisplayWinAnnoucement()
        {
            return "Congratulation, you won the 'Golden Road'.";
        }
        public string DisplayLoseAnnoucement()
        {
            return "Sorry, you lose the game.";
        }
    }
}
