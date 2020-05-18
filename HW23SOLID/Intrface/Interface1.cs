using System;
using System.Collections.Generic;
using System.Text;

namespace HW23SOLID.Intrface
{
    interface INewCar
    {
        public void WorkonTask();
    }
    interface IManager
    {
        public void GiveTask(Programmer p, string Task);
        public void CreateTasks();
    }

    public class Programmer : INewCar
    {
        public string Task { get; set; }
        public void WorkonTask()
        {
            Console.WriteLine("Работа над " + Task);
        }
    }
    public class Maneger : INewCar, IManager
    {
        public void WorkonTask()
        {
            Console.WriteLine("Работать над задачкой");
        }
        public void GiveTask(Programmer p, string Task)
        {
            Console.WriteLine("Дать задание");
            p.Task = Task;
        }
        public void CreateTasks()
        {
            Console.WriteLine("Создание задачки");
        }
       
      
    }
}
