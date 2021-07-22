using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{  
	class ColorManualPrinter : IColorManual
	{ 
    
      private int major_size = GetColor.colorMapMajor.Length;
      private int minor_size = GetColor.colorMapMinor.Length;
      public void PrintManual()
      {
            Console.WriteLine("**Printing Manual**\n");
            int pairnum = 1;

            for (int i = 0; i < major_size; i++)
            {
                for (int j = 0; j < minor_size; j++)
                {

                    Console.WriteLine("-> Pair Number: {0},Colors: major{1} - minor{2}\n", pairnum, GetColor.colorMapMajor[i], GetColor.colorMapMinor[j]);
                    pairnum++;
                }
            }

        }

    }

    

}
