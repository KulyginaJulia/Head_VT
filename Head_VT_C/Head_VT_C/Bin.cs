using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;

namespace Head_VT_C
{
    class Bin
    {
        public static int X, Y, Z;
        public static float VX, VY, VZ;
        public static short[] array;
        public Bin() { }

        public int GetZ()
        {
            return Z;
        }
        public int GetY()
        {
            return Y;
        }
        public int GetX()
        {
            return X;
        }
        public void readBIN(string path)
        {
            if (File.Exists(path))
            {
                BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open));

                X = reader.ReadInt32();
                Y = reader.ReadInt32();
                Z = reader.ReadInt32();

                VX = reader.ReadSingle();
                VY = reader.ReadSingle();
                VZ = reader.ReadSingle();

                int arraySize = X * Y * Z;
                array = new short[arraySize];
                for (int i = 0; i < arraySize; ++i)
                {
                    array[i] = reader.ReadInt16();
                }

            }
        }
    }
}
