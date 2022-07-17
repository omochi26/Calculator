namespace Calculator
{
    internal class Program
    {
         static double num1;
         static double num2;
         static string operation;

        public static void Main(string[] args)
        {
            bool IsCalculatorOn = true;
            Console.WriteLine("SUPER ADVANCED CALCULATOR!!!!!");

            while (IsCalculatorOn)
            {
                num1 = GetNumberInput("Please enter a number");
                num2 = GetNumberInput("Please enter a second number");

                GetOperationInput();

                Calculation();

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

        private static void Calculation()
        {
            double result = 0;

            switch (operation)
            {
                case "/":
                    while (num2 == 0)
                    {
                        num2 = GetNumberInput("You can't divide by zero baka! \nPlease re-enter your second number");
                    }
                    result = num1 / num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "^":
                    result = Math.Pow(num1, num2);
                    break;
            }
            Console.WriteLine($"{num1} {operation} {num2} = {result}");
        }
    }

}