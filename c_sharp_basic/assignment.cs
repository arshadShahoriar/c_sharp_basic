using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_basic
{
    internal class assignment
    {
        public void helloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        public void printPrimitiveType() {

            //string
            string x;
            Console.WriteLine("Input a string");
            x=Console.ReadLine();
            Console.WriteLine(x);


            //boolen input
            Console.WriteLine("Input a true/false for boolen type");
            bool boolenType=true;
            string input;
            input= Console.ReadLine();

            if (input.ToLower() == "true")
                boolenType = true;
            else if (input.ToLower() == "false")
                boolenType = false;
            else
                Console.WriteLine("Invalid input");


            Console.WriteLine($"your input is {boolenType} ");


            //int


            var intInput=Console.ReadLine();
            Console.WriteLine($"your input is {intInput} ");


            //float

            var floatInput=Console.ReadLine();
            Console.WriteLine($"your input is {floatInput} ");


            //char

            var charInput = Console.ReadLine();
            Console.WriteLine($"your input is {charInput} ");


            //long 
            charInput = Console.ReadLine();
            Console.WriteLine($"your input is {charInput} ");

            //double
            charInput = Console.ReadLine();
            Console.WriteLine($"your input is {charInput} ");


        }
    }
}
