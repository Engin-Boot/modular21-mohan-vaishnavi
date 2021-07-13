using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{  
	class ColorManual
	{
  
      public static void printManual()
      {
        int pairnum = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    Console.WriteLine("-> Pair Number: {0},Colors: major{1} - minor{2}\n", pairnum, GetColor.colorMapMajor[i], GetColor.colorMapMinor[j]);
                    pairnum++;
                }
            }

        }

    }
}
