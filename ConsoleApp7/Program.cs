using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Voornaam = "Wim";

            Console.WriteLine(person.Voornaam);
        }
    }
}
