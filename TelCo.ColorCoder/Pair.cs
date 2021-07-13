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
		
		public static int GetColorIndex(Color[] colorArray, Color color)
		{
			int index = -1;
			for (int i = 0; i < colorArray.Length; i++)
				    {
					if (colorArray[i] == color)
					{
					    index = i;
					    break;
					}
				    }
			return index;
		}
		
        public static int GetPairNumberFromColor(Pair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = GetColorIndex(GetColor.colorMapMajor, pair.majorColor);
            
            // Find the minor color in the array and get the index
            int minorIndex = GetColorIndex(GetColor.colorMapMinor, pair.minorColor);
            
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * GetColor.colorMapMinor.Length) + (minorIndex + 1);
        }

    }
}
	
