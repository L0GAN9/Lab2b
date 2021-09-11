using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter a Number");

    var x = Console.ReadLine();

    Console.WriteLine("Enter Another Number");

    var y = Console.ReadLine();

    double num1 = Convert.ToDouble(x);

    double num2 = Convert.ToDouble(y);

    Console.Write("Sum = ");

    Console.WriteLine(num1+num2);

    Console.Write("Diff = ");

    Console.WriteLine(num1-num2);

    Console.Write("Product = ");

    Console.WriteLine(num1*num2);

    Console.Write("Quotient = ");
    double num3 = (num1/num2);//Took the Quotient
    int num4 = (int) num3;//Converted the double into an integer
    Console.WriteLine(num4);//Inserted the outsome into the text
  

    Console.Write("Remainder = ");
    Console.WriteLine(num1%num2);
  
    
    

    
  }
}