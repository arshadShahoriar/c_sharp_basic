using System;

namespace c_sharp_basic 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new assignment();

            //hello world
           obj.helloWorld();

            //primitive data type printing

           obj.printPrimitiveType();
            //checked exception
            obj.checkedException();
            // type convertion
            obj.typeConvertion();

           
           
        }
    }
}