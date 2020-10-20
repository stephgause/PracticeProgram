using System;

namespace PracticeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            OperatorExamples();
        }

        static void OperatorExamples()
        {
            // declares variale and sets it to 3
            int width = 3;

            //++ operator increments a variable (adds 1 to it)
            width++;

            //Calculations
            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            //Declaring string variables and using + to concatenate them (join them)
            string result = "The Area";
            result = result + "is" + area;
            Console.WriteLine(result);

            //A boolean variable is either true or false
            bool truthValue = true;
            Console.WriteLine(truthValue);

            //While loop
            int count = 5;
            while (count > 0)
            {
                count = count * 3;
                count = count * -1;

            }

            //for loop
            int j = 2;
            for (int i =1; i < 100; i = i * 2)
            {
                j = j - 1;
                while (j < 25)
                {
                    j = j + 5;
                }
            }
            
            int Number = 0; 
            while (Number++ < 50)
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine(Number + 15);
                }
                
            }
        }
    }
}
