using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace AdapterDesignPattern
{
    public class Customer
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }
    public static class CustomerDataProvider
    {
       public static List<Customer> GetData() => new List<Customer>
        {
            new Customer{Country="USA", Name="Swarali", Address="Address1" },
             new Customer{Country="Germany", Name="Swarali", Address="Address1" }
        };
    }
    public class ThirdPartyAPI
    {
        //public string GetCustomer()
        //{
        //    return JsonConvert.SerializeObject(CustomerDataProvider.GetData());
        //}
         
        public XDocument GetXML()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Customers");
            var xAttributes = CustomerDataProvider.GetData().Select(m=> new XElement
            ("Customers", new XAttribute("Country", m.Country),
                         new XAttribute("Name" m.Name)
                 )) ;
            xElement.Add(xAttributes);
            xDocument.Add(xElement);
            return xDocument;


        }
    }


}
