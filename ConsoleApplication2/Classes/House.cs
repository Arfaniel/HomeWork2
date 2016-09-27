using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Interfaces;

namespace ConsoleApplication2.Classes
{
    class House: IPart
    {
        private object[] parts = new object[11];
        private int partCounter = 0;
        private List<string> Project = new List<string> { "Basement", "Wall", "Wall", "Wall", "Wall", "Window", "Door", "Roof" };
        private void Build(string somepart)
        {
            if (partCounter <= parts.Length)
            {
                switch (somepart)
                {
                    case "Basement":
                        parts[partCounter] = new Basement();
                        Project.RemoveAt(partCounter);
                        partCounter++;
                        break;
                    case "Wall":
                        parts[partCounter] = new Wall();
                        Project.RemoveAt(partCounter);
                        partCounter++;
                        break;
                    case "Window":
                        parts[partCounter] = new Window();
                        Project.RemoveAt(partCounter);
                        partCounter++;
                        break;
                    case "Door":
                        parts[partCounter] = new Door();
                        Project.RemoveAt(partCounter);
                        partCounter++;
                        break;
                    case "Roof":
                        parts[partCounter] = new Roof();
                        Project.RemoveAt(partCounter);
                        partCounter++;
                        break;
               }
            }
            else
            {
                Console.WriteLine("This house is done");
            }
        }
        public void Do()
        {
            Build(Project[partCounter]);
        }
        public string Show()
        {
                return parts.ToString();
        }
        public bool isDone()
        {
            if (partCounter == parts.Length)
                return true;
            else
                return false;
        }
    }
}
