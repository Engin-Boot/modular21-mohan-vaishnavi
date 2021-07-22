
using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{  
public class ColorManual
    {
        private IColorManual _colorManual;

        public ColorManual(IColorManual colorManual)
        {
            this._colorManual = colorManual;
        }
        public void PrintManual()
        {
            _colorManual.PrintManual();

        }
    }
}