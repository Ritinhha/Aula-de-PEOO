using System;
class program {
 public static void Main(){

   int posicao = 0;
   int maior = 0;
   int numero = 0;

   for(int x = 1;x <= 100; x++)
   {
      numero = int.Parse(Console.ReadLine());
      if(numero>maior){
        maior = numero;
        posicao = x;
      }
   }

   Console.WriteLine(maior);
   Console.WriteLine(posicao);
   
   
 }
}