using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Customer
{

    private string name;
    private Address address;

    public Customer(string name, string strAddress, string city, string state, string country)
    {
        this.name = name;
        address = new Address(strAddress, city, state, country);
    }

    public bool checkUS()
    {
        return address.checkUS();
        
    }

    public string shippingLabel() 
    {
        string add = address.returnAddress();
        return (name + "\n" + add );
     }
}

