using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309_Group_Project
{
    public class FinalShowDown
    {
        public double firstItemPrice;
        public double secondItemPrice;
        public double thirdItemPrice;
        public double sum;

        public FinalShowDown()
        {
            firstItemPrice = 0;
            secondItemPrice = 0;
            thirdItemPrice = 0;
            sum = firstItemPrice + secondItemPrice + thirdItemPrice;
        }

        public bool CheckAnswer(double playerInput, double sum)
        {
            if ((sum - playerInput) < 500 && (playerInput - sum) < 500)
            {
                DisplayWinAnnouce();
                return true;
            }
            else if ((sum - playerInput) > 500 && (playerInput - sum) > 500)
            {
                DisplayLoseAnnouce();
                return false;
            }
            return false;
        }

        public string DisplayWinAnnouce()
        {
            return "Congratulation, you won the 'Final Show Down'.";
        }
        public string DisplayLoseAnnouce()
        {
            return "Sorry, you lose the game.";
        }
    }
}