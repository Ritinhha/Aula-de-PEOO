using System;
class program {
  public static void Main() {
  string nums = Console.ReadLine().Split(',');
int tamanho = nums.Length;
int soma = 0;
int aux = 0;

for (int X = 0; X <= tamanho -1; X++){

        aux = int.Parse(nums[X]);
       soma = soma + aux;

}
   }
  }