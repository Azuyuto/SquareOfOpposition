using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using SquareOfOpposition.Common.Model;
using SquareOfOpposition.Common.SquareManager;

namespace SquareOfOpposition.Common.FileManager
{
    public static class FileManager
    {
        public static void saveSquareToFile(string file)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, SquareManager.SquareManager.getSquareList());
            stream.Close();
        }

        public static void readSquareFromFile(string file)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read);
            List<Square> squareList = (List<Square>)formatter.Deserialize(stream);
            stream.Close();
            SquareManager.SquareManager.squareList = squareList;
        }
    }
}
