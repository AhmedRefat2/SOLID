using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OpenClosed.Violate
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
            decimal subtotal = Book?.Price * Quantity ?? 0; 
            decimal discount = subtotal * DiscountRate;
            decimal afterDiscount = subtotal - discount; 
            decimal tax = afterDiscount * TaxRate; 
            decimal total = afterDiscount + tax;
            return total;
        }
    }
}
