using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CurrentConditions : Observer
    {
        
        public CurrentConditions(Subject subject) 
        {   
            this.subject = subject;
            this.subject.Attach(this);
        }
        public void Display()
        {
            Console.WriteLine("Display");
        }
        public override void Update()
        {
            Console.WriteLine("Updated: " + subject.GetState());
        }

    }
}
