using System;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorManager colorManager = new ColorManager();

            // initialize standard color
            colorManager["red"] = new Color(255, 0, 0);
            colorManager["green"] = new Color(0, 255, 0);
            colorManager["blue"] = new Color(0, 0, 255);
            
            //custom color
            colorManager["angry"] = new Color(255, 54, 0);
            // user clone selected color;
            
            Color color1 = colorManager["red"].Clone() as Color;
            Color color2 = colorManager["angry"].Clone() as Color;
        }
    }
}