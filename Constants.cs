using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnPFile_Prerunner
{
    class Constants
    {
        //Todo: include "height" as Parameter

        //number of relevant Columns and there fore boxes to set them
        public const int NumRelevantColumns = 7;
        //array wich holds the characters for splitting single strings
        public static readonly char[] splitDelimiters = new char[] { ',', ';' };
        //how data is processed inside the Programm:
        //      Designator; Name; Value, Footprint; CenterX; CenterY; Rotation
        public static readonly String[] ColumnNames = new String[] {"Designator", "Name", "Value", "Footprint", "X (mm)", "Y (mm)", "Rotation"};
    }

}
