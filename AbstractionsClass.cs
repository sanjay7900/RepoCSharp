using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOfCSharp
{
    public abstract class AbstractionsClass 
    {
        public abstract void userinfo();
        public  void Perform_abstractions(String name="sanjau")
        {
            Console.WriteLine(" without without Abstraction keyword  ({0})   and Also Default Argument ", name);
        }
       
    }
}
