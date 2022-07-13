using System;
class program {
  public static void Main() {
  string[] frase = Console.ReadLine().Split(' ');
    int tamanho = frase.Length;
    int tamanhoAux;
    string palavra;

    for(int x = tamanho - 1; x >= 0; x--){
      tamanhoAux = frase[x].Length;
      palavra = frase[x];
      Console.Write(" ");
      for(int y = tamanhoAux - 1 ; y >= 0; y--)
        Console.Write(palavra[y]);
    }
   }
  }