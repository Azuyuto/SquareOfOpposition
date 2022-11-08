using SquareOfOpposition.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfOpposition.Common.SquareManager
{
    public static class SquareManager
    {
        public static List<Square> squareList = new List<Square>();

        public static void addToSquareList(Square square)
        {
            squareList.Add(square);
        }

    }
}
