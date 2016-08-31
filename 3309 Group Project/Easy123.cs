using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309_Group_Project
{
    /*Easy as 1 2 3
    The contestant is given three blocks, labeled "1," "2" and "3" respectively.
    The contestant must place the "1" block with the least expensive prize,
    the "2" with the next-least expensive, and the "3" with the most expensive.
    Doing so wins all three prizes. The contestant is given three blocks,
    labeled "1," "2" and "3" respectively. The contestant must place the "1"
    block with the least expensive prize, the "2" with the next-least expensive,
    and the "3" with the most expensive. Doing so wins all three prizes.
    */

    public class Easy123
    {
        //private bool win;
        //private double itemleastRank, itemMediumRank, itemHighestRank;
        private double item1, item2, item3;

        public Easy123(double Item1, double Item2, double Item3)
        {

            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            //Item1 is least
            if ((item1 <= item2) && (item1 <= item3))
            {
                item1 = 1;
                if (item2 <= item3)
                {
                    item2 = 2;
                    item3 = 3;
                }
                else
                {
                    item3 = 2;
                    item2 = 3;
                }
            }
            //Item2 is least
            if ((item2 <= item1) && (item2 <= item3))
            {
                item2 = 1;
                if (item1 <= item3)
                {
                    item1 = 2;
                    item3 = 3;
                }
                else
                {
                    item3 = 2;
                    item1 = 3;
                }
            }
            //Item3 is least
            if ((item3 <= item1) && (item3 <= item2))
            {
                item3 = 1;
                if (item1 <= item2)
                {
                    item1 = 2;
                    item2 = 3;
                }
                else
                {
                    item2 = 2;
                    item1 = 3;
                }
            }
        }

        public double GetItem1Price()
        {
            return item1;
        }
        public double GetItem2Price()
        {
            return item2;
        }
        public double GetItem3Price()
        {
            return item3;
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