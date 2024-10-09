/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/


//old version

/*namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}*/


//Using variables -- specifically string

/*namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring a variable(string)
            string name;
            
            //assigning value to the variable(string)
            name = "John Franklin";

            //using/acessing the variable
            Console.WriteLine(name);
        }
    }
}*/


//improved version of using and accessing variables

/*namespace improveVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //instead of consuming two lines, it can be written in one line like this.
            string name = "John Franklin";
            Console.WriteLine(name);
        }
    }
}*/


//User input 

using Microsoft.VisualBasic;
using System;

/*namespace userInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //It will show in the console that you need to enter your name
            Console.WriteLine("Enter your name: ");

            //It will store the data what the user will enter
            string userInput = Console.ReadLine();

            //It will show the output -- the name of the user that was entered and greeted with Hello.
            Console.WriteLine("Hello! " + userInput);
        }
    }
}*/


//Data Types

/*namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //reference type
            string name = "John Franklin P. Nieras";
            //value type
            int age = 22;
            float height = 5.711f;
            double pi = 3.14;
            decimal grades = 7.12m;
            //boolean
            bool isTall = true;
            //character
            char gender = 'M';

            Console.WriteLine($"Hello my name is {name}\n My age is {age}\n My gender is {gender}");

            Console.ReadKey();

        }
    }
}*/


//Variable Definition,Initialization and Assigning

/*namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining  the name of the variable
            string phoneName;

            //initializing the variable
            phoneName = "Nokia";
            Console.WriteLine($"My phone is {phoneName}");

            //adding new value
            phoneName = "Redmi";
            Console.WriteLine($"My new phone is {phoneName}");

            Console.ReadKey();
        }
    }
}*/


//Parse Method

/*namespace ParseMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //It will ask the user to enter a number
            Console.WriteLine("Enter a number");

            int myNumber = 0;

            //This will store the data from the input of the user
            string userInput = Console.ReadLine();

            myNumber = int.Parse(userInput);

            //This will show in the console the ouput of what the user input from the question.
            Console.WriteLine($"You've enter {userInput}");
        }
    }
}*/


//Project 1 -- Addition Calculator (integer type)

/*namespace ProjectCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //This will show a welcoming remarks of the calculator at the top of the console
            Console.WriteLine("Welcome to my program calculator");

            //This will put one line of space to make it cleaner in the console app.
            Console.WriteLine();

            //This will allow to have intervals or breaks before proceeding to next execution by entering keys.
            Console.ReadKey();

            //this will initialize the two numbers for addition
            int myNumber = 0;
            int myNumber2 = 0;

            //1. this will show and ask the first number from the user
            Console.WriteLine("Enter the first number: ");

            //2. this will store what the user inputs in the console app.
            string userInput = Console.ReadLine();

            //3. this will convert the string datatypes to integer.
            myNumber = int.Parse(userInput);

            //repeat the 3 steps in making a user input and convert it into an integer.

            //1
            Console.WriteLine("Enter the second number: ");
            //2 -- remove the string data type definition
            userInput = Console.ReadLine();
            //3
            myNumber2 = int.Parse(userInput);

            //sum the two numbers.
            int sum = myNumber + myNumber2;

            //Prints out the result
            Console.WriteLine($"{myNumber} + {myNumber2} = {sum}");

            Console.ReadKey();

            Console.WriteLine("Thank you for using Frank's Calculator");

        }
    }
}*/

//Project 2 -- Addition Calculator (Double type)

/*namespace CalculatorDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome remarks of the calculator
            Console.WriteLine("Welcome to my calculator");
            
            //Enter anykey to keep moving in the calculator
            Console.ReadKey();

            //initializing the number
            double myNumber = 0.0;
            double myNumber2 = 0.0;

            //. Asking the user input to get the first number to be computed
            Console.WriteLine("Enter the first number: ");

            //2. this stores the data from the user input
            string userInput = Console.ReadLine();

            //3. converts the string into double
            myNumber = double.Parse(userInput);

            //Repeat the steps 1-3
            Console.WriteLine("Enter the second number: ");
            userInput = Console.ReadLine();
            myNumber2 = double.Parse(userInput);

            //The process how to add 2 numbers from the users
            double sum = myNumber + myNumber2;

            //Prints the result 
            Console.WriteLine($"{myNumber} + {myNumber2} = {sum}");

            //asks the user to press any key before going out the program
            Console.ReadKey();

            //giving thanks before exit
            Console.WriteLine("Thank you for using Frank's Calculator!");
        }
    }
}*/


//Implicit conversion

//int to double

/*namespace IntToDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variable and assigning the value of the variable
            int myMoney = 123456;
            //implicit conversion from integer to double
            double myDouble = myMoney;

            //we cannot convert long to int or larger variable into small variable because it will caused loss of data.

            Console.WriteLine(myMoney);

            Console.ReadKey();
        
        }
    }
}*/

//float to double

/*namespace FloatToDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            //assigning the value of float
            float myFloat = 123.45678f;

            //convert float to double
            double myDouble = myFloat;

            //print the output(value of float)
            Console.WriteLine(myFloat);

            Console.ReadKey();
        }
    }
}*/


//explicit conversion

/*namespace DoubleToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing integers in variable myInt
            int myInt;

            //assigning value in double and giving value to the double
            double myDouble = 123.3456;

            //casting double to int
            myInt = (int)myDouble;

            //output will just gonna be 123 because int is only for whole numbers.
            Console.WriteLine(myInt);


        }
    }
}*/

//double to float

/*namespace DoubleToFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            float myFloat;

            double myDouble = 12345.134312;

            myFloat = (float)myDouble;

            Console.WriteLine(myFloat);
        }
    }
}*/



//Parse helpers

/*namespace ParseHelpers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string to int

            //assign value in variable(myNumbers) in the data type(string)
            string myNumbers = "12345";

            //converting by parsing(string to integer)
            //int myResults = int.Parse(myNumbers);

            //another way of conversion from string into integer.
            int myResults = Convert.ToInt32(myNumbers);

            //prints out the string into an integer without changing the value of the variable(string) into a string
            Console.WriteLine($"My interger is {myNumbers}");



            //string to float

            //assigning value in string 
            string myFloatString = "1234.456";

            //Conversion of float to 
            //float myFloat = Convert.ToSingle(myFloatString);

            //another way of conversion from string to float
            float myFloat = float.Parse(myFloatString);

            //prints out the output
            Console.WriteLine($"My float is {myFloat}");



            //string into bool

            //assign the value of variable(myBool) in the date type(string)
            string myBool = "true";

            //convert by parsing (string to bool)---
            //bool myResult1 = bool.Parse(myBool);

            //another way of conversion from string to a bool data type
            bool myResult1 = Convert.ToBoolean(myBool);

            //prints out the string into a boolean without changing the value of it as a string.
            Console.WriteLine($"My boolean is {myResult1}");
        }
    }
}*/


//Implicitly Typed Variables vs. Explicitly type variables

/*namespace ImplicitVsExplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            //using var and understand by the system as a string by the value that I input here.
            var name = "John Franklin";

            Console.WriteLine($"My name is {name}");

            //using var and understand by the system as int by giving the value int.
            var myNumber = 12;

            var myNumber1 = 10;

            //process of adding all numbers
            //int totalNumber = myNumber + myNumber1;

            //another way of adding all numbers using var instead of int
            var totalNumber = myNumber + myNumber1;

            Console.WriteLine($"The total number is {totalNumber}");
        }
    }
}*/


//CAlculator

using System;

/*class SimpleCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Simple Calculator!");

        while (true)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            // Exit the loop if the user chooses to exit
            if (choice == "5")
            {
                Console.WriteLine("Thank you and Goodbye!");
                break;
            }

            Console.Write("Enter the first number: ");
            float num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter the second number: ");
            float num2 = Convert.ToSingle(Console.ReadLine());

            float result = 0;

            if (choice == "1") // Addition
            {
                result = num1 + num2;
                Console.WriteLine("Result: " + num1 + " + " + num2 + " = " + result);
            }
            else if (choice == "2") // Subtraction
            {
                result = num1 - num2;
                Console.WriteLine("Result: " + num1 + " - " + num2 + " = " + result);
            }
            else if (choice == "3") // Multiplication
            {
                result = num1 * num2;
                Console.WriteLine("Result: " + num1 + " * " + num2 + " = " + result);
            }
            else if (choice == "4") // Division
            {
                if (num2 != 0) // Check for division by zero
                {
                    result = num1 / num2;
                    Console.WriteLine("Result: " + num1 + " / " + num2 + " = " + result);
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
            }
            else // Invalid choice
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine(); // Add an empty line for better readability
        }
    }
}*/


//String Manipulation and string formatting -- 2 class in 1 namespace

/*namespace StringM
{
    class Concatenation
    {
        public void DisplayMessage()
        {
            string name = "John";
            int age = 22;
            bool isTall = true;
            char gender = 'M';
            float grade = 90.77f;

            Console.WriteLine("My name is " + name);
            Console.WriteLine("My age is " + age);
            Console.WriteLine("Am I tall? " + isTall);
            Console.WriteLine("My gender is " + gender);
            Console.WriteLine("My grade is " + grade);
        }
    }

    class Interpolation
    {
        public void DisplayMessage()
        {
            string name = "John";
            int age = 22;
            bool isTall = true;
            char gender = 'M';
            float grade = 90.77f;

            Console.WriteLine($"Hello my name is {name}\n I am {age} years old \n Am I tall? {isTall} \n My gender is {gender} \n My grade is {grade}");
        }
    }

    class Program
    {
        static void Main()
        {
            Concatenation concat = new Concatenation();
            concat.DisplayMessage();

            Interpolation interp = new Interpolation();
            interp.DisplayMessage();
        }
    }
}*/

//String Formatting

/*namespace StringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Frank";
            int age = 22;
            double grade = 90.777;

            //uses string formatting
            Console.WriteLine("My name is {0} \n My age is {1} \n My grades is {2}", name,age,grade);
        }
    }
}*/

//how to use special characters

/*namespace SpecialChar
{
    class Program
    {
        static void Main(string[] args)
        {
            //using the backslash to include the "" in ACES and flash the backslash through double backslash.
            string sentenceBuild = "Thank you \"ACES\" for accepting me even I am a \\ fresh grad";

            Console.WriteLine(sentenceBuild);

            Console.ReadKey();
        }
    }
}*/

/*Create a simple C# program that prints a string containing special characters and uses escape sequences. The output should display the string with a newline and a tab character.

Alert!

The result of execution for the default string should be:

Hello
    World!*/

//Answer to question

/*namespace BackSlash
{
    class Program
    {
        static void Main(string[] args)
        {
            string greet = "Hello\n\tWorld";
            Console.WriteLine(greet);
        }
    }
}*/

