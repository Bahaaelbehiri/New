using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeDesigner
{
     class Tirangle : Shapes
    {
        public int FirstPoint { get; set; }
        public int SecondPoint { get; set; }
        public int ThirdPoint { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Draw Tirangle");
        }
    }
}