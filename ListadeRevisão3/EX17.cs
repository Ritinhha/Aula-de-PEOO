using System;
class program {
  public static void Main() {
  string[] frase = Console.ReadLine().Split(' ');
    int tamanhoAux;
    int a = 0, e = 0, i = 0, o = 0, u = 0, soma = 0;
    
    for(int x = 0; x < frase.Length; x++)
      frase[x] = frase[x].ToUpper();
    
    foreach(string aux in frase){
      tamanhoAux = aux.Length;
      for(int x = 0; x < tamanhoAux; x++){
        if (aux[x] == 'A')
          a += 1;
        if (aux[x] == 'E')
          e += 1;
        if (aux[x] == 'I')
          i += 1;
        if (aux[x] == 'O')
          o += 1;
        if (aux[x] == 'U')
          u += 1;
            
      }  
     soma = 0;
     soma = a + e + i + o + u;
     a = 0; e = 0; i = 0; o = 0; u = 0;
     for(int x = 1; x <= soma; x++){
       Console.Write(aux.ToLower());
       Console.Write(" ");
     }
    }
   }
  }