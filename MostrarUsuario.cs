using System;

class Mostrar 
{
  int frete;
  public void QtdPedido(Estoque E)
  {
    if(E.QtdPao > 0){
      Console.WriteLine("Você pediu um total de {0} pão(es)",E.QtdPao);
    }
    if(E.QtdLeite > 0){
      Console.WriteLine("Você pediu um total de {0} Leite(s)",E.QtdLeite);
    }
    if(E.QtdPizza > 0){
      Console.WriteLine("Você pediu um total de {0} Pizza(s)",E.QtdPizza);
    }
    if(E.QtdBiscoito> 0){
      Console.WriteLine("Você pediu um total de {0}Biscoito(s)",E.QtdBiscoito);
    }
  }
  public void Frete(Estoque E){
    if(E.total < 20){
      frete = 5;
      Console.WriteLine("Seu frete total é {0}R$",frete);
    }
    else{
      frete = 0;
      Console.WriteLine("Frete Grátis");
    }
  }
  public void T(Estoque E) {
   Console.WriteLine("Seu pedido total é {0}R$",E.total + frete);
  }
}
