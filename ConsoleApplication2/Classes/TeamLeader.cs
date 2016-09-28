using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Interfaces;

namespace ConsoleApplication2.Classes
{
    public class TeamLeader : IWorker
    {
        public void Work(House obj)
        {
            if(obj.partCounter>0)
            {
                Console.WriteLine("IS DONE:");
                obj.Show();
            }
            Console.WriteLine("TODO:");
            for (int i = 0; i < obj.Project.Count; i++)
            {
                Console.WriteLine(obj.Project[i]);
            }
        }
    }
}
