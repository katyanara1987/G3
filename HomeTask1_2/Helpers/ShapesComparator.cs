using System;
using System.Collections.Generic;
using System.Text;

    public class ShapesComparator
    {
        public static string CircleToSquareRatio(double circleDiametr, double squareSide) {

            string result = "";

            if (circleDiametr < squareSide) {
                result = "The Circle fits into the Square";
            }
            if (circleDiametr == squareSide) {
                result = "The Circle intersects with the Square"; 
            }
            if (circleDiametr > squareSide) {
                result = "The Circle does not fit into the Square";
            }
            return result;
        }

        public static string SquareToCircleRatio(double circleDiametr, double squareDiagonal)
        {
            string result = "";

            if (circleDiametr > squareDiagonal)
            {
                result = "The Square fits into the Circle";
            }
            if (circleDiametr == squareDiagonal)
            {
                result = "The Square intersects with the Circle";
            }
            if (circleDiametr < squareDiagonal)
            {
                result = "The Square does not fit into the Circle";
            }

            return result;
        }
    }

