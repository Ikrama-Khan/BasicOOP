using System;
using System.Collections.Generic;
using System.Text;
using BasicOOP.services;

namespace BasicOOP.classes
{
    class Calculator : ICalculator, ICalculator2
    {
        private double V1, V2;

        public double Value1
        {
            get => V1;
            set => V1 = value;
        }
        public double Value2
        {
            get => V2;
            set => V2 = value;
        }

        public void Add() => Console.WriteLine($"Addition: {Value1 + Value2}");

        public double Multiply() => Value1 * Value2;

        public void Division() => Console.WriteLine($"Division: {Value1 / Value2}");
    }
}
