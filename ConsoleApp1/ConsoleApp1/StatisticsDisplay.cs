using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StatisticsDisplay : Observer
    {
        public StatisticsDisplay(Subject subcjet) 
        {
            this.subject = subcjet;
            this.subject.Attach(this);
        }
        public override void Update()
        {
            Console.WriteLine("Update: " + this.subject.GetState());
        }
        public void displayStats()
        {
            Console.WriteLine("diplayStats");
        }
    }
}
