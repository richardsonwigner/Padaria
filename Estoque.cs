using System;

class Estoque{ 
  private int Q;
  public double V;
  public double QtdPao;
  public double QtdLeite;
  public double QtdPizza; 
  public double QtdBiscoito;
  public double total;

  public void Pao(int Q){
      V = Q * 0.75;
      Console.WriteLine("O valor dessa compra é {0}R$",V);
      QtdPao = QtdPao + Q;
      total = total + V;
  }
  public void Leite(int Q){
      V = Q * 5;
      Console.WriteLine("O valor dessa compra é {0}R$",V);
      QtdLeite = QtdLeite + Q;
      total = total + V;
    }
  public void Pizza(int Q){
      V = Q * 19.99;
      Console.WriteLine("O valor dessa compra é {0}R$",V);
      QtdPizza= QtdPizza + Q;
      total = total + V;
    }
  public void Biscoito(int Q){
      V = Q * 2.99;
      Console.WriteLine("O valor dessa compra é {0}R$",V);
      QtdBiscoito= QtdBiscoito + Q;
      total = total + V;
    }
}