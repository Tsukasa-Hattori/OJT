using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadai4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int lim;

            Console.WriteLine("数値を入力してください");
            lim = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            while ( i <= lim)
            {
                    Console.WriteLine("■");
                i++;
            }

                Console.Read();
            
        }
    }
}
