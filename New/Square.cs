using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeDesigner
{
     class Square : Shapes
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Draw Square");
        }
    }
}