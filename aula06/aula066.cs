using System;

    class Aula066{
        static void Main(){
            double valorcompra = 5.50;
            double valorvenda;
            double lucro = 0.1;
            string produto = "pastel";

            valorvenda = valorcompra + (valorcompra*lucro);

            Console.WriteLine("produto.....:{0,15}", produto);
            Console.WriteLine("val.compra....:{0,15:c}", valorcompra);
            Console.WriteLine("lucro....:{0,15:p}", lucro);
            Console.WriteLine("val.venda....:{0,15:c}", valorvenda);
               }
    }