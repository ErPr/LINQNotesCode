using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Querying related
            Querying.Notes();
            Querying.BirdNotes();
            Console.ReadLine();
        }
    }

    class FunctionalProgrammingProgram
    {
        delegate void SayGreeting(string name);  //defines method without giving it any functionality
                                                 //like a blueprint or signature
                                                 //describes what it will do, not how

        //public static void SayHello(string name)
        //{
        //    Console.WriteLine(string.Format("Hello, {0}", name));
        //}

        public static void SayGoodbye(string name)
        {
            Console.WriteLine(string.Format("Later, {0}", name));
        }

        static void Main(string[] args)
        {
            //SayGreeting sayGreeting = new SayGreeting(SayHello);
            SayGreeting sayGreeting = delegate (string name) //anonymous method, a method that doesn't have a name. functionality is defined as we assign it to the delegate
            {
                Console.WriteLine(string.Format("Hello, {0}", name));
            };
            Console.WriteLine("What's your name? ");
            string input = Console.ReadLine();
            sayGreeting(input);

            Console.ReadLine();

            sayGreeting = new SayGreeting(SayGoodbye);
            sayGreeting(input);

            Console.ReadLine(); //used to wait before closing CLI
        }
    }
}
