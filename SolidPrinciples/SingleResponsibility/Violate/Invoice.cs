using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibility.Violate
{
    internal class Invoice
    {

        public Book Book { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal TaxRate { get; set; }
        public decimal Total { get; set; }
        public Invoice(Book book, int quantity, decimal discountRate, decimal taxRate)
        {
            Book = book;
            Quantity = quantity;
            DiscountRate = discountRate;
            TaxRate = taxRate;
            Total = CalculateTotal();
        }

        // 1. Calculate Total 
        public decimal CalculateTotal()
        {
            decimal subtotal = Book?.Price * Quantity ?? 0; // 1000
            decimal discount = subtotal * DiscountRate; // 1000 * 0.1 = 100
            decimal afterDiscount = subtotal - discount; // 1000 - 100 = 900
            decimal tax = afterDiscount * TaxRate; // 900 * 0.05 = 45
            
            decimal total = afterDiscount + tax;
            return total;
        }

        // 2. Print Invoice Details
        public void PrintInvoice()
        {
            Console.WriteLine($"Book: {Book?.Name}");
            Console.WriteLine($"Author: {Book?.Author}");
            Console.WriteLine($"Price: {Book?.Price}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Discount Rate: {DiscountRate * 100}%");
            Console.WriteLine($"Tax Rate: {TaxRate * 100}%");
            Console.WriteLine($"Total: {Total}");
        }
        // 3. Save Invoice to Database 
        public void SaveInvoiceToDatabase(string connectionString)
        {
            Console.WriteLine("Invoice saved to database.");
        }

        // 4. Save Invoice to File 
        public void SaveInvoiceToFile(string fileName)
        {
            Console.WriteLine($"Invoice releated to Bokk: {Book?.Name} saved to this file {fileName}");
        }

        /// <problems>
        /// Now This Class has multiple responsibilities, it is responsible for calculating total,
        /// printing invoice details, saving invoice to database and saving invoice to file. 
        /// This violates the Single Responsibility Principle because if we need to change the way
        /// we calculate total, we will also need to change the way we print invoice details, 
        /// save invoice to database and save invoice to file.
        /// This can lead to bugs and maintenance issues in the future.

    }
}
