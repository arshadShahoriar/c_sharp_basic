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


        public void checkedException() {

            Console.WriteLine("checked keyword exception checked");
            checked
            {
                // assigned maximum value to intValue variable
                int intValue = int.MaxValue;
                Console.WriteLine($"Maximum value {intValue} is assigned to intValue variable ");

                try
                {
                    //increment +1 for overflow stage
                    Console.WriteLine($"post increment +1 for overflow stage {++intValue}");

                }catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                }


            }
        }

        public void typeConvertion()
        {
                // string to int
                Console.WriteLine("input a string for string to integer converation ");
                string str = Console.ReadLine();
                int intValue=0;

                if(int.TryParse(str,out intValue))
                {
                    intValue = int.Parse(str);
                    Console.WriteLine($"The following int value is: {intValue}");

                    //int to string
                    Console.WriteLine("vice versa: Integer to string...... ");
                    str = intValue.ToString();
                    Console.WriteLine($"The resulted string value is: {str}");
                 }
                else
                {
                    Console.WriteLine($"This typecasting is Invalid for {str}");

                }  



                // string to long
                Console.WriteLine("input a string  for string to long type converation ");

                 str = Console.ReadLine();
                long longValue = 0;

                if (long.TryParse(str, out  longValue))
                {
                    longValue = long.Parse(str);
                    Console.WriteLine($"The following long value is: {longValue}");
                    // vice versa: long to string
                    Console.WriteLine("vice versa: Long to string...... ");
                    str = longValue.ToString();
                    Console.WriteLine($"The resulted string value is: {str}");
            }
                else
                {
                    Console.WriteLine($"This typecasting is Invalid for {str}");

                }

               

     

      
               //string to double
                Console.WriteLine("input a string  for string to double type converation ");
                 str = Console.ReadLine();
                double doubleValue = 0;

                if (double.TryParse(str, out doubleValue))
                {
                    doubleValue = double.Parse(str);
                    Console.WriteLine($"The following double value is: {doubleValue}");

                //vice versa: double to string
                Console.WriteLine("vice versa: double to string...... ");
                str = doubleValue.ToString();
                Console.WriteLine($"The following string value is: {str}");
            }
                else
                {
                    Console.WriteLine($"This typecasting is Invalid for {str}");

                }

                 


                // string to float
                Console.WriteLine("input a string  for string to float type converation ");
                 str = Console.ReadLine();
                float floatValue = 0;

                if (float.TryParse(str, out floatValue))
                {
                    floatValue = float.Parse(str);
                    Console.WriteLine($"The following float value is: {floatValue}");
                //vice versa: float to string
                Console.WriteLine("vice versa: float to string...... ");
                str = floatValue.ToString();
                Console.WriteLine($"The following string value is: {str}");
            }
                else
                {
                    Console.WriteLine($"This typecasting is Invalid for {str}");

                }

             

                
                // string to boolen
                Console.WriteLine("input a string  for string to bool type converation ");
                 str = Console.ReadLine();
                bool boolValue;

                if (bool.TryParse(str, out boolValue))
                {
                    boolValue = bool.Parse(str);
                    Console.WriteLine($"The following boolen value is: {boolValue}");
                // vice versa: boolen to string
                Console.WriteLine("vice versa: boolen to string...... ");
                str = boolValue.ToString();
                Console.WriteLine($"The following string value is: {str}");
            }
                else
                {
                    Console.WriteLine($"This typecasting is Invalid for {str}");

                }

              
     
                 //int to long

                Console.WriteLine("input a int  for int to long type converation ");
                 

                 longValue = 0;
                try
                {
                intValue = int.Parse(Console.ReadLine());
                longValue = Convert.ToInt64(intValue);
                     Console.WriteLine($"The following integer value is: {longValue}");
                //vice versa: long to int
                Console.WriteLine("vice versa: long to int...... ");
                intValue = Convert.ToInt32(longValue);
                Console.WriteLine($"The following integer value is: {intValue}");
            }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               

           

                
                
                //char to Ascii 
                Console.WriteLine("input a character   for char to Ascii Integer type converation ");
                string alphabet = Console.ReadLine();
                
                
                string finalValue;
                byte  bytes= Encoding.Default.GetBytes(alphabet)[0];
                finalValue=  bytes.ToString("X");
                Console.WriteLine(finalValue);

                // vice versa: Asccii to char
                alphabet = "";
                Console.WriteLine("vice versa: Ascii to char...... ");
                alphabet = char.ConvertFromUtf32(bytes);
             
                Console.WriteLine($"The following char value is: {alphabet}");

        }

        public void generalOperation() {
            // with the three subject marks , we have done different artithmatic expression
            var bangla = 90.0;
            var english = 80.0;
            var physics = 85.0;

            var maximumMarks = 3 * 100;
            var totalmarks= bangla+english+physics;

            Console.WriteLine("total marks obtain "+totalmarks);

            Console.WriteLine($"lacks of marks {maximumMarks-totalmarks}");
            Console.WriteLine($"Average marks {totalmarks / 3.0}");


            if ((totalmarks % 2) == 0)
            {
                Console.WriteLine("Obtain marks is even");
            }
            else
            {
                Console.WriteLine("Obtain marks is odd");
            }

            var chemistry = 80 | 90;
            var biology = 50 & 60;


            Console.WriteLine($" chemistry + biology = {chemistry+biology}");
            Console.WriteLine($"5^2 ={5^2} ");
        
        
        }

        public void conditionExpression() {

            Console.WriteLine("input a number range between 1-100");
            var intValue= int.Parse(Console.ReadLine());

            if (intValue > 100)
            {
                Console.WriteLine("Invalid marks");
            }else if(intValue < 0)
            {
                Console.WriteLine("Invalid marks");
            }
            else
            {
                Console.WriteLine("valid marks");
            }
        }

        public void muultiLineConditionExpression()
        {
            Console.WriteLine("input a number range between 1-100");
            var intValue = int.Parse(Console.ReadLine());

            if ((intValue <= 100) && (intValue >= 0))
            {
                Console.WriteLine("valid marks");

                if ((intValue >= 90) || (intValue >= 89))
                {
                    Console.WriteLine("A+");
                }
                else
                {
                    Console.WriteLine("other grade");
                }
            }
            else
                Console.WriteLine("Invalid marks");
            
           

        }

        public void ternaryLogicOperation() {

            int a, b;
            a= int.Parse(Console.ReadLine()) ;

            //a<100 will results 0

            b = (a >= 100 ) ? 100 : 0;
            Console.WriteLine("Value of b is {0}", b);


        }


        public void differentTypesOfComment()
        {

        }

        public void skip95AndBreaksAt99()
        {

        }

        public void switchCases() {  }

    }
}
