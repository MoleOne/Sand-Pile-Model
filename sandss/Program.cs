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

            int size;
            int.TryParse(Console.ReadLine(), out size); // Ввод ширины файла
            stopwatch.Start();
            size = (size % 2 == 0) ? size : size + 1; // Проверяем на чётность, чтобы можно было делить на 2 (:
            size = (size % 2 == 0) ? size : size + 1;
            int[,] grains = new int[size, size];
            int Howmuch = 160000;
            var sand = new Bitmap(size, size); // Создаём файл, где будет модель
            grains[size / 2, size / 2] = Howmuch; // Добавляем песчинки в участок отрисовки
             for (int g = 0; g < Howmuch/2; g++)
             {
                 for (int i = size / 2; i < size - 1; i++)
                 {
                     for (int j = size / 2; j < size - 1; j++)
                     {


                         while (grains[i, j] >= 4)
                         {
                             if (i - 1 == size / 2)
                             {
                                 grains[i - 1, j]++;
                             }
                             if (j - 1 == size / 2)
                             {
                                 grains[i, j - 1]++;
                             }
                             grains[i, j] = grains[i, j] - 4;
                             grains[i + 1, j]++;
                             grains[i - 1, j]++;
                             grains[i, j + 1]++;
                             grains[i, j - 1]++;
                         }
                     }
                 }
             }
            for (int i = size / 2; i < size - 1; i++)
            {
                for (int j = size / 2; j < size - 1; j++)
                {
                    switch (grains[i, j])
                    {
                        case 0:
                            sand.SetPixel(i, j, Color.Green);
                            sand.SetPixel(size - i, j, Color.Green);
                            sand.SetPixel(size - i, size - j, Color.Green);
                            sand.SetPixel(i, size - j, Color.Green);
                            break;
                        case 1:
                            sand.SetPixel(i, j, Color.Yellow);
                            sand.SetPixel(size - i, j, Color.Yellow);
                            sand.SetPixel(size - i, size - j, Color.Yellow);
                            sand.SetPixel(i, size - j, Color.Yellow);
                            break;
                        case 2:
                            sand.SetPixel(i, j, Color.Gray);
                            sand.SetPixel(size - i, j, Color.Gray);
                            sand.SetPixel(size - i, size - j, Color.Gray);
                            sand.SetPixel(i, size - j, Color.Gray);
                            break;
                        case 3:
                            sand.SetPixel(i, j, Color.Orange);
                            sand.SetPixel(size - i, j, Color.Orange);
                            sand.SetPixel(size - i, size - j, Color.Orange);
                            sand.SetPixel(i, size - j, Color.Orange);
                            break;
                        default:
                            sand.SetPixel(i, j, Color.White);
                            break;
                    }
                }
            }
            sand.Save("d:\\sand2.bmp");
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

