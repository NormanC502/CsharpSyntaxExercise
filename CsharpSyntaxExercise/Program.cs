using System;

namespace CsharpSyntaxExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            // Given the following code, change the code to implement inferred typing, string interpolation, and the ternary operator
            //int answer = 4;
            //string response;

            //if (answer < 9)
            //{
            //response = answer + " is less than nine";
            //}
            //else
            //{
            //response = answer + “greater than or equal to nine”;
            //}



            int answer = 4;          
            string response = (answer < 9) ? $"{answer}Is less than nine" : $"{answer}Greater than or equal to nine";
            Console.WriteLine(response);

           
                         
        }
    }
}
