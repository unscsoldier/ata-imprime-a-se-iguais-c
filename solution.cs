using System;

class Program
{
    static void Main()
    {
      int A = int.Parse(Console.ReadLine());
      int B = int.Parse(Console.ReadLine());
      
      if(A == B)
      {
        Console.WriteLine(A);
      }else
      {
        Console.WriteLine(0);
      }
    }
}