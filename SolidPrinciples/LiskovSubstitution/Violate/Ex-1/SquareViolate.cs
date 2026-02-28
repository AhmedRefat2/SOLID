using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.Violate.Ex_1
{
    internal class SquareViolate : RectangleViolate
    {
        public override int Width {
            set 
            {
                base.Width = value;
                base.Height = value;
            } 
        }

        public override int Height {
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
    }
}
