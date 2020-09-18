using System;


class MainClass{

  static Estoque E = new Estoque();
  public static void Main (string[] args) {
    int Pedido;
    int total = 0;
    string y = "s";
     while(y == "s"){
      Console.WriteLine("Escolha o tipo de produto");
      Console.WriteLine("Pães:1");
      Console.WriteLine("Leites:2");
      Console.WriteLine("Massas:3");
      Console.WriteLine("Biscoitos:4");
      Pedido = int.Parse(Console.ReadLine());
      estoque(Pedido);
      Console.WriteLine("Caso queria encerrar o pedido digite n,caso deseja continuar digite s");
      y = Console.ReadLine();
    } 
    Console.WriteLine(E.total);
  }

  public static void estoque(int Pedido){
    int x;
    int Q;
    x = 0;
      if(Pedido == 1){
        while (x == 0){
          x = 1;
          Console.WriteLine("Escolha a quantidade que deseja");
          Q = int.Parse(Console.ReadLine());
          E.Pao(Q);}
      }
      else if(Pedido == 2){
        while (x == 0){
          x = 1;
          Console.WriteLine("Escolha a quantidade que deseja");
          Q = int.Parse(Console.ReadLine());
          E.Leite(Q);}
      }
        else if(Pedido == 3){
          while (x == 0){
            x = 1;
            Console.WriteLine("Escolha a quantidade que deseja");
           Q = int.Parse(Console.ReadLine());
            E.Pizza(Q);}
        }
        else  if(Pedido == 4){
          while (x == 0){
            x = 1;
            Console.WriteLine("Escolha a quantidade que deseja");
            Q = int.Parse(Console.ReadLine());
            E.Biscoito(Q);
      }  
     }
    
  }
    
  }
