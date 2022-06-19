using System;
class program {
 public static void Main(){

  int X;
  double result, Y;
  int N = int.Parse(Console.ReadLine());

  for(int k = 1; k <= N; k++){
    X = int.Parse(Console.ReadLine());
    Y = double.Parse(Console.ReadLine());

    if(Y == 0){
      Console.WriteLine("Divisão impossível");
      Console.Clear();
    }
    else {
      result = X/Y;
      Console.WriteLine($"Resposta da divisão: {result:0.0}");
      Console.ReadLine();
      Console.Clear();
    }
  }
  
 }
}