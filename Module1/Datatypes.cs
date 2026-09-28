namespace Module1
{

    public class datatypes
    {
        // types of data types in C#
        /* There are two types of data types in C#:
         1) Value Types
         2) Reference Types
        */

        // Value types
        public void display()
        {
            Console.WriteLine("Value Types in C#");
            Console.WriteLine("1) int");
            Console.WriteLine("2) float");
            Console.WriteLine("3) double");
            Console.WriteLine("4) char");
            Console.WriteLine("5) bool");
            Console.WriteLine("6) struct");
            Console.WriteLine("7) enum");
            Console.WriteLine("Reference Types in C#");
            Console.WriteLine("1) string");
            Console.WriteLine("2) object");
            Console.WriteLine("3) class");
            Console.WriteLine("4) interface");
        }


        // struct

        public struct Coordinate
        {
            public int x;
            public int y;

            
            public void assing()
            {
                this.x = 0;
                this.y = 0; 
            }

            public void assign(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void display()
            {
                Console.WriteLine("Coordinate: ({0}, {1})", x, y);
            }

        }



    }

}

    
