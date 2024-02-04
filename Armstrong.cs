//Program to find all Armstrong numbers from 0 to 1000.

using System;
class Armstrong {
   static void Main(String[] args) {
      Console.WriteLine("Armstrong Number");
      int ncpy = 0;
      for(int i = 1; i<=1000; i++) {
      ncpy = i;
      double digno = 0;
      double dig = 0;
      double sum = 0;
      while(ncpy>0) {
        ncpy = ncpy/10;
        digno++;
      }
      ncpy = i;
      for(int j = 0; j<digno; j++) {
        dig = ncpy%10;
        ncpy = ncpy/10;
        sum += Math.Pow(dig, digno);
      }
      if(sum==i)
        Console.WriteLine(i);
      }
   }
}
