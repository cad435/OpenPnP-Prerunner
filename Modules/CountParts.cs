using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnPFile_Prerunner.Modules
{
    class CountParts
    {
        //dont use a ref here, cause we well be deleting things from the list!
        public CountParts(List<Part> _parts)
        {
            parts = _parts;
            PartMap = new Dictionary<Part, int>();
        }

        private List<Part> parts;
        //stores a Part with a count how often the part is used, Attribute "Designator", Posx, PosY and Rotation are always 0 or ""
        Dictionary<Part, int> PartMap;

        public void Count()
        {
            while (parts.Count > 0)
            {
                Part p = parts.First();

                //remove all parts with equal name, Footprint and Value. Returns number of removed elements (and such the count how many elements initially were listed)
                int NumParts = parts.RemoveAll(Part => (Part.Footprint == p.Footprint && Part.Name == p.Name && Part.Value == p.Value));

                //reset Designator, Center and Rotation, we don't need them!
                p.Designator = "";
                p.CenterX = 0;
                p.CenterY = 0;
                p.Rotation = 0;

                PartMap.Add(p, NumParts);
            }
        }

        public String ExportNext(bool CollapseNameAndValue, bool PreferValue)
        {
            String s = "";
            if (PartMap.Count > 0)
            {
                Part p = PartMap.First().Key;

                //if "Value" should be added to "Name", write that. 
                //PreferValueOverComment will not be applied

                if (CollapseNameAndValue)
                {
                    s += p.Name;

                    if (p.Value != "")
                    {
                        s += "(" + p.Value + ")";
                    }
                }
                //if we will not merge name and value into one field AND Value is preferred AND there is ACTUALLY a value
                else if (!CollapseNameAndValue && PreferValue && p.Value != "")
                {
                    s += p.Value;
                }
                else
                {
                    //else, just write the name
                    s += p.Name;
                }

                s += "; " + p.Footprint;

                s += "; " + PartMap.First().Value;

                //remove that part out of the list, so on next call another element wil be exported
                PartMap.Remove(p);

            }
            return s;
        }

    }
}
