using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.Apply.Ex_1
{
    internal class RectangleApply : ShapeApply
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override int GetArea() => Width * Height;
    }
}
