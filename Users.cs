using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOfCSharp
{
    internal class Users:AbstractionsClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Users(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override void userinfo()
        {
            Console.WriteLine(" i m invoke for the About user info => {0},{1}  using Abstraction method",Name,Age);
        }
        public void GetUserDetails()
        {
            Console.WriteLine(" User Name: {0}, User Age: {1}", Name, Age);
        }
    }
}
