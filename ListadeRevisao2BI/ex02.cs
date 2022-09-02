using System;
class program {
  public static void Main() {
  
   }
  }
class Compra{
  private double total;
  private int prestações;

  public void SetTotal(double t){
    total = t;
    
  }
  public void SetNumprestações(int p){
    prestações = p;
  }
  public double GetNumPrestações(){
    return total/prestações;
  }
  public double GetValorDesconto(){
    return total-(total*0.15);
  }
  
}