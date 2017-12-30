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

        public static int[] GetXOverlap(Rectangle rectangle1, Rectangle rectangle2)
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

        public static int[] GetYOverlap(Rectangle rectangle1, Rectangle rectangle2)
        {
            int rectangle1TopY = rectangle1.BottomY + rectangle1.Height;
            int rectangle2TopY = rectangle2.BottomY + rectangle2.Height;

            int highestStartingPoint = Math.Max(rectangle1.BottomY, rectangle2.BottomY);
            int lowestEndingPoint = Math.Min(rectangle1TopY, rectangle2TopY);

            //starting point, then width of overlap
            int[] yOverlap = { 0, 0 };

            if (highestStartingPoint >= lowestEndingPoint)
                return yOverlap;

            int overlapWidth = lowestEndingPoint - highestStartingPoint;

            yOverlap[0] = lowestEndingPoint;
            yOverlap[1] = overlapWidth;

            return yOverlap;
        }


        public Rectangle GetIntersection(Rectangle rectangle1, Rectangle rectangle2)
        {
            int[] xOverlap = GetXOverlap(rectangle1, rectangle2);
            int[] yOverlap = GetYOverlap(rectangle1, rectangle2);
            int[] nullOverlap = new int[] { 0, 0 };

            if (xOverlap == nullOverlap || yOverlap == nullOverlap)
                return new Rectangle();

            return new Rectangle(xOverlap[0], yOverlap[0], xOverlap[1], yOverlap[1]);
        }

    }
}
