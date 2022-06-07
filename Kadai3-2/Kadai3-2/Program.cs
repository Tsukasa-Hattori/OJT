using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadai3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("1から100の数値を入力してEnterを押してください . . .");
            a = Convert.ToInt32(Console.ReadLine());

            if (  a  >= 80 && a <=100 )
            {
                Console.WriteLine("優");
            }

            if (a >= 70 && a < 80)
            {
                Console.WriteLine("優");
            }

                if (a >= 60 && a < 70)
            {
                Console.WriteLine("可");
            }

            if (a >= 0 && a < 60)
            {
                Console.WriteLine("不可");
            }

           if (a > 100 || a < 0)
            {
                Console.WriteLine(" 範囲外");
            }

            Console.Read();
        }
    }
}
