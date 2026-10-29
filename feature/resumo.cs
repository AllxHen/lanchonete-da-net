using System;

public class RelatorioVendas
{
    //Total do produto x preço
    static double FaturamentoProduto(int[,] vendas, double[] precos, int produto)
    {
        int totalUnidades = 0;


        // Percorre todas as colunas (dias da semana) da linha do produto selecionado
        for (int dia = 0; dia < vendas.GetLength(0); dia++)
        {
            totalUnidades += vendas[produto, dia];
        }
            return totalUnidades * precos[produto];
    }


    //A soma o Faturamento de todos.
    static double FaturamentoSemanal(int[,] vendas, double[,] precos)
    {
        for (int produto1 = 0; produto1< vendas.GetLength(0); produto1++)
        {

        }
    }




    static double ProdutoCampeao(int[,] TotalProduto, int[,] quantidadeVendas)
    {

    }

}