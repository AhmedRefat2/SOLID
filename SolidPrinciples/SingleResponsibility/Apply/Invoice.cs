using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibility.Apply
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

        /// There Is No Probems here with SRP (Single Responsiplity Principle)
        /// Has One jop (Calculate Total)
    }
}
