using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadai5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key ;
            int r = 0 ;
            int m = 100 ;
            int[] numbers = new int[m];

            do
            {
                Console.WriteLine("{0}番目の数値を入力してください",r+1);
                key = Convert.ToInt32(Console.ReadLine());

     

                if (key <= m && 0 <= key )

                {

                    numbers[r] = key;

                    r++;

                   
                }


                if (key == -9999 || r == m )
                {

                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("{0}番目の要素の値は{1}です。", i + 1, numbers[i]);
                        
                    }
                    

                }


                if (key > 100 || key <0 )
                {
                    Console.WriteLine("正しくない点数が入力されました。確かめてもう一度入させてください");
                    
                }

            }
            while (r < m);

            Console.Read();

        }
    }
}
