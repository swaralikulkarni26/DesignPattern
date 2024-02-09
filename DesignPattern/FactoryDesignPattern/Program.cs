using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFromConsole = null;
            Console.WriteLine( "Enter vehicle type");
            inputFromConsole=Console.ReadLine();
           IVehicle Type= vehicalFactory.GetVehicle(inputFromConsole);
            Console.WriteLine("Number of vehical of " + inputFromConsole +  Type.NoOfwheels());
            Console.WriteLine("Number of vehical of " + inputFromConsole + Type.NoOfwheels());
        }
    }
}
