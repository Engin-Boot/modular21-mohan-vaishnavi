using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{  
	class ColorManualTester : IColorManual
	{ 
    
      private int major_size = GetColor.colorMapMajor.Length;
      private int minor_size = GetColor.colorMapMinor.Length;
      public void PrintManual()
      {
            Console.WriteLine("**Testing Manual**\n");
            int pairnum = 1;

            for (int i = 0; i < major_size; i++)
            {
                for (int j = 0; j < minor_size; j++)
                {
                    ColorPair testPair = GetColor.GetColorFromPairNumber(pairnum);
                    Debug.Assert(testPair.majorColor == GetColor.colorMapMajor[i]);
                    Debug.Assert(testPair.minorColor == GetColor.colorMapMinor[j]);

                    var test = new ColorPair();

                    test.majorColor = GetColor.colorMapMajor[i];
                    test.minorColor = GetColor.colorMapMinor[j];
                   
                    int pairNumber = ColorPair.GetPairNumberFromColor(testPair);
                    Debug.Assert(pairnum == pairNumber);
                    
                    pairnum++;
                }
            }
            Console.WriteLine("Testing completed\n");

        }

    }

    

}
