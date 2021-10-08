/*  Purpose:    Demonstrate how to output values in columns by setting the width of each column
 * 
 *  Inputs:     N/A
 *  
 *  Outputs:    Item Name(19)       Qty(3)  Unit Price(14)   Extended Price(20)
 *              123456789012345678901234567890123456789012345678901234567890
 *              Item 1                2          $2.00               $4.00
 *              Item 2               10          $1.50              $15.00
 *                                           Subtotal:(38)          $19.00 
 *                                           Tax:(38)                $0.95
 *                                           Total: (38)            $19.95 
 *                                            
 *                                            
 * */
using System;

namespace cpsc1012_1211_oa06_ColumnOutputDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ColumnHeadingItemName = "Item Name";
            const string ColumnHeadingQty = "Qty";
            const string ColumnHeadingUnitPrice = "Unit Price";
            const string ColumnHeadingExtendedPrice = "Extended Price";

            const string item1 = "Item 1";
            const int qty1 = 2;
            const double unitPrice1 = 2.00;
            double extendedPrice1 = qty1 * unitPrice1;

            const string item2 = "Item 2";
            const int qty2 = 10;
            const double unitPrice2 = 1.50;
            double extendedPrice2 = qty2 * unitPrice2;

            double subTotal = extendedPrice1 + extendedPrice2;
            const double TaxRate = 0.05;
            double taxAmount = subTotal * TaxRate;
            double total = subTotal + taxAmount;

            Console.WriteLine($"{ColumnHeadingItemName, -19} {ColumnHeadingQty, 3} {ColumnHeadingUnitPrice, 14} {ColumnHeadingExtendedPrice, 20}");
            Console.WriteLine($"{item1, -19} {qty1, 3} {unitPrice1, 14:C} {extendedPrice1, 20:C}");
            Console.WriteLine($"{item2, -19} {qty2, 3} {unitPrice2, 14:C} {extendedPrice2, 20:C}");
            Console.WriteLine($"{"SubTotal:",38} {subTotal, 20:C}");
            Console.WriteLine($"{"Tax:",38} {taxAmount,20:C}");
            Console.WriteLine($"{"Total:",38} {total,20:C}");


        }
    }
}
