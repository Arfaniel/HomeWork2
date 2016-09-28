using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Classes;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            House one = new House();
            Team builders = new Team();
            builders.Engage(one);
            builders.Engage(one);
        }
    }
}
