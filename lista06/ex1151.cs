using System;
class program {
  public static void Main() {

    int a = 0, b = 1, c = 0;
    int N = int.Parse(Console.ReadLine());
    Console.Write(a);
    Console.Write(" ");
    Console.Write(b);

    for(int x = 1; x <= N; x++){
      Console.Write(" ");
      c = a + b;
      Console.Write(c);
      a = b;
      b = c;
    }
    
   }
  }