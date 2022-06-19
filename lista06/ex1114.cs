using System;
class program {
 public static void Main(){
   
   string senha = Console.ReadLine();

   while (senha != "2002"){
     Console.WriteLine("Senha inválida");
     senha = Console.ReadLine();
     Console.Clear();
   }

   Console.WriteLine("Acesso Permitido");
  
 }
}