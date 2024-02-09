using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
    }

    class Validator
    {
        public bool ValidateCustomer(Customer cusomer)
        {
            Console.WriteLine("Facade Design patern:");
            Console.WriteLine("Customer Validated.......");
            Console.WriteLine($"Name:{ cusomer.Name}");
            Console.WriteLine($"Email:{ cusomer.Email}");
            Console.WriteLine($"MobileNumber:{ cusomer.MobileNumber}");
            return true;
        }
    }

    class Save
    {
        public bool SaveCustomer(Customer cusomer)
        {
            Console.WriteLine("\nCustomer data Saved into database...!.");
            return true;
        }
    }


    class Email
    {
        public bool SendRegistrationMail(Customer cusomer)
        {
            Console.WriteLine("\nRegistration Email sent to customer!");
            return true;
        }
    }

    class CustomerRegistration
    {

        public bool RegisterCustomer( Customer customer)
        {
            Validator validator = new Validator();
            validator.ValidateCustomer(customer);

            Save save = new Save();
            save.SaveCustomer(customer);

            Email email = new Email();
            email.SendRegistrationMail(customer);

            return true;
        }

    }
}
