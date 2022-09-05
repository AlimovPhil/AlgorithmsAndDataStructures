using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_structures.Lesson3
{
    public class PointClass
    {
        public float X;
        public float Y;

        public void PrintPoint(PointClass pointClass, string tag)
        {
            Console.WriteLine($"{tag}\t X:{pointClass.X}, Y:{pointClass.Y}");
        }
    }
}
