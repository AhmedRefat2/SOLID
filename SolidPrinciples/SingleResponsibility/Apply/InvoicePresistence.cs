using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibility.Apply
{
    internal class InvoicePresistence 
    {
        private Invoice _invoice; 
        public InvoicePresistence(Invoice invoice)
        {
            _invoice = invoice;
        }

        // Save Invoice to File 
        public void SaveInvoiceToFile(string fileName)
        {
            Console.WriteLine($"Invoice releated to Bokk: {_invoice?.Book?.Name} saved to this file {fileName}");
        }

        // Save Invoice to Database 
        public void SaveInvoiceToDatabase(string connectionString)
        {
            Console.WriteLine("Invoice saved to database.");
        }

        /// This Class has One jop Saving Invoice (Apply SRP)
        /// but has problems with OCP (Open Closed Principle) 
        /// because if we want to add new way to save invoice we should modify this class and this is not good for OCP
    }
}
