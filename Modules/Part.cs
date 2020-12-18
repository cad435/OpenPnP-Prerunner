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
        public Part(String _Designator, String _Name, String _Value, String _Footprint, double _CenterX, double _CenterY, String _Layer ,double _Rotation)
        {
            Name = _Name;
            Designator = _Designator;
            Footprint = _Footprint;
            CenterX = _CenterX;
            CenterY = _CenterY;
            Rotation = _Rotation;
            Value = _Value;
            Layer = _Layer;

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
        public String Layer;
        public double Rotation;


        public String[] ToTable()
        {
            return new String[] { Designator, Name, Value, Footprint, CenterX.ToString(), CenterY.ToString(), Layer, Rotation.ToString() };
        }

        

        public String ToExport(bool CollapseNameAndValue, bool PreferValueOverName,  bool NamefieldEnable, bool footprintEnable, bool CenterXEnable, bool CenterYEnable, bool LayerEnable, bool RotationEnable, bool AddMMSuffix)
        {
            string s = "\"" + Designator;

            //if "Value" should be added to "Name", write that. 
            //PreferValueOverComment will not be applied

            if (NamefieldEnable)
            {
                s += "\",\"";

                if (CollapseNameAndValue)
                {
                    s += Name;

                    if (Value != "")
                    {
                        s += "(" + Value + ")";
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
            }
            //write the rest if needed
            if (footprintEnable)
            {
                s += "\",\"" + Footprint; ;
            }

            if (CenterXEnable)
            {
                s += "\",\"" + CenterX.ToString();
                if (AddMMSuffix)
                {
                    s += "mm";
                }
            }


            if (CenterYEnable)
            {
                s += "\",\"" + CenterY.ToString();
                if (AddMMSuffix)
                {
                    s += "mm";
                }
            }

            if (LayerEnable)
            {
                s += "\",\"" + Layer;
            }

            if (RotationEnable)
            {
                s += "\",\"" + Rotation.ToString();
            }

            s += "\"";

            return s;
        }

    }
}
