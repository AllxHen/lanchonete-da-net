
using System;

namespace ProjetoLanchonete

{

    public class ProjetoLanchonete01

    {

        public static void Executar()
        {

            // Parte do Allex

            int opcao = 0;

            int subopcao = 0;


            {

                mostrarMenu();

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)

                {

                    case 1:

                        Console.WriteLine("1 - MostrarCardapio");

                        Console.WriteLine("2 - CodigoValido");

                        subopcao = int.Parse(Console.ReadLine());

                        switch (subopcao)

                        {

                            case 1:

                                MostrarCardapio();

                                break;

                            case 2:

                                CodigoValido();

                                break;

                            default:

                                Console.Write("Opção invalida! :(");

                                break;

                        }

                        break;

                    case 2:

                        Console.WriteLine("1 - Registrar Venda");

                        Console.WriteLine("2 - Total Produto");

                        Console.WriteLine("3 - Total Dia");

                        subopcao = int.Parse(Console.ReadLine());

                        switch (subopcao)

                        {

                            case 1:

                                RegistrarVenda();

                                break;

                            case 2:

                                TotalProduto();

                                break;

                            case 3:

                                TotalDia();

                                break;

                            default:

                                Console.Write("Opção invalida! :(");

                                break;

                        }

                        break;

                    case 3:

                        Console.WriteLine("1 - Faturamento Produto");

                        Console.WriteLine("2 - Faturamento Semana");

                        Console.WriteLine("3 - Produto Campeao");

                        Console.WriteLine("4 - Dia Mais Movimentado");

                        subopcao = int.Parse(Console.ReadLine());

                        switch (subopcao)

                        {

                            case 1:

                                FaturamentoProduto();

                                break;

                            case 2:

                                FaturamentoSemana();

                                break;

                            case 3:

                                ProdutoCampeao();

                                break;

                            case 4:

                                DiaMaisMovimentado();

                                break;

                            default:

                                Console.Write("Opção invalida! :(");

                                break;

                        }

                        break;

                    case 0:

                        Console.WriteLine("Saindo do sistema!");

                        break;

                    default:

                        Console.WriteLine("Opcao indisponivel!");

                        break;

                }

            } while (opcao != 0);

        }

        // Métodos do menu

        static void mostrarMenu()

        {

            Console.WriteLine("========= *LANCHONETE SENAC* ==================");

            Console.WriteLine("---------- OPÇÕES ----------");

            Console.WriteLine("1 - Ver Cardapio");

            Console.WriteLine("2 - Ver Vendas");

            Console.WriteLine("3 - Ver Resumo e faturamento");

            Console.WriteLine("0 - Sair");

        }

        static void MostrarCardapio()

        {

        }

        static void CodigoValido()

        {

        }

        static void RegistrarVenda()

        {

        }

        static void TotalProduto()

        {

        }

        static void TotalDia()

        {

        }

        static void FaturamentoProduto()

        {

        }

        static void FaturamentoSemana()

        {

        }

        static void ProdutoCampeao()

        {

        }

        static void DiaMaisMovimentado()

        {

        }

    }

    // Classe do Cardápio

    public class CardapioSistemalanchonete

    {

        // Vetor com os nomes dos produtos

        static string[] produtos =

        {

            "Coxinha",

            "Pao de queijo",

            "Suco",

            "Cafe",

            "Bolo"

        };

        // Vetor com os preços dos produtos

        static double[] precos = { 7, 5, 6, 4, 8 };

        public static void Executar()

        {

            int opcao = -1;

            // Repete o menu até o usuário escolher zero

            while (opcao != 0)

            {

                Console.WriteLine("\n===== LANCHONETE SENAC =====");

                Console.WriteLine("1 - Ver cardapio");

                Console.WriteLine("2 - Registrar venda");

                Console.WriteLine("3 - Relatorio do produto");

                Console.WriteLine("4 - Relatorio por dia");

                Console.WriteLine("5 - Resumo da semana");

                Console.WriteLine("0 - Sair");

                Console.Write("Escolha uma opcao: ");

                // Lê a opção digitada

                int.TryParse(Console.ReadLine(), out opcao);

                // Verifica a opção escolhida

                switch (opcao)

                {

                    case 1:

                        MostrarCardapio();

                        break;

                    case 2:

                        Console.WriteLine("Registro de venda ainda nao disponivel.");

                        break;

                    case 3:

                        Console.WriteLine("Relatorio do produto ainda nao disponivel.");

                        break;

                    case 4:

                        Console.WriteLine("Relatorio por dia ainda nao disponivel.");

                        break;

                    case 5:

                        Console.WriteLine("Resumo da semana ainda nao disponivel.");

                        break;

                    case 0:

                        Console.WriteLine("Sistema encerrado!");

                        break;

                    default:

                        Console.WriteLine("Opcao invalida!");

                        break;

                }

            }

        }

        // Método para mostrar o cardápio

        static void MostrarCardapio()

        {

            Console.WriteLine("\n===== CARDAPIO =====");

            // Percorre os produtos e mostra seus preços

            for (int i = 0; i < produtos.Length; i++)

            {

                Console.WriteLine(

                    (i + 1) + " - " + produtos[i] +

                    " | R$ " + precos[i].ToString("F2")

                );

            }

            Console.WriteLine("6 - Voltar ao menu");

            Console.Write("Escolha um produto: ");

            int codigo;

            // Verifica se o usuário digitou um número

            if (!int.TryParse(Console.ReadLine(), out codigo))

            {

                Console.WriteLine("Digite um numero valido!");

                return;

            }

            // Verifica se escolheu um produto existente

            if (codigo >= 1 && codigo <= produtos.Length)

            {

                Console.WriteLine("Produto: " + produtos[codigo - 1]);

                Console.WriteLine("Preco: R$ " + precos[codigo - 1].ToString("F2"));

            }

            else if (codigo == 6)

            {

                Console.WriteLine("Voltando ao menu...");

            }

            else

            {

                Console.WriteLine("Produto invalido!");

            }

            // Método para registrar venda

            static void RegistrarVenda()

            {

                // Vetor de produtos

                string[] produto = { "Coxinha", "Pão de queijo", "Suco", "Café", "Bolo" };

                double[] preco = { 7.0, 5.0, 6.0, 4.0, 8.0 };

                string[] dia = { "Seg", "Ter", "Qua", "Qui", "Sex" };

                // Matriz de vendas

                int[,] vendas = new int[5, 5];

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

                // Atribuição de vendas

                vendas[codigoProduto, codigoDia] += quantidadeVendida;

                Console.WriteLine("Venda registrada com sucesso!");

            }

            // Método para calcular total por produto

            static void TotalProduto(int codigoProduto)

            {

                // Vetor de produtos

                string[] produto = { "Coxinha", "Pão de queijo", "Suco", "Café", "Bolo" };

                double[] preco = { 7.0, 5.0, 6.0, 4.0, 8.0 };

                string[] dia = { "Seg", "Ter", "Qua", "Qui", "Sex" };

                // Matriz de vendas

                int[,] vendas = new int[5, 5];

                // Somando a linha da matriz com os produtos

                int soma = 0;

                for (int colunaMatriz = 0; colunaMatriz < vendas.GetLength(1); colunaMatriz++)

                {

                    soma += vendas[codigoProduto, colunaMatriz];

                }

                Console.WriteLine($"Total vendido de {produto[codigoProduto]}: {soma}");

            }

            // Método para calcular total por dia

            static void TotalDia(int codigoDia)

            {

                // Vetor de produtos

                string[] produto = { "Coxinha", "Pão de queijo", "Suco", "Café", "Bolo" };

                double[] preco = { 7.0, 5.0, 6.0, 4.0, 8.0 };

                string[] dia = { "Seg", "Ter", "Qua", "Qui", "Sex" };

                // Matriz de vendas

                int[,] vendas = new int[5, 5];

                // Somando a coluna da matriz com os dias da semana

                int soma = 0;

                for (int linhaMatriz = 0; linhaMatriz < vendas.GetLength(0); linhaMatriz++)

                {

                    soma += vendas[linhaMatriz, codigoDia];

                }

                Console.WriteLine($"Total vendido na {dia[codigoDia]}: {soma}");

            }

        }

        //Total do produto x preço

        static double FaturamentoProduto(int[,] vendas, double[] precos, int produto)

        {

            int totalUnidades = 0;

            // Percorre todas as colunas (dias da semana) da linha do produto selecionado

            for (int dia = 0; dia < vendas.GetLength(1); dia++)

            {

                totalUnidades += vendas[produto, dia];

            }

            return totalUnidades * precos[produto];

        }

        //A soma o Faturamento de todos.

        static double FaturamentoSemanal(int[,] vendas, double[] precos)

        {

            double total = 0;

            // Percorre cada linha (Produto) na matriz.

            for (int produto1 = 0; produto1 < vendas.GetLength(0); produto1++)

            {

                for (int dia = 0; dia < vendas.GetLength(1); dia++)

                {

                    total += vendas[produto1, dia] * precos[produto1];

                }

            }

            return total;

        }

        // Produto campeão foi oque mais vendeu, ou seja, o produto que teve a maior quantidade de vendas.

        static int ProdutoCampeao(int[,] quantidadeVendas)

        {

            int IndiceProdutoCampeao = 0;

            int maiorQntd = -1;

            for (int produto = 0; produto < quantidadeVendas.GetLength(0); produto++)

            {

                int totalProduto = 0;

                for (int dia = 0; dia < quantidadeVendas.GetLength(1); dia++)

                {

                    totalProduto += quantidadeVendas[produto, dia];

                }

                // Verifica se o total do produto atual é maior que o maior encontrado até agora

                if (totalProduto > maiorQntd)

                {

                    maiorQntd = totalProduto;

                    IndiceProdutoCampeao = produto;

                }

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



        // Total de itens vendidos em um dia, somando todos os produtos

        static int TotalVendasDia(int[,] vendas, int dia)

        {

            int total = 0;

            for (int produto = 0; produto < vendas.GetLength(0); produto++)

            {

                total += vendas[produto, dia];

            }

            return total;

        }



    }

}

