using System;

public class Vendas
{
   
    public static void Executar()
    {
        // Método para registrar venda
        static void RegistrarVenda()
        {    // Vetor de produtos
            static string[] produto = { "Coxinha", "Pão de queijo", "Suco", "Café", "Bolo" };
            static double[] preco = { 7.0, 5.0, 6.0, 4.0, 8.0 };
            static string[] dia = { "Seg", "Ter", "Qua", "Qui", "Sex" };

            // Matriz de vendas
            static int[,] vendas = new int[5, 5];

            // Receber código do produto
            Console.WriteLine("Digite o código do produto (de 0 a 4):");
            int codigoProduto = int.Parse(Console.ReadLine());

            while (codigoProduto < 0 || codigoProduto > 4)
            {
                Console.WriteLine("Código inválido! Digite novamente:");
                codigoProduto = int.Parse(Console.ReadLine());
            }

            // Receber código do dia da semana
            Console.WriteLine("Digite o código do dia da semana:");
            Console.WriteLine("0 = Seg | 1 = Ter | 2 = Qua | 3 = Qui | 4 = Sex");

            int codigoDia = int.Parse(Console.ReadLine());

            while (codigoDia < 0 || codigoDia > 4)
            {
                Console.WriteLine("Código inválido! Digite novamente:");
                codigoDia = int.Parse(Console.ReadLine());
            }

            // Receber quantidade vendida
            Console.WriteLine("Digite a quantidade vendida:");
            int quantidadeVendida = int.Parse(Console.ReadLine());

            while (quantidadeVendida <= 0)
            {
                Console.WriteLine("Quantidade inválida! Digite novamente:");
                quantidadeVendida = int.Parse(Console.ReadLine());
            }

            // Acumular venda
            vendas[codigoProduto, codigoDia] += quantidadeVendida;

            Console.WriteLine("Venda registrada com sucesso!");
        }

        // Método para calcular total por produto
        static void TotalProduto(int codigoProduto)
        {    // Vetor de produtos
            static string[] produto = { "Coxinha", "Pão de queijo", "Suco", "Café", "Bolo" };
            static double[] preco = { 7.0, 5.0, 6.0, 4.0, 8.0 };
            static string[] dia = { "Seg", "Ter", "Qua", "Qui", "Sex" };

            // Matriz de vendas
            static int[,] vendas = new int[5, 5];

            int soma = 0;

            for (int colunaMatriz = 0; colunaMatriz < vendas.GetLength(1); colunaMatriz++)
            {
                soma += vendas[codigoProduto, colunaMatriz];
            }

            Console.WriteLine($"Total vendido de {produto[codigoProduto]}: {soma}");
        }

        // Método para calcular total por dia
        static void TotalDia(int codigoDia)
        {    // Vetor de produtos
            static string[] produto = { "Coxinha", "Pão de queijo", "Suco", "Café", "Bolo" };
            static double[] preco = { 7.0, 5.0, 6.0, 4.0, 8.0 };
            static string[] dia = { "Seg", "Ter", "Qua", "Qui", "Sex" };

            // Matriz de vendas
            static int[,] vendas = new int[5, 5];
            int soma = 0;

            for (int linhaMatriz = 0; linhaMatriz < vendas.GetLength(0); linhaMatriz++)
            {
                soma += vendas[linhaMatriz, codigoDia];
            }

            Console.WriteLine($"Total vendido na {dia[codigoDia]}: {soma}");
        }
    }
}