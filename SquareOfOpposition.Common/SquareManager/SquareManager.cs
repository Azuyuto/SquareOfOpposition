using SquareOfOpposition.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfOpposition.Common.SquareManager
{
    [Serializable]
    public static class SquareManager
    {
        public static List<Square> squareList = new List<Square>() { 
            new Square() { 
                SaP = "A",
                SeP = "E",
                SoP = "O",
                SiP = "I",
                EO = new List<Square>() {
                    new Square() {
                        SaP = "A",
                        SeP = "E",
                        SoP = "O",
                        SiP = "I",
                    }
                }
            }
        };

        public static void addToSquareList(Square square, Square parentSquare = null, string squareType = null)
        {
            if(parentSquare == null)
            {
                squareList.Add(square);
            }
            else
            {
                switch (squareType)
                {
                    case "AI":
                        parentSquare.AI.Add(square);
                        break;
                    case "EO":
                        parentSquare.EO.Add(square);
                        break;
                    case "IO":
                        parentSquare.IO.Add(square);
                        break;
                    default:
                        break;
                }
            }
        }

        public static List<Square> getSquareList()
        {
            return squareList;
        }

        public static void setSquareList(List<Square> list)
        {
            squareList = list;
        }
    }
}
