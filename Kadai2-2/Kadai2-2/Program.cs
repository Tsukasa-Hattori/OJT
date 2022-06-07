using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadai2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            

            Console.WriteLine("数値1を入力してEnterを押してください . . .");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("数値2を入力してEnterを押してください. . .");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.Write("数値1+ 数値2＝");
            Console.Write(c);


            Console.Read();
        }
    }
}
