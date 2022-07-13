using System;
class program {
  public static void Main() {
  string[] frase = Console.ReadLine().Split(" ");

int tamanho = frase.Length;
int K;
for (int X = 0; X <= tamanho -1; X++){
      
     K = frase[X].Length;
     Console.WriteLine(K);

}
   }
  }