using HW23SOLID.Auto;
using HW23SOLID.Cars;
using HW23SOLID.Intrface;
using HW23SOLID.Model;
using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;
namespace HW23SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAllNamesCar(new List<object>() { new auto { Id = 1, Name = "Jiguli", }, new Models { Id = 1, model = "Vaz 2111", SummaAuto = "7000$ " } });
            Car car1 = new Car { Model = 2111, Name = "Jiguli" };
            RossianCar car2 = new RossianCar{ Model = 2106, Name = "Jiguli" };
            car1.createAnewCar();
            car2.PoverFulCar();
            Programmer Car = new Programmer();
            Maneger Lenin = new Maneger();
            Lenin.CreateTasks();
            
        }
        static void GetAllNamesCar(List<object> obj)
        {
            foreach (var item in obj)
            {
                if (item is auto)
                {
                    auto p = item as auto;
                    Console.WriteLine("Auto:" + p.Name);
                }
                if (item is Models)
                {
                    Models c = item as Models;
                    Console.WriteLine("Models:" + c.model, c.SummaAuto);
                }
            }
        }
    }
   
    
    
  
}
