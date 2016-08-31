using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309_Group_Project
{
    internal class ArrayPictureItems
    {
        private static Image[] imageList = new Image[30];
        internal ArrayPictureItems()
        {
            for (int i = 0; i < 25; i++)
            {
                imageList[i] = (Image)(new Bitmap("Resources/index" + i + ".jpg")); 
            }
           
        }
        internal static Image GetItemPicture(int i)
        {
            return imageList[i]; 
        }

    }
}
