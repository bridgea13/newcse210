using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


internal class Order
{
    private List <Product> productList = new List<Product>();
    private Customer customer;
    
    

    public Order(string name, string strAddress, string city, string state, string country)
    {     
        
        customer = new Customer(name, strAddress, city, state, country);

    }

    public void addProduct(int productId, string productName, double price, int quantity)
    {
        Product item = new Product(productId, productName, price, quantity);
        productList.Add(item);
    }
    private double CalcShipCost()
    {
        if(customer.checkUS()) { return 5.00; }
        else { return 35.00; }
    }
    private string CalcTotalCost()
    {
        double shipping = CalcShipCost();
        double subTotal = 0;
        foreach(Product item in productList) { subTotal += item.computePrice(); }
        double c = subTotal + shipping;
        return c.ToString();
    }

    public void display_totalCost()
    {
        Console.WriteLine("\n\nTotal Cost = $" + CalcTotalCost());
        Console.WriteLine();
    }

    public void display_shipLabel()
    { 
        Console.WriteLine("\n\nShipping Label: \n");
        Console.WriteLine(customer.shippingLabel());

    }
    public void display_packingLabel() 
    {
        Console.WriteLine("\n\nPacking Label: \n");
        Console.WriteLine("Product Name   Product Item");
        foreach(Product item in productList) 
        {
            Console.WriteLine(item.pack_label());
        }
    }
}

