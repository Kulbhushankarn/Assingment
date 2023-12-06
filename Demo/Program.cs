using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sample Input code");
        Console.WriteLine("Press 'I' for addition and 'O' for subtraction. Press 'Q' to quit.");

        char operationSymbol = '+';

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Q)
            {
                break;
            }

            switch (keyInfo.Key)
            {
                case ConsoleKey.I:
                    operationSymbol = '+';
                    break;

                case ConsoleKey.O:
                    operationSymbol = '-';
                    break;

                default:
                    
                    Console.WriteLine($"Ignoring key '{keyInfo.Key}'. Press 'I', 'O', or 'Q'.");
                    continue;
            }

            Console.WriteLine($"Operation set to {operationSymbol}. Press 'Enter' to perform the operation.");

            
            while (true)
            {
                ConsoleKeyInfo enterKeyInfo = Console.ReadKey(true);

                if (enterKeyInfo.Key == ConsoleKey.Enter)
                {
                   
                    int operand1 = 5;  
                    int operand2 = 3;  

                    int result = (operationSymbol == '+') ? operand1 + operand2 : operand1 - operand2;

                    Console.WriteLine($"Result: {result}");
                    break;
                }
                else if (enterKeyInfo.Key == ConsoleKey.Q)
                {
                    
                    return;
                }
                else
                {
                    Console.WriteLine($"Ignoring key '{enterKeyInfo.Key}'. Press 'Enter' or 'Q'.");
                }
            }
        }
    }
}