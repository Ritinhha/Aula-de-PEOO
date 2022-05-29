using System;
class program{
  public static void Main(){
    Console.WriteLine("Digite quatro valores inteiros");
    int n1 =int.Parse(Console.ReadLine());
    int n2 =int.Parse(Console.ReadLine());
    int n3 =int.Parse(Console.ReadLine());
    int n4 =int.Parse(Console.ReadLine());
double media = (n1 + n2 + n3 + n4)/4;
Console.WriteLine($"Media = {media}");
Console.WriteLine("Valores maiores ou igual a media");
if (n1 >= media)
Console.WriteLine($"{n1}");
if (n2 >= media)
Console.WriteLine($"{n2}");
if (n3 >= media)
Console.WriteLine($"{n3}");
if (n4 >= media)
Console.WriteLine($"{n4}");
Console.WriteLine("Valores menores que a media");
if (n1 < media)
Console.WriteLine($"{n1}");
if (n2 < media)
Console.WriteLine($"{n2}");
if (n3 < media)
Console.WriteLine($"{n3}");
if (n4 < media)
Console.WriteLine($"{n4}");
    }
}