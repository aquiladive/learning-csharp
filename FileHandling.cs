using System;
using System.IO;

namespace FileIOApplication {
   class Program {
      static void Main(string[] args) {
         string outputFilePath = "trial.txt";

         Console.WriteLine("Enter the content to write to the file:");
         string userInput = Console.ReadLine();

         using (StreamWriter writer = new StreamWriter(outputFilePath)) {
            writer.Write(userInput);
         }

         Console.WriteLine("Content has been written to " + outputFilePath + ".");
         Console.ReadKey();
      }
   }
}
