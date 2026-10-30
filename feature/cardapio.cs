using System;

public class CardapioSistemalanchonete
{
    public static void Executar()
    {



        using System;


namespace ProjetoLanchonetesenac

{

    internal class Cardapio

    {

        // Vetor com os nomes dos produtos

        static string[] produtos = {

            "Coxinha",

            "Pao de queijo",

            "Suco",

            "Cafe",

            "Bolo"

        };

        // Vetor com os preços dos produtos

        static double[] precos = { 7, 5, 6, 4, 8 };

        // Programa principal

        static void Main(string[] args)

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







                // Vetor com os nomes dos produtos

                static string[] produtos = {

            "Coxinha",

            "Pao de queijo",

            "Suco",

            "Cafe",

            "Bolo"

        };

                // Vetor com os preços dos produtos

                static double[] precos = { 7, 5, 6, 4, 8 };

                // Programa principal

                static void Main(string[] args)

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

                }

            }

        }



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

        }

    }

}
}

 

    }
}
