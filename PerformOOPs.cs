using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOfCSharp
{
    public class PerformOOPs : IPerformOverRide
    {
       public PerformOOPs()
        {
            Console.WriteLine(" Im Initlized");
        }
        public int sum(int a,int b)
        {
            return a + b;
        }
        public double sum(double a,double b)
        {
            return a + b;

        }

        public void JustOverRide()
        {
            Console.WriteLine(" i m called for the override ok ");
        }

        
        //void IPerformOverRide.JustOverRide()
        //{
        //    throw new NotImplementedException();
        //}

        ~PerformOOPs()
        {
            Console.Write("i m destroyed");
        }

    }
}
