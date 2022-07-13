using System;
class program {
  public static void Main() {
  string[] frase = Console.ReadLine().Split(' ');
    int tamanhoAux;
    
    foreach(string aux in frase){
      tamanhoAux = aux.Length;
      Console.Write(aux[tamanhoAux - 1]);
    }
   }
  }