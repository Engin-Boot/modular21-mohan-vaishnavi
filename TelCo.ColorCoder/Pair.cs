using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{  
	class Pair
	{
		public Color majorColor;
        	public Color minorColor;
		public override string ToString()
		{
		    return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
		}
        public static int GetPairNumberFromColor(Pair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i < getColor.colorMapMajor.Length; i++)
            {
                if (getColor.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }
            // Find the minor color in the array and get the index
            int minorIndex = -1;
            for (int i = 0; i < getColor.colorMapMinor.Length; i++)
            {
                if (getColor.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }

    }
}
	
