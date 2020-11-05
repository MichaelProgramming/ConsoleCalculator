using System;

namespace Calcu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program variables
            string calculationType;

            int firstInputRequest = 1; // Used to customise prompts for first and second number input from user
            int secondInputRequest = 2; // Used to customise prompts for first and second number input from user
            float userFirstNumberInput, userSecondNumberInput, calculationResult;
          
            bool startAgain = true;

            // Main process
            while (startAgain == true)
            {
                // Get type of calculation from user
                calculationType = GetCalculationType();
                // Get first number input from user
                userFirstNumberInput = GetNumber(firstInputRequest);
                // Get second number input from user
                userSecondNumberInput = GetNumber(secondInputRequest);
                // Perform calculation and display results
                PerformCalculation();
                // Ask user if they want to start again
                StartAgain();
            }

            // Prompt user to enter a calculation type, get input and check input is valid
            string GetCalculationType()
            {
                // Method variables
                bool validCalculationType = false;
                string userCalculationTypeInput = " ";

                Console.WriteLine("Choose calculation type (+, -, *, /)");

                // Check for valid user input
                while (!validCalculationType)
                {
                    userCalculationTypeInput = Console.ReadLine();

                    if (userCalculationTypeInput == "+" || userCalculationTypeInput == "-" || userCalculationTypeInput == "*" || userCalculationTypeInput == "/")
                    {
                        validCalculationType = true;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                return userCalculationTypeInput;
            }

            // Prompt user to input a number, get input and check it is valid
            float GetNumber(int inputRequest)
            {
                // Method variables
                bool validNumber = false;
                float userNumberInput = 0;

                // Prompt user for input
                if (inputRequest == 1)
                {
                    Console.WriteLine("Enter first number");
                }
                else if (inputRequest == 2)
                {
                    Console.WriteLine("Enter second number");
                }

                // Check for valid user input
                while (!validNumber)
                {
                    if (float.TryParse(Console.ReadLine(), out userNumberInput))
                    {
                        
                        validNumber = true;
                    }
                    else
                    {
                        
                        Console.WriteLine("Try again");
                    }
                }
                return userNumberInput;
            }

            // Use previous inputs to perform calculations and call to display results
            void PerformCalculation()
            {
                if (calculationType == "+")
                {
                    calculationResult = userFirstNumberInput + userSecondNumberInput;
                    DisplayCalc();
                }
                else if (calculationType == "-")
                {
                    calculationResult = userFirstNumberInput - userSecondNumberInput;
                    DisplayCalc();
                }
                else if (calculationType == "*")
                {
                    calculationResult = userFirstNumberInput * userSecondNumberInput;
                    DisplayCalc();
                }
                else if (calculationType == "/")
                {
                    calculationResult = userFirstNumberInput / userSecondNumberInput;
                    DisplayCalc();
                }
            }

            // Display results of calculations
            void DisplayCalc()
            {
                Console.WriteLine($"{userFirstNumberInput} {calculationType} {userSecondNumberInput} = {calculationResult}");
            }

            // Ask user if they want to perform another calculation
            void StartAgain()
            {
                bool validYesOrNo = false;
                string userYesOrNoInput = " ";

                Console.WriteLine("Try again? (y or n)");

                while (!validYesOrNo)
                {
                    userYesOrNoInput = Console.ReadLine();

                    if (userYesOrNoInput == "y" || userYesOrNoInput == "n")
                    {
                        validYesOrNo = true;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }

                if (userYesOrNoInput == "n")
                {
                    startAgain = false;
                    Console.WriteLine("Bye");
                }
            }
        }
    }
}
