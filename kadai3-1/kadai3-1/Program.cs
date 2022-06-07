using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;


            Console.WriteLine("1から100の数値を入力してEnterを押してください . . .");
            a = Convert.ToInt32(Console.ReadLine());

           if(a%2 == 1)
            {
                Console.WriteLine("奇数です");
            }

           else
            {
                Console.WriteLine("偶数です");
            }

            Console.Read();
        }
    }
}
