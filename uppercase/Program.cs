using System;

namespace uppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring = "I am eating dinner now";
            mystring = mystring.ToUpper();
            Console.WriteLine(mystring);
            Console.ReadLine();

        }
    }
}
