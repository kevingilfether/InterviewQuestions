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


        //brute force would be "plotting" each rectangle and then 
        //taking the intersection. This is probably fairly resource
        //intensive.
        //Better to see if width and height of rectangle 1 include any portion 
        // of rectangle 2
        // If they do, then proceed to check what they contain with iterative process?

        public int[] GetXOverlap(Rectangle rectangle1, Rectangle rectangle2)
        {
            int rectangle1RightX = rectangle1.LeftX + rectangle1.Width;
            int rectangle2RightX = rectangle2.LeftX + rectangle2.Width;

            int highestStartingPoint = Math.Max(rectangle1.LeftX, rectangle2.LeftX);
            int lowestEndingPoint = Math.Min(rectangle1RightX, rectangle2RightX);

            //starting point, then width of overlap
            int[] xOverlap = { 0, 0 };

            if (highestStartingPoint >= lowestEndingPoint)
                return xOverlap;

            int overlapWidth = lowestEndingPoint - highestStartingPoint;

            xOverlap[0] = lowestEndingPoint;
            xOverlap[1] = overlapWidth;

            return xOverlap;
        }

        public Rectangle GetIntersection(Rectangle rectangle1, Rectangle rectangle2)
        {


        }

    }
}
