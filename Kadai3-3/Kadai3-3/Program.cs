using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadai3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            double h;
            double l;
            double r;
            double A;

            Console.WriteLine("面積を求める図形を選択して対応する番号を入力してください");
            Console.WriteLine("1　四角形");
            Console.WriteLine("2　三角形");
            Console.WriteLine("3　円形");

            a = Convert.ToInt32(Console.ReadLine());


            switch (a)
            {
                case 1:

                    Console.WriteLine("四角形角形の高さを入力してください（単位はmm)");
                    h = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("四角形底辺の長さを入力してください（単位はmm)");
                    l = Convert.ToInt32(Console.ReadLine());

                    A = h * l;


                    Console.Write("四角形の面積は");
                    Console.Write( A );
                    Console.WriteLine("mm^2です。");


                    break;


                case 2:
                        
                        Console.WriteLine("三角形の高さを入力してください（単位はmm)");
                    h = Convert.ToInt32(Console.ReadLine());

                    　　Console.WriteLine("三角形の底辺の長さを入力してください（単位はmm)");
                    l = Convert.ToInt32(Console.ReadLine());

                    A = h * l/2;


                    Console.Write("三角形の面積は");
                    Console.Write(A);
                    Console.WriteLine("mm^2です。");

                    break;

                case 3:

                    Console.WriteLine("円の半径を入力してください（単位はmm)");
                    r = Convert.ToInt32(Console.ReadLine());
                    double PI = 3.14;

                    A = PI * r *r ;


                    Console.WriteLine("円の面積は");
                    Console.Write(A);
                    Console.WriteLine("mm^2です。");

                    break;

            }

            Console.Read();
        }
    }
}
