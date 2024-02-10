//Program to create Floyd's triangle using jagged arrays.

using System;
namespace JaggedArray {
    public class Program {
        public static void Main(string[] args) {
            Console.Write("Give number of rows to print: ");
            int n = Convert.ToInt32(Console.ReadLine()); //or Int43.Parse(Console... ...);

            int[][] jaggedArray = new int[n][];

            int progress = 1;

            Console.WriteLine("Floyd's Triangle");
            for(int i = 0; i < n; i++) {
                jaggedArray[i] = new int[i+1];
                for(int j = 0; j < jaggedArray[i].Length; j++) {
                    Console.Write(progress++ + "    ");
                }
                Console.WriteLine();
            }
        }
    }
}
