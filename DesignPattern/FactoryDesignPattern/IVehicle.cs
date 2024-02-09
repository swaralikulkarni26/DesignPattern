using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public interface IVehicle
    {
        public int NoOfwheels();
        public string VehicleType();

    }
    public class Car : IVehicle
    {
        private readonly int wheels;
        public Car()
        {
            this.wheels = 4;
        }
        public int NoOfwheels()
        {
            return this.wheels;
        }
        public string VehicleType()
        {
            return "Car Type";
        }

    }
    public class Bike : IVehicle
    {
        private readonly int wheels;
        public Bike()
        {
            this.wheels = 2;
        }
        public int NoOfwheels()
        {
            return this.wheels;
        }
        public string VehicleType()
        {
            return "Bike Type";
        }
    }

        public class Auto : IVehicle
        {
            private readonly int wheels;
            public Auto()
            {
                this.wheels = 3;
            }
            public int NoOfwheels()
            {
                return this.wheels;
            }
            public string VehicleType()
            {
                return "Auto Type";
            }
        }

        public class vehicalFactory
        {
            public static IVehicle GetVehicle(string Type)
            {
                IVehicle ObjectType = null;
                if (Type.ToLower().Equals("car"))
                {
                    ObjectType = new Car();
                }
                if (Type.ToLower().Equals("bike"))
                {
                    ObjectType = new Bike();
                }
                if (Type.ToLower().Equals("auto"))
                {
                    ObjectType = new Auto();
                }
                return ObjectType;
            }
        }
    
    
}
