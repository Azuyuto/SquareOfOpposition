using System;
using System.Collections.Generic;
using System.Linq;
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

        public Square()
        {
            AI = new List<Square>();
            EO = new List<Square>();
            IO = new List<Square>();
        }
    }
}
