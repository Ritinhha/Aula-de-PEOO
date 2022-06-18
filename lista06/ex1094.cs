using System;
class program {
 public static void Main(){

   int N = int.Parse(Console.ReadLine());
   int quantia = 0;
   int C = 0;
   int R = 0;
   int S = 0;
   int total = 0;

   string[] teste = Console.ReadLine().Split(' ');
   for(int x = 1;x <= N;x++){
     quantia = int.Parse(teste[0]) + quantia;
     if (teste[1] == "S")
        S++;
     if (teste[1] == "C")
       C++;
     if (teste[1] == "R")
       R++;
     total = quantia + total;
     teste[] = Console.ReadLine();
        
   }

   Console.WriteLine($"Total de cobaias = {total}");
   Console.WriteLine($"Total de coelhos = {C}");
   Console.WriteLine($"Total de sapos = {S}");
   Console.WriteLine($"Total de ratos = {R}");
   Console.WriteLine($"Percentagem de coelhos = {(total-S-R)/100}");
   Console.WriteLine($"Percentagem de sapos = {(total-C-R)/100}");
   Console.WriteLine($"Percentagem de coelhos = {(total-S-C)/100}");


   
 }
}