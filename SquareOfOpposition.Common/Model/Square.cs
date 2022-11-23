using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfOpposition.Common.Model
{
    [Serializable]
    public class Square
    {
        public string? SaP { get; set; } // up-left

        public string? SeP { get; set; } // up-right

        public string? SiP { get; set; } // down-left

        public string? SoP { get; set; } // down-right

        public List<Square> AI { get; set; }
        public List<Square> EO { get; set; }
        public List<Square> IO { get; set; }

        public bool AI_EO { get; set; }
        public bool EO_AI { get; set; }

        public bool EO_IO { get; set; }
        public bool IO_EO { get; set; }

        public bool AI_IO { get; set; }
        public bool IO_AI { get; set; }

        public Square()
        {
            AI = new List<Square>();
            EO = new List<Square>();
            IO = new List<Square>();
        }

        public object this[string propertyName]
        {
            get
            {
                // probably faster without reflection:
                // like:  return Properties.Settings.Default.PropertyValues[propertyName] 
                // instead of the following
                Type myType = typeof(Square);
                PropertyInfo myPropInfo = myType.GetProperty(propertyName);
                return myPropInfo.GetValue(this, null);
            }
            set
            {
                Type myType = typeof(Square);
                PropertyInfo myPropInfo = myType.GetProperty(propertyName);
                myPropInfo.SetValue(this, value, null);
            }
        }
    }
}
