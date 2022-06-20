using System;
class MainClass {
 public static double Maior(double x, double y, double z){
   if(x > y && x > z){ 
     return x;
     }
  else{
   if (z > x && z > y){
     return z;
   }
     else {
       return y;
     }
    }
 }
  public static void Main(){
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    double z = double.Parse(Console.ReadLine());
    Console.WriteLine(Maior(x, y, z));
  }
}
