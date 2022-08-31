using System;
class program {
  public static void Main() {

    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());

    Console.WriteLine(Menor(x,y));
    
   }
  public static double Menor(double f1, double f2){
    if(f1 > f2)
      return f2;
    else 
      return f1;
  }
  }