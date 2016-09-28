using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication2.Classes
{
    public class Team
    {
        TeamLeader one = new TeamLeader();
        Worker two = new Worker();
        public void Engage(House obj)
        {
           one.Work(obj);
           two.Work(obj);
        }
    }
}
