using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnPFile_Prerunner.Modules
{
    public class Part
    {
        //safe designator. Everything will be filled in for you!
        public Part(String _Designator, String _Name, String _Value, String _Footprint, double _CenterX, double _CenterY, double _Rotation)
        {
            Name = _Name;
            Designator = _Designator;
            Footprint = _Footprint;
            CenterX = _CenterX;
            CenterY = _CenterY;
            Rotation = _Rotation;
            Value = _Value;

        }

        //empty Constructor, be sure to not forget something!
        public Part()
        {
            
        }

        public String Name;
        public String Designator;
        public String Footprint;
        public String Value;
        public double CenterX;
        public double CenterY;
        public double Rotation;


        public String[] ToTable()
        {
            return new String[] { Designator, Name, Value, Footprint, CenterX.ToString(), CenterY.ToString(), Rotation.ToString() };
        }

        

        public String ToExport(bool CollapseNameAndValue = true, bool PreferValueOverName = true)
        {
            string s = "\"" + Designator + "\",\"";

            //if "Value" should be added to "Name", write that. 
            //PreferValueOverComment will not be applied

            if (CollapseNameAndValue)
            {
                if (Value != "")
                {
                    s += Name + "(" + Value + ")";
                }
            }
            //if we will not merge name and value into one field AND Value is preferred AND there is ACTUALLY a value
            else if (!CollapseNameAndValue && PreferValueOverName && Value != "")
            {
                s += Value;
            }
            else
            {
                //else, just write the name
                s += Name;
            }

            //write the rest

            s += "\",\"" + Footprint + "\",\"" + CenterX.ToString() + "\",\"" + CenterY.ToString() + "\",\"" + Rotation.ToString() + "\"";

            return s;
        }

    }
}
