using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosed.Violate
{
    internal class InvoicePresistence
    {
        private Invoice _invoice;
        public InvoicePresistence(Invoice invoice)
        {
            _invoice = invoice;
        }

        // Save Invoice 
        public void SaveInvoice(string savingWay)
        {
            if (savingWay == "file")
                Console.WriteLine($"Invoice related to book {_invoice.Book.Name} saved to file");
            else if (savingWay == "database")
                Console.WriteLine($"Invoice related to book {_invoice.Book.Name} saved to database");
            else 
                Console.WriteLine("Invalid Saving way");

            // Later if we want to add new way to save invoice we should modify this function and its class
            // and this violate OCP - Open Closed Principle
        }
    }
}
