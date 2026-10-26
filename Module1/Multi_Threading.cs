using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    internal class Multi_Threading
    {

        public void M1()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("M1 Thread {0}", i);
            }
        }

        public void M2()
        {
            for (int i = 0; i < 150; i++)
            {
                Console.WriteLine("M2 Thread {0}", i);
            }
        }

        public void M3()
        {
            for (int i = 0; i < 1500; i++)
            {
                Console.WriteLine("M3 Thread {0}", i);
            }
        }

    }
}
