using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2onPipeline
{
    public class Area
    {
        public void Circlearea()
        {
            {
                int rad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(3.14 * rad * rad);
            }
        }
        public void Squarearea()
        {
            {
                int s = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(s * s);
            }
        }
        public void Trianglearea()
        {
            {
                int l = Convert.ToInt32(Console.ReadLine());
                int h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(0.5 * l * h);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Area obj = new Area();
            obj.Circlearea();
            obj.Squarearea();
            obj.Trianglearea();
            Console.ReadKey();
        }
    }
}
