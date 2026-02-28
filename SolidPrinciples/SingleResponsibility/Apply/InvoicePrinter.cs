using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibility.Apply
{
    internal static class InvoicePrinter
    {
        public static void PrintInvoice(Invoice invoice)
        {
            Console.WriteLine($"Book: {invoice?.Book?.Name}");
            Console.WriteLine($"Author: {invoice?.Book?.Author}");
            Console.WriteLine($"Price: {invoice?.Book?.Price}");
            Console.WriteLine($"Quantity: {invoice?.Quantity}");
            Console.WriteLine($"Discount Rate: {invoice?.DiscountRate * 100}%");
            Console.WriteLine($"Tax Rate: {invoice?.TaxRate * 100}%");
            Console.WriteLine($"Total: {invoice?.Total}");
        }


        /// This Class has One jop (Print Invoice Details)
    }
}
