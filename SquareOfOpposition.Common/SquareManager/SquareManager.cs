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

        public static List<Square> squareList = new List<Square>();

        public static void addToSquareList(Square square)
        {
            squareList.Add(square);
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
