using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Address
{

    private string strAddress;
    private string city;
    private string state;
    private string country;

    public Address(string strAddress, string city, string state, string country)
    { 
        this.strAddress = strAddress; 
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public string returnAddress()
    {
        return (strAddress + "\n" + city + "\n" + state + "\n" + country);
    }

    public bool checkUS()
    {
        if (country == "US") { return true; }
        else { return false; }
    }

    
}

