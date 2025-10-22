using System;

namespace BasicCSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Task 1: Output Statements
          

            Console.WriteLine("Hello, my name is Max.");
            Console.WriteLine("My favorite color is cyan");
            Console.WriteLine(); // Blank line for readability


            
            // Task 2: Comments
            

            // This is a single-line comment explaining that we are using Console.WriteLine for output

            /* 
             * This is a multi-line comment.
             * It can span multiple lines and is useful for longer explanations.
             */


            
            // Task 3: Variables and Data Types


            string personName = "Will";          // string variable to store a name
            long cityPopulation = 51559;        // long variable for population
            double temperatureCelsius = 23.5;     // double variable for temperature
            bool isStudent = true;                // bool variable to represent if the person is a student

            Console.WriteLine($"The person's name is {personName}.");
            Console.WriteLine($"The population of the city is {cityPopulation:N0}");
            Console.WriteLine($"The temperature is {temperatureCelsius} degrees Celsius");
            Console.WriteLine($"Is the person a student? {isStudent}");
            Console.WriteLine();


            
            // Task 4: Constants
            

            const double Pi = 3.14159;   // Constant for Pi
            double radius = 13;
            double area = Pi * radius * radius;

            Console.WriteLine($"The area of a circle with radius {radius} is {area}");
            Console.WriteLine();


            
            // Task 5: Typecasting and if-else
            

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);  // Typecasting string to int

            Console.WriteLine($"Hello {userName}");

            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }

            Console.WriteLine();


           
            // Task 6: Switch Statement
           

            Console.Write("Enter number 1: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 2: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1 = Addition");
            Console.WriteLine("2 = Subtraction");
            Console.WriteLine("3 = Multiplication");
            Console.WriteLine("4 = Division");
            Console.Write("Enter your choice (1-4): ");

            int choice = Convert.ToInt32(Console.ReadLine());
            double result = 0;

            switch (choice)
            {
                case 1:
                    result = number1 + number2;
                    Console.WriteLine($"The result of addition is {result}");
                    break;
                case 2:
                    result = number1 - number2;
                    Console.WriteLine($"The result of subtraction is {result}");
                    break;
                case 3:
                    result = number1 * number2;
                    Console.WriteLine($"The result of multiplication is {result}");
                    break;
                case 4:
                    if (number2 != 0)
                        result = number1 / number2;
                    else
                        Console.WriteLine("Division by zero is not allowed!");
                    Console.WriteLine($"The result of division is {result}");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
                    break;
            }

            Console.WriteLine("\nProgram execution completed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}

