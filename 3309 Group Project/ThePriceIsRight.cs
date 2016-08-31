using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309_Group_Project
{
    public class ThePriceIsRight
    {
        //GameObject[] arr = new GameObject[6];

        public int ChooseGame(int gameChoosen)    //Game chosen will be the button text (1,2,3,4,5,6)
        {
            if (gameChoosen == 1)
            {
                return 1;  //First Game
            }
            else if (gameChoosen == 2)
            {
                return 2;  //Second Game
            }
            else if (gameChoosen == 3)
            {
                return 3;       //Third Game
            }
            else if (gameChoosen == 4)
            {
                return 4;       //Fourth Game
            }
            else if (gameChoosen == 5)
            {
                return 5;       //Fifth Game
            }
            else if (gameChoosen == 6)
            {
                return 6;       //Sixth Game
            }
            else
                return 0;
        }
    }
}
