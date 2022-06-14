using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadai7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Data d = new Data();
            d.number = 100;
            d.comment = "Programming C#";
            Console.WriteLine("number = " + d.number);
            Console.WriteLine("comment = " + d.comment);
            Console.ReadLine();
        }
    }

}
