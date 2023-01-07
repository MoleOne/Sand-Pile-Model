using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace sandss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int a;
                double again;
                int weight;
                int hight;
                int.TryParse(Console.ReadLine(), out weight);
                int.TryParse(Console.ReadLine(), out hight);
                weight = (weight % 2 == 0) ? weight : weight + 1;
                hight = (hight % 2 == 0) ? hight : hight + 1;
                again = Math.Round(weight / 2 * 3.14 * 4) + 1;
                Console.WriteLine(again);
                int[,] pice = new int[weight, hight];
                var sand = new Bitmap(weight, hight);
                a = (int)again;
                pice[hight / 2, weight / 2] = a * 4;
                for (int g = 0; g < again*3; g++)
                {
                    for (int i = 1; i < weight; i++)
                    {
                        for (int l = 1; l < hight; l++)
                        {
                            if (pice[i, l] >= 4)
                            {
                                pice[i, l] = pice[i, l] - 4;
                                pice[i + 1, l]++;
                                pice[i - 1, l]++;
                                pice[i, l + 1]++;
                                pice[i, l - 1]++;
                            }
                            switch (pice[i, l])
                            {
                                case 0:
                                sand.SetPixel(i, l, Color.Green);
                                break;
                                case 1:
                                sand.SetPixel(i, l, Color.Yellow);
                                break;
                                case 2:
                                sand.SetPixel(i, l, Color.Purple);
                                break;
                                case 3:
                                sand.SetPixel(i, l, Color.Blue);
                                break;
                                default:
                                sand.SetPixel(i, l, Color.White);
                                break;
                            }
                        }
                    }
                }
            sand.Save("d:\\1.bmp");
            }
        }
    }

