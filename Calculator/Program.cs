namespace Calculator
{
    internal class Program
    {
         static double number1;
         static double number2;
         static string operation;

        public static void Main(string[] args)
        {
            bool IsCalculatorOn = true;
            Console.WriteLine("SUPER ADVANCED CALCULATOR!!!!!");

            while (IsCalculatorOn)
            {
                number1 = GetNumberInput("Please enter a number");
                number2 = GetNumberInput("Please enter a second number");

                GetOperationInput();

                DoCalculation();

                Console.WriteLine("Type Q to quit or any other input to start a new calculation");
                if (Console.ReadLine().ToLower() == "q") IsCalculatorOn = false; 
                // Type Q or q to break the while loop. Converts Q to lowercase. Any other input loops back to the first number input.
            }
        }

        private static double GetNumberInput(string message)
        {
            double input;

            Console.WriteLine(message);
            while (!double.TryParse(Console.ReadLine(), out input)) 
            { // First number, should loop if not a valid double i.e. letters and symbols.
                Console.WriteLine("Please enter a valid number");
            }
            return input;
        }

        private static void GetOperationInput()
        {
            Console.WriteLine("Please select an operation \n ^ for exponentiation \n / for divison \n * for multiplication \n + for addition \n - for subtraction");
            
            operation = Console.ReadLine();
            while (operation != "/" && operation != "*" && operation != "+" && operation != "-" && operation != "^") 
            { // Loop if not any of the specified options.
                Console.WriteLine("Please enter a valid operation");
                operation = Console.ReadLine();
            }
        }

        private static void DoCalculation()
        {
            double result = 0;

            switch (operation)
            {
                case "/":
                    while (number2 == 0)
                    {
                        number2 = GetNumberInput("You can't divide by zero baka! \nPlease re-enter your second number");
                    }
                    result = number1 / number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "^":
                    result = Math.Pow(number1, number2);
                    break;
            }
            Console.WriteLine($"{number1} {operation} {number2} = {result}");
        }
    }
}