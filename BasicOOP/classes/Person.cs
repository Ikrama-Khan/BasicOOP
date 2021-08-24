using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOOP.classes
{
    class Person
    {
         string Msg1 { get; set; }

         string Msg2 { get; set; }

        public Person(string msg1, string msg2 = "This is an optional param")
        {
            Msg1 = msg1;
            Msg2 = msg2;
        }

        public bool HelloWorld()
        {
            var name = "AIJAZ ALI ABRO";

            return name.Equals("aijaz ali abro", StringComparison.OrdinalIgnoreCase);

           // return $"{Msg1} {Msg2}";
        }

        

        //public string Show(byte a, bool b)
        //{
        //    return string.Empty;
        //}

        //public string Show(int s)
        //{
        //    return "";
        //}

    }
}
