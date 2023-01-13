using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace sandss
{
    public class Sand
    {
        static void BuildModel(int Scale, ref int[,] pice, int Howmuch)
        {
            for (int g = 0; g < Howmuch / 2; g++)
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
            }
        }
       public static void Draw(ref Bitmap sand, int[,] model, int Scale, int Howmuch)
        {
            BuildModel(Scale, ref model, Howmuch);
            for (int i = Scale / 2; i < Scale - 1; i++)
            {
                for (int j = Scale / 2; j < Scale - 1; j++)
                {
                    switch (model[i, j])
                    {
                        case 0:
                            sand.SetPixel(i, j, Color.Green);
                            sand.SetPixel(Scale - i, j, Color.Green);
                            sand.SetPixel(Scale - i, Scale - j, Color.Green);
                            sand.SetPixel(i, Scale - j, Color.Green);
                            break;
                        case 1:
                            sand.SetPixel(i, j, Color.Yellow);
                            sand.SetPixel(Scale - i, j, Color.Yellow);
                            sand.SetPixel(Scale - i, Scale - j, Color.Yellow);
                            sand.SetPixel(i, Scale - j, Color.Yellow);
                            break;
                        case 2:
                            sand.SetPixel(i, j, Color.Gray);
                            sand.SetPixel(Scale - i, j, Color.Gray);
                            sand.SetPixel(Scale - i, Scale - j, Color.Gray);
                            sand.SetPixel(i, Scale - j, Color.Gray);
                            break;
                        case 3:
                            sand.SetPixel(i, j, Color.Orange);
                            sand.SetPixel(Scale - i, j, Color.Orange);
                            sand.SetPixel(Scale - i, Scale - j, Color.Orange);
                            sand.SetPixel(i, Scale - j, Color.Orange);
                            break;
                        default:
                            sand.SetPixel(i, j, Color.White);
                            break;
                    }
                }
            }
            sand.Save("d:\\sand1.bmp");
        }
    }
}


    

