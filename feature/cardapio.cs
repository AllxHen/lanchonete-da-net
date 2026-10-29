using System;


namespace ProjetoLanchonetesenac
{
    internal class cardapio
    {   
        static void MostrarMenu()
        {
            Console.WriteLine("=========  *LANCHONETE SENAC* ==================");  // LINHA 8 A LINHA 16 OPÇOES DO CARDAPIO 
            Console.WriteLine("========= OPÇÕES ==============");
            Console.WriteLine("1- VER CARDÁPIO ");
            Console.WriteLine("2 - REGISTRAR VENDA");
            Console.WriteLine("3 - RELATÓRIO DO PRODUTO");
            Console.WriteLine("4-  RELATÓRIO POR DIA ");
            Console.WriteLine("5- RESUMO DA SEMANA");
            Console.WriteLine("0 - SAIR ");
            Console.WriteLine("OPÇÃO:");
        }
    }
}
