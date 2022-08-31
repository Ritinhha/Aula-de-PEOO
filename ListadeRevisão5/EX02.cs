using System;
class program {
  public static void Main() {
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine(AreaCirculo(x));
   }
  public static double AreaCirculo(double raio){
    double Area = 3.14* (raio * raio);
    return Area;
      
  }
  }