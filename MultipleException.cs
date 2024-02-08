//Program to demonstrate Division by Zero and also Index Out of Range exceptions.

using System;
class MultipleException {
    static void Main(String[] args) {
        int[] number = {8,17,24,5,25};
        int[] divisor = {2,0,0,5};
        //outer try block
        //here IndexOutOfRangeException occurs due to which program may terminate
        try {
            for(int i=0; i<number.Length; i++) {
                //inner try block
                //here DivideByZeroExceptions is caught and allows program to continue its execution
                try {
                    Console.WriteLine("Number: " + number[i] + "\nDivisor: " + divisor[i] + "\nAnswer: "+ number[i]/divisor[i]);
                }

                //catch block for inner try block
                catch(DivideByZeroException e) {
                    Console.WriteLine("Inner Try Catch Block");
                    Console.WriteLine("An exception has occurred: {0}", e.Message);
                }
            }
        }

        catch (IndexOutOfRangeException e) {
            Console.WriteLine("Outer Try Catch Block: ");
            Console.WriteLine("An exception has occurred: {0}", e.Message);
        }
    }
}
