using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions
{
    class Rectangle
    {
        //XY coordinates of bottom corner
        public int LeftX { get; set; }
        public int BottomY { get; set; }

        //Dimensions of rectangle
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(int leftX, int bottomY, int width, int height)
        {
            this.LeftX = leftX;
            this.BottomY = bottomY;
            this.Width = width;
            this.Height = height;
        }



    }
}
