using System;
using System.Collections.Generic;
using System.Text;

namespace HW23SOLID.Cars
{
    class Car
    {
        public int Model { get; set; }
        public string Name { get; set; }
        public void createAnewCar()
        {
            Console.WriteLine("Новая машина готова");
        }
    }
    class RossianCar : Car
    {
        public void PoverFulCar()
        {
            Console.WriteLine(" машина готовится");
        }

    }

}
