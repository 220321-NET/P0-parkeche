global using System;

namespace Models;

public class ProductItem
{
    public ProductItem(string purchase, string product, int price, int quantity) 
    {
        Purchase = purchase;
        Product = product;
        Price = price;
        Quantity = quantity;
    }

    public string Purchase { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}