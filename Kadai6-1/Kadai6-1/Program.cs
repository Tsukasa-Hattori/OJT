using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadai6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinMax MinMax1 = new MinMax();
            int[] pt = new int[5];
           // int min;
            //int max;


            for (int x = 0; x < pt.Length;)
            {
                Console.WriteLine("{0}個めの数値を入力してください", x + 1);
                string str = Console.ReadLine();

                int num;

                if (int.TryParse(str, out num))   //テキスト数値変換

                {   
                    int cnvr = int.Parse(str);    //intへ変換；

                        pt [x] = cnvr;              //変換した入力値を配列へ代入
                        x++;
                    
                }
                else
                {
                    Console.WriteLine("{0} は数値ではありません数値を入力してください", str);

                }            

            }

            int min = MinMax.Mincal(pt);
            int max = MinMax.Maxcal(pt);
            //int min = (pt.Min());
            //int max = (pt.Max());
            Console.WriteLine("入力した数値の最小値は{0}最大値は{1}です。", min, max);

            Console.ReadLine();
        }
    }
}
