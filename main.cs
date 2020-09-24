using System;

class MainClass{
  static Mostrar M = new Mostrar();
  static Estoque E = new Estoque();
  public static void Main (string[] args) {
  string Nome = " "; 
  string z = "n";
  while (z =="n"){
    Console.WriteLine("Digite seu nome");
    Nome = (Console.ReadLine());
    Console.WriteLine("Confirma seu nome?s/n");
    Console.WriteLine(Nome);
    z = Console.ReadLine();}
  int Pedido;  
  string y = "s";
  while(y == "s"){
    Console.WriteLine("Escolha o tipo de produto");
    Console.WriteLine("Pães:1");
    Console.WriteLine("Leites:2");
    Console.WriteLine("Pizzas:3");
    Console.WriteLine("Biscoitos:4");
    Pedido = int.Parse(Console.ReadLine());
    estoque(Pedido);
    Console.WriteLine("digite s para continuar e digite n para encerrar");
    y = Console.ReadLine();
    }
    if (E.total > 0){
      mostrar(Nome);}
    else{
      Console.WriteLine("PEDIDO INVÁLIDO");
    }
  }
  public static void estoque(int Pedido){
   if(Pedido == 1){
      E.Pao();}
    else if(Pedido == 2){
      E.Leite();}
    else if(Pedido == 3){
      E.Pizza();}
   else  if(Pedido == 4){         
      E.Biscoito();}
  }
  public static void mostrar(string Nome)  { 
    M.QtdPedido(E);
    M.Frete(E);
    M.T(E,Nome);
  }
}