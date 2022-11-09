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
        public static void saveSquareToFile()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\Marcin\Desktop\file.dat", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, SquareManager.SquareManager.getSquareList());
            stream.Close();
        }

        public static void readSquareFromFile()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\Marcin\Desktop\file.dat", FileMode.Open, FileAccess.Read);
            List<Square> squareList = (List<Square>)formatter.Deserialize(stream);

            SquareManager.SquareManager.squareList = squareList;
        }
    }
}
