using System;
using System.Collections.Generic;

namespace Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criamos uma nova lista do tipo produto
           List<Produto> produtos = new List<Produto>();

            //Criamos um produto através do construtor padrão
           Produto produto1 = new Produto();
           produto1.Codigo = 1;
           produto1.Nome = "Red Dead Redemption 2";
           produto1.Preco = 250.00f;

           //Adicionamos o produto criado na lista
           produtos.Add(produto1);

           //Adicionamos mais produtos utilizando o novo construtor
           produtos.Add( new Produto(2, "Mafia Trilogy", 250.00f));
           produtos.Add( new Produto(3, "Desperados III", 147.45f));
           produtos.Add( new Produto(4, "Beyond Blue", 74.95f));
           produtos.Add( new Produto(5, "Metro Exodus", 250.00f));
           produtos.Add( new Produto(6, "Forza Horizon 4", 250.00f));

           //varremos a lista com foreach
           foreach(Produto item in produtos){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"R${item.Nome} - {item.Preco}");
            Console.ResetColor();
           }

           //Remover item passando o objeto como argumento
           produtos.Remove(produto1);
            //Removendo item pelo indice
           produtos.RemoveAt(2);
           //Usamos lambda para eliminar um registro
           produtos.RemoveAll(y => y.Nome == "Metro Exodus");

           foreach(Produto item in produtos){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"R${item.Nome} - {item.Preco}");
            Console.ResetColor();
           }

           //Podemos encontrar um produto especifcoc utilizando lambda
           Produto Horizon = produtos.Find( x => x.Codigo == 6);
           Console.WriteLine("Forza Horizon 4 - R$"+Horizon.Preco);

           //Aplicar o complemento da atividade
            List<Cartao> cartoes = new List<Cartao>();
            
            Cartao cartao1 = new Cartao();
           cartao1.Codigo = 1;
           cartao1.Titular = "Lorenzo Homan Silva";
           cartao1.Numero = 466488878;
           cartao1.Bandeira = "Visa";
           cartao1.Vencimento = "09/25";
           cartao1.CVV = "548";

           cartoes.Add(cartao1);

            cartoes.Add(new Cartao(2, "Roberto Mannarino", 51658186, "MasterCard", "02/27", "057"));
            cartoes.Add(new Cartao(3, "Adriana Bastos", 95651858, "Elo", "10/29", "984"));
            cartoes.Add(new Cartao(4, "Laura Almeida Fiaccadori", 54554525, "MasterCard", "05/27", "645"));
            cartoes.Add(new Cartao(5, "Raul Seixas Almeida", 545, "MasterCard", "02/27", "328"));


            foreach(Cartao cart in cartoes){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($" \n Titular do cartão: {cart.Titular} \n Numero do cartão: {cart.Numero} \n Bandeira do cartão {cart.Bandeira} \n Vencimento do cartão: {cart.Vencimento} \n CVV do cartão: {cart.CVV} ");
                Console.ResetColor();

            }
        }
    }
}
