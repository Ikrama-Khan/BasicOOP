using System;
using BasicOOP.classes;

namespace BasicOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Msg1" , "This is a actual value now");

            var msg = person.HelloWorld();
            Console.WriteLine(msg);


            Console.ReadKey();
        }
    }
}
