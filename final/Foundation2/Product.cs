using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Product
{
    private int productId;
    private string productName;
    private double price;
    private int quantity;

    public Product(int productId, string productName, double price, int quantity) 
    {
        this.productId = productId;
        this.productName = productName;
        this.price = price;
        this.quantity = quantity;    
    }
    public double computePrice()
    {
        double p = price * quantity;
        return p;
    }
    public string pack_label()
    {
        return (productName + "    " + productId.ToString());
    }

}

