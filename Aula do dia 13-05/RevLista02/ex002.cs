using System;
class program{
  public static void Main(){
    Console.WriteLine("Digite quatro valores inteiros");
    int n1 =int.Parse(Console.ReadLine());
    int n2 =int.Parse(Console.ReadLine());
    int n3 =int.Parse(Console.ReadLine());
    int n4 =int.Parse(Console.ReadLine());
int maior;
if (n1 > n2 && n1 > n3 && n1 > n4){
  maior = n1;}
else if (n2 > n1 && n2 > n3 && n2 > n4){
  maior = n2;}
else if (n3 > n1 && n3 > n2 && n3 > n4){
  maior = n3;}
else {
  maior = n4;}
Console.WriteLine($"Maior = {maior}");
int menor;
if (n1 < n2 && n1 < n3 && n1 < n4){
  menor = n1;}
else if (n2 < n1 && n2 < n3 && n2 < n4){
  menor = n2;}
else if (n3 < n1 && n3 < n2 && n3 < n4){
  menor = n3;}
else {
  menor = n4;}
Console.WriteLine($"Menor = {menor}");
float media = (n1 + n2 + n3 + n4)/4;
Console.WriteLine($"Media = {media}");
    }
}