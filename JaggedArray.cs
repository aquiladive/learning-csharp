//Program to create Pascal's Triangle using jagged array.

using System;
namespace JaggedArray {
    public class Program {
        public static void Main(string[] args) {
            Console.Write("Give number of rows to print: ");
            int n = Convert.ToInt32(Console.ReadLine()); //or Int43.Parse(Console... ...);
            int pattern = 1;

            int[,] arr = new int[n,n];

            Console.WriteLine("Pascal's Triangle");
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < pattern; j++) {
                    if(j==0 || j==i) {
                        arr[i,j] = 1;
                    }
                    else {
                        arr[i,j] = arr[i-1,j-1] + arr[i-1,j];
                    }
                    Console.Write(arr[i,j] + "     ");
                }
                pattern++;
                Console.WriteLine();
            }
        }
    }
}
