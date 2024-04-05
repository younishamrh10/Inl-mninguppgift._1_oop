using Inlämninguppgift._1_oop;
using System;

namespace Inlämninguppgift._1_oop
{
    class program
    {
        static void Main(string[] args)
        {
            bil p = new bil("volvo", "x70", "vit", 1, 35000);

            bil p2 = new bil("BMW", "m5", "svart", 1, 10000);

            p.Mymetod();
            Console.WriteLine("");
            p2.Mymetod();
        }
    }
}