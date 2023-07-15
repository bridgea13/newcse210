using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order("Alice Bridge", "333 Main St.", "Bovo", "NV", "US");
        order1.addProduct(234788, "Paper towels", 2.32, 1);
        order1.addProduct(25698, "Soup", 1.99, 2);
        order1.display_totalCost();
        order1.display_shipLabel();
        order1.display_packingLabel();

        Order order2 = new Order("Tanya Gridge", "123 Town St.", "Mesa", "CR", "UK");
        order2.addProduct(5944, "Green Beans", .65, 4);
        order2.addProduct(232288, "Straws", .75, 1);
        order2.addProduct(4788, "Bananas", 2.00, 1);
        order2.display_totalCost();
        order2.display_shipLabel();
        order2.display_packingLabel();




    }
}
