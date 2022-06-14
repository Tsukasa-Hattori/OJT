using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadai5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] pt = new int[5,3];//ｘ軸　人、y軸　教科


            for (int x = 0; x < pt.GetLength(0); x++ )  //x方向走査
            {

                for (int y = 0; y < pt.GetLength(1) ; ) //y方向走査
                {

                   
                    string[] subject = new string[3] { "国語", "英語", "数学" }; //教科名



                    Console.WriteLine("{0}人目の{1}の得点を入力してください", x+1, subject[y]);
                    string str = Console.ReadLine();

                    int num;



                    if (int.TryParse(str, out num))   //テキスト数値変換

                    {
                        Console.WriteLine("得点が入力されました。");
                        int cnvr = int.Parse(str);    //intへ変換；

                        if (0 <= cnvr && cnvr <= 100)    // 範囲内の入力のみ受付
                        {

                            pt[x, y] = cnvr;              //変換した入力値を配列へ代入

                            y++;
                        }


                        else
                        {
                            Console.WriteLine("{0} は範囲外です0-100の間で点数を入力してください", str);
                        }

                    }
                    else
                    {
                        Console.WriteLine("{0} は数値ではありません数値を入力してください", str);

                    }




                }


               

            }

            for (int cx = 0; cx < pt.GetLength(0); cx++)

            {
                double average = 0;

                for ( int cy =0; cy < pt.GetLength(1); cy++)
                {
                    int sum = 0;

                  sum = pt[cx, 0] + pt[cx, 1] + pt[cx, 2];  //合計計算

                    average = (double)sum / pt.GetLength(1);             //平均計算
                   
                }
                
                Console.WriteLine("{0}人目の平均点は{1}点です", cx + 1, average);
            }
            Console.ReadLine();
        }
    }
}
   