using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.DrawPoint();

            Point p2 = new Point(4, 5, '#');
            p2.DrawPoint();

            Point p3 = new Point(2, 6, '%');
            p3.DrawPoint();

            Point p4 = new Point(3, 2, '&');
            p4.DrawPoint();


            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            List<char> charList = new List<char>();
            charList.Add('&');
            charList.Add('*');
            charList.Add('#');
            charList.Add('$');

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }


            foreach (char sym in charList)
            {
                Console.WriteLine(sym);
            }


            Console.ReadLine();

            List<Point> pList = new List<Point>
            {
                p1,
                p2,
                p3,
                p4
            };
        }
        

    }

}
