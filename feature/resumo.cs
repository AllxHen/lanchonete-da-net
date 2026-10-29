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
}
    //A soma o Faturamento de todos.
    static double FaturamentoSemanal(int[,] vendas, double[,] precos)
    {
        double totalUnidades = 0;

        
        // Percorre cada linha (Produto) na matriz.
        for (int produto1 = 0; produto1< vendas.GetLength(0); produto1++)
        {
            FaturamentoSemanal += FaturamentoProduto[vendas, precos, produto1];
        }
        return FaturamentoSemanal;
    }
