using System;

class Estoque{ 
  private int Q;
  private double V;
  public double QtdPao;
  public double QtdLeite;
  public double QtdPizza; 
  public double QtdBiscoito;
  public double total;

  public void Pao(){
    Console.WriteLine("Escolha a quantidade que deseja");
    Q = int.Parse(Console.ReadLine());
    if(Q > 0){
      V = Q * 0.75;
      Console.WriteLine("O valor dessa compra é {0}R$",V);
      QtdPao = QtdPao + Q;
      total = total + V;}
      else{
        Console.WriteLine("Número inválido");}
  }
  public void Leite(){
    Console.WriteLine("Escolha a quantidade que deseja");
    Q = int.Parse(Console.ReadLine());
    if(Q > 0){
      V = Q * 5;
      Console.WriteLine("O valor dessa compra é {0}R$",V);
      QtdLeite = QtdLeite + Q;
      total = total + V;}
      else{
        Console.WriteLine("Número inválido");}
    }
  public void Pizza(){
    Console.WriteLine("Escolha a quantidade que deseja");
    Q = int.Parse(Console.ReadLine());
      if(Q > 0){
        V = Q * 19.99;
        Console.WriteLine("O valor dessa compra é {0}R$",V);
        QtdPizza= QtdPizza + Q;
        total = total + V;}
      else{
        Console.WriteLine("Número inválido");}
    }
  public void Biscoito(){
   Console.WriteLine("Escolha a quantidade que deseja");
    Q = int.Parse(Console.ReadLine());
    if(Q > 0){
      V = Q * 2.99;
      Console.WriteLine("O valor dessa compra é {0}R$",V);
      QtdBiscoito= QtdBiscoito + Q;
      total = total + V;}
      else{
        Console.WriteLine("Número inválido");}
}
}