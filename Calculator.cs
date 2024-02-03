using System;
class Calculator {
    static void Main(string[] args) {
        Console.WriteLine("Simple calculator:");
        int ans = 0;
        Console.Write("Give the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Give the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Give the operator: ");
        string op = Console.ReadLine();
        switch(op) {
            case "+": ans = num1 + num2;
            Console.WriteLine("Answer is {0}.", ans);
            break;

            case "-": ans = num1 - num2;
            Console.WriteLine("Answer is {0}.", ans);
            break;

            case "*": ans = num1 * num2;
            Console.WriteLine("Answer is {0}.", ans);
            break;
    
            case "/": if(num2!=0) {
                ans = num1 / num2;
                Console.WriteLine("Answer is {0}.", ans);
            }
            else {
                Console.WriteLine("Error.");
            }
            break;

            case "%": ans = num1 % num2;
            Console.WriteLine("Answer is {0}.", ans);
            break;

            default:
            Console.WriteLine("Unidentified operator. Accepted operators are +, -, *, / and %.");
            break;
        }
    }
}
