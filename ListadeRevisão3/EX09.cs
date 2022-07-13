using System;
class program {
  public static void Main() {
  string palavra = Console.ReadLine();

string tamanho = palavra.Length;

int X = 1;
while (X <= tamanho){

     Console.Write($"{X} - ");
     Console.Write(palavra);
     X++;
 
}
   }
  }