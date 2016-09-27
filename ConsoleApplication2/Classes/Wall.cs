using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Interfaces;

namespace ConsoleApplication2.Classes
{
    class Wall : IPart
    {
        private bool isdone = false;

        public void Do()
        {
            isdone = true;
        }

        public bool isDone()
        {
            return isdone;
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
