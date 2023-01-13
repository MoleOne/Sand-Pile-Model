using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace sandss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            int Scale;
            int.TryParse(Console.ReadLine(), out Scale); // Ввод ширины файла
            stopwatch.Start();
            Scale = (Scale % 2 == 0) ? Scale : Scale + 1; // Проверяем на чётность, чтобы можно было делить на 2 (:
            Scale = (Scale % 2 == 0) ? Scale : Scale + 1;
            int[,] pice = new int[Scale, Scale];
            int Howmuch = 80000;
            var sand = new Bitmap(Scale, Scale); // Создаём файл, где будет модель
            pice[Scale / 2+2, Scale / 2+2] = Howmuch; // Добавляем песчинки в участок отрисовки
            /* for (int g = 0; g < Howmuch/2; g++)
             {
                 for (int i = Scale / 2; i < Scale - 1; i++)
                 {
                     for (int j = Scale / 2; j < Scale - 1; j++)
                     {


                         while (pice[i, j] >= 4)
                         {
                             if (i - 1 == Scale / 2)
                             {
                                 pice[i - 1, j]++;
                             }
                             if (j - 1 == Scale / 2)
                             {
                                 pice[i, j - 1]++;
                             }
                             pice[i, j] = pice[i, j] - 4;
                             pice[i + 1, j]++;
                             pice[i - 1, j]++;
                             pice[i, j + 1]++;
                             pice[i, j - 1]++;
                         }
                     }
                 }
             } */
            Sand.Draw(ref sand, pice, Scale, Howmuch);
             stopwatch.Stop();
             Console.WriteLine(stopwatch.ElapsedMilliseconds);

            /*  for (int i = 0; i < weight; i++)
            {
                for (int j = 0; j < hight; j++)
                {
                    Console.Write(pice[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int g = 0; g < 1; g++)
            {       
            for (int i = weight / 2; i < weight-1; i++)
            {
                for (int l = hight/2; l < hight-1; l++)
                {
                    while (pice[i, l] >= 4)
                    {
                        pice[i, l] = pice[i, l] - 4;
                            pice[i + 1, l]++;
                        pice[i - 1, l]++;
                        pice[i, l + 1]++;
                        pice[i, l - 1]++;
                    }
                }
            } 
            ss = 0;
            for (int i = 0; i < Scale; i++)
                {
                    for (int j = 0; j < Scale; j++)
                    {
                       // Console.Write(pice[i, j]);
                        //Console.Write(" ");
                        ss =+ pice[i, j];
                    }
                }
                Console.WriteLine();
                Console.WriteLine(ss);*/
            Console.ReadLine();
            }
            
        }
    }

