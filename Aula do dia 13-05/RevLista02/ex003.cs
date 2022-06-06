using System;
class program {
  public static void Main (){
    Console.WriteLine("Digite quatro valores inteiros");
    int v1 =int.Parse(Console.ReadLine());
    int v2 =int.Parse(Console.ReadLine());
    int v3 =int.Parse(Console.ReadLine());
    int v4 =int.Parse(Console.ReadLine());
int somapar = 0;
int somaimpar = 0;
if (v1%2==0){
  somapar = somapar + v1;}
else {somaimpar = somaimpar + v1;}
if (v2%2==0){
  somapar = somapar + v2;}
else {somaimpar = somaimpar + v2;}
if (v3%2==0){
  somapar = somapar + v3;}
else {somaimpar = somaimpar + v3;}
if (v4%2==0){
  somapar = somapar + v4;}
else {somaimpar = somaimpar + v4;}
Console.WriteLine($"soma dos pares = {somapar}");
Console.WriteLine($"soma dos impares = {somaimpar}");
  }
} 
