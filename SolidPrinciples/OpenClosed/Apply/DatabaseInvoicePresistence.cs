using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosed.Apply
{
    internal class DatabaseInvoicePresistence : IInvoicePresistence
    {
        public void SaveInvoice(Invoice invoice)
        {
            Console.WriteLine($"Invoice related to book {invoice.Book.Name} saved to database");
        }

        /// Finshed this class to save invoice to database and be tested 
        /// if we want to add new way to save invoice we should create new class
        /// and implement IInvoicePresistence and this is good for OCP - Open Closed Principle
    }
}
 