using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.Apply.Ex_1
{
    internal class SquareApply : ShapeApply
    {
        public int Side { get; set; } // Width Or Height

        public override int GetArea() => Side * Side;
    }
}
