using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309_Group_Project
{
    public class MostExpensive
    {
        public double firstItem, secondItem, thirdItem;
        public int playerchoice;

        public MostExpensive()
        {
            firstItem = 0;
            secondItem = 0;
            thirdItem = 0;
        }

        public bool TestMostExpensive(double item1, double item2, double item3)
        {
            if (item1 > item2 && item1 > item3)
            {
                if (playerchoice == 1)
                    return true;
                else
                    return false;
            }
            else if (item2 > item3 && item2 > item1)
            {
                if (playerchoice == 2)
                    return true;
                else
                    return false;
            }
            else if (item3 > item2 && item3 > item1)
            {
                if (playerchoice == 3)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public string DisplayWinAnnoucement()
        {
            return "Congratulation, you have won the 'Most Expensive' game";
        }
        public string DisplayLoseAnnoucement()
        {
            return "Sorry, you have lose the game";
        }
    }
}
