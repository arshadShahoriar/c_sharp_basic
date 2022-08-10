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

            if ((input.ToLower() == "true") || (input.ToLower() == "false"))
            {
                if (input.ToLower() == "true")
                    boolenType = true;
                else if (input.ToLower() == "false")
                    boolenType = false;

                Console.WriteLine($"your input is {boolenType} ");
            }
            else
            {
                Console.WriteLine("Invalid input");

            }




            //int
            Console.WriteLine("Input an Integer value");
            int intInput= int.Parse(Console.ReadLine());
            Console.WriteLine($"your input is {intInput} ");


            //float
            Console.WriteLine("Input an Float value");
            var floatInput= float.Parse(Console.ReadLine());
            Console.WriteLine($"your input is {floatInput} ");


            //char

            Console.WriteLine("Input an Charecter value");
            char charInput = char.Parse(Console.ReadLine());
            Console.WriteLine($"your input is {charInput} ");


            //long 
            Console.WriteLine("Input an Long value");
            long longInput = long.Parse(Console.ReadLine());
            Console.WriteLine($"your input is {longInput} ");

            //double
            Console.WriteLine("Input an double value");
            double doubleInput = double.Parse(Console.ReadLine());
            Console.WriteLine($"your input is {doubleInput} ");


        }
    }
}
