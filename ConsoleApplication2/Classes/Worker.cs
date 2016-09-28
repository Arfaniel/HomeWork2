using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ConsoleApplication2.Interfaces;

namespace ConsoleApplication2.Classes
{
    public class Worker : IWorker
    {
        public void Work(House obj)
        {
            Console.WriteLine("I am working");
            obj.Build(obj.Project[0]);
            Thread.Sleep(1000);
            Console.WriteLine("I am done");
        }
    }
}
