using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    public class Access_Modifiers
    {

        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }

    }
}
