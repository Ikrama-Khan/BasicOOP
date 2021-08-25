using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOOP.services
{
    public interface ICalculator
    {
        double Value1 { get; set; }
        double Value2 { get; set; }

        void Add();
        double Multiply();
    }

    public interface ICalculator2
    {
        void Division();
    }
}
