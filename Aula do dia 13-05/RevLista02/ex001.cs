using System;
class program {
  public static void Main (){
    Console.WriteLine("Digite dois Numeros inteiros");
    int n1=int.Parse(Console.ReadLine());
    int n2=int.Parse(Console.ReadLine());
int maior;
if (n1 > n2){
  maior = n1;}
else if(n2 > n1){
  maior = n2;}
else{
  Console.WriteLine("Numeros iguais");
  return;
}
Console.WriteLine($"Maior = {maior}");
  }
} 