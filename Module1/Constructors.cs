using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    public class Trainer
    {
        int EmpId;
        string EmpName;
        string Technology;


        // Defauolt Constructor
        public Trainer()
        {
            EmpId = 0;
            EmpName = null;
            Technology = null;

        }


        // Parameterized Constructor
        public Trainer(int id, string name, string tech)
        {
            EmpId = id;
            EmpName = name;
            Technology = tech;
        }

        public void display()
        {
            Console.WriteLine("EmpId: " + EmpId);
            Console.WriteLine("EmpName: " + EmpName);
            Console.WriteLine("Technology: " + Technology);
            Console.WriteLine("\n");
        }

    }
}
