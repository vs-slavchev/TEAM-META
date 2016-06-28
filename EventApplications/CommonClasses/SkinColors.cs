using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CommonClasses
{
    public static class SkinColors
    {
        public static ColorScheme GetDefaultColor()
        {
            return purple;
        }

        public static ColorScheme

            purple = new ColorScheme(Primary.Purple700, Primary.Purple900,
            Primary.Purple400, Accent.Purple100, TextShade.WHITE),

            amber = new ColorScheme(Primary.Amber700, Primary.Amber900,
            Primary.Amber400, Accent.Amber100, TextShade.WHITE),

            green = new ColorScheme(Primary.Green700, Primary.Green900,
            Primary.Green400, Accent.Green100, TextShade.WHITE);
    }
}
