using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ForecastDisplay : Observer
    {
        public ForecastDisplay(Subject subject) 
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override void Update()
        {
            Console.WriteLine("updated: " + this.subject.GetState());
        }
        public void displayPredicts()
        {
            Console.WriteLine("diplayPredicts");
        }
    }
}
