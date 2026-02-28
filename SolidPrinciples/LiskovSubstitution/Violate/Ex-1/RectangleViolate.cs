using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.Violate.Ex_1
{
    internal class RectangleViolate
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int Area() => Width * Height;
    }
}
