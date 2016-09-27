using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Interfaces;

namespace ConsoleApplication2.Classes
{
    class Worker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("I am working");
        }
    }
}
