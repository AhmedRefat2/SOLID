using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosed.Apply
{
    internal interface IInvoicePresistence
    {
        void SaveInvoice(Invoice invoice);
    }
}
