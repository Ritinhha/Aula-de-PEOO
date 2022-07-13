using System;
class program {
  public static void Main() {
  string[] frase = Console.ReadLine().Split(' ');
    int tamanhoAux;
    
    foreach(string aux in frase){
     tamanhoAux = aux.Length;
     Console.WriteLine();
      for(int x = tamanhoAux - 1 ; x >= 0; x--)
        Console.Write(aux[x]);
    }
   }
  }