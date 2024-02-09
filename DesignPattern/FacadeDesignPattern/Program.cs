using System;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Name = "Swarali",
                Email = "swarali.kulkarni@cctech.co.in",
                MobileNumber="99912122345"
            };


            CustomerRegistration customerRegistration = new CustomerRegistration();

            customerRegistration.RegisterCustomer(customer);
            Console.ReadKey();
        }
    }
}
