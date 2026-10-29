using System;
using System.Globalization;

public class Vendas
{
	public static void Executar()
	{


		// passo 1 receber venda
		Console.WriteLine("Digite o código do produto: (de 1 a 5)");
		int codigoProduto = int.Parse(Console.ReadLine());
		if (codigoProduto <= 0 && codigoProduto > 5)
		{
			while (codigoProduto <=0 && codigoProduto > 5)
			{
				Console.WriteLine("Digite o código do produto: (de 1 a 5)");
				codigoProduto++;
			}
		}

		Console.WriteLine("Digite o código do dia da semana: (1 = Seg 2 = Ter 3 = Qua 4 = Qui 5 = Sex)");
		int codigoDia = int.Parse(Console.ReadLine());
        if (codigoDia <= 0 && codigoDia > 5)
        {
			while (codigoDia <= 0 && codigoDia > 5)
			{
				Console.WriteLine("Digite o código do dia da semana: (1 = Seg 2 = Ter 3 = Qua 4 = Qui 5 = Sex)");
				codigoDia++;
			}
        }


        Console.WriteLine("Digite a quantidade que foi vendida deste produto: ");
		int quantidadeVendida = int.Parse(Console.ReadLine());
		if (quantidadeVendida <= 0 && quantidadeVendida > 5)
		{
			while (codigoDia <= 0 && codigoDia > 5)
			{
				Console.WriteLine("Digite a quantidade que foi vendida deste produto: ");
				quantidadeVendida++;
			}
		}


        // passo 2 método para registar vendas

		static double RegistrarVenda()
		{ 
        
		string[] produto = { "Coxinha", "Pão de queijo", "Suco", "Café", "Bolo" };
        double[] preco = { 7.0, 5.0, 6.0, 4.0, 8.0 };
        string[] dia = { "Seg", "Ter", "Qua", "Qui", "Sex" };

        int[produto,dia] vendas = {
            { }
        };

		for (int contador = 0; contador < produto.GetLength(0); contador++)
			{
				Console.Write
			}


        static double RegistrarVenda()
	}
}
