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
        double totalUnidades = 0;

        
        // Percorre cada linha (Produto) na matriz.
        for (int produto1 = 0; produto1< vendas.GetLength(0); produto1++)
        {
            FaturamentoSemanal += FaturamentoProduto[vendas, precos, produto1];
        }
        return FaturamentoSemanal;
    }



    // Produto campeão foi oque mais vendeu, ou seja, o produto que teve a maior quantidade de vendas.
    static double ProdutoCampeao(int[,] TotalProduto, int[,] quantidadeVendas)
    {
        int IndiceProdutoCampeao = 0;
        int maiorQntd = -1;

        for (int produtinho1 = 0; produtinho1< quantidadeVendas.GetLength(0); produtinho1++) ;
        {
            
            int totalDoproduto = 0;

            for (int dia = 0; dia< quantidadeVendas.GetLength(1); dia++)
            {
                totalDoproduto += quantidadeVendas[dia, quantidadeVendas];
            }
        }
        if (TotalProduto > quantidadeVendas)
        {
            quantidadeVendas = TotalProduto;
            IndiceProdutoCampeao = quantidadeVendas; ////// Verifica se o total do produto atual é maior que o maior encontrado até agora
        }
        return IndiceProdutoCampeao;
    }


    // Dia com mais vendas, ou seja, o dia que teve a maior quantidade de vendas.

    static int DiaMaisMovimentado(int[,] vendas)
    {
        int diaMaisMovimentado = 0;
        int maiorVendas = -1;
        for (int dia = 0; dia < vendas.GetLength(1); dia++)
        {
            int totalVendasDia = 0;
            for (int produto = 0; produto < vendas.GetLength(0); produto++)
            {
                totalVendasDia += vendas[produto, dia];
            }
            if (totalVendasDia > maiorVendas)
            {
                maiorVendas = totalVendasDia;
                diaMaisMovimentado = dia;
            }
        }
        return diaMaisMovimentado;
    }
}
