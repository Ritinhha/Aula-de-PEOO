using System;
class program{
  public static void Main(){
    Console.WriteLine("while");
    int i = 1;
    while (i <= 15){
      i++;
    }
   Console.WriteLine("do-while");
    i = 1; 
    do {
      Console.WriteLine(i);
      i++;
    } while( i <= 15);
    Console.WriteLine("foreach");
    int[] v ={ 5, 9, 2, 1, 7 };
    foreach( int x in v ){
    Console.WriteLine(x);
    }
    string s = "informatica para internet";
    foreach(char c in s )
      Console.WriteLine(c);
  }
}