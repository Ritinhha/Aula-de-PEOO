using System;
class program {
  public static void Main() {
    double A = double.Parse(Console.ReadLine());
    double B = double.Parse(Console.ReadLine());
    Console.WriteLine(Diagonal(A,B));
   }
  public static double Diagonal(double b, double h){
    double D = Math.Sqrt((b*b)+(h*h));
    return D;
  }
  }