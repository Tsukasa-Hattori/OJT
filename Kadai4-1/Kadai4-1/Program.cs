using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadai4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lim;

            Console.WriteLine("数値を入力してください");
            lim = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= lim; i++) 
            {
                Console.WriteLine("■");
            }

            Console.Read();
        }
    }
}
