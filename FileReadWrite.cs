//Program to read content from one file and write it into another file.

using System;
using System.IO;

namespace FileIOApp {
  class FileReadWrite {
    static void Main(string[] args) {
      string ipFile = "test1.txt";
      string opFile = "test2.txt";
      using (StreamReader r = new StreamReader(ipFile)) {
        string content = r.ReadToEnd();
      }
      using (StreamWriter w = new StreamWriter(ipFile)) {
        w.Write(content);
      }
      Console.WriteLine("Content has been written to "+opFile);
      Console.ReadKey();
    }
  }
}
