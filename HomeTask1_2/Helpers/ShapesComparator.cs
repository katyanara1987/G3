using System;
using System.Collections.Generic;
using System.Text;

public class ShapesComparator
{
    public static bool CircleToSquareRatio(double circleDiametr, double squareSide) {

        if (circleDiametr <= squareSide) {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool SquareToCircleRatio(double circleDiametr, double squareDiagonal)
    {

        if (squareDiagonal <= circleDiametr)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
 
