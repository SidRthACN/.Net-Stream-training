namespace Module1
{

    public class datatypes
    {
        public datatypes()
        {
            Console.WriteLine("Constructor Called for class datatypes");
        }


        public void display()
        {
            int a = 10;
            Console.WriteLine("This is a integer variable " + a);

            float b = 20.5f;
            Console.WriteLine("This is a float variable " + b.ToString("F3"));
        }
    }

}

    
