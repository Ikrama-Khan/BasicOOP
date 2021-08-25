using System;
using BasicOOP.services;
using BasicOOP.classes;

namespace BasicOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator
            {
                Value1 = 10,
                Value2 = 2
            };

            calculator.Add();
            Console.WriteLine($"Multiply :{calculator.Multiply()}");
            calculator.Division();
            //ICalculator2 calculator2 = new Calculator();

            //calculator2.Division();

            //var person = new Person("Msg1" , "This is a actual value now");

            //var msg = person.HelloWorld();
            //Console.WriteLine(msg);

            Console.ReadKey();
        }
    }
}
