using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeDesigner
{
     class Circle : Shapes
    {
        public float Radius { get; set; }
        public float CenterX { get; set; }
        public float CenterY { get; set; }
        public override void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
}