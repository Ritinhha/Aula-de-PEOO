using System; 

class URI {

    static void Main(string[] args) { 
        Console.WriteLine("Digite um numero");
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());    
        int C = A + B;
        Console.WriteLine($"X = {C}");
        
    }

}