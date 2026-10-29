using System;

namespace ProjetoLanchonete 
{
    public class ProjetoLanchonete 
    {
        public static void Main(string[] args) 
        {
            //Pessoal, vou terminar minha parte da Main e da integração hoje e mandar tudo para vocês, 
            //junto com uma explicação de como o código funciona e como executar o projeto. Como amanhã não vou conseguir ir, 
            //quero deixar minha parte organizada para vocês conseguirem testar e apresentar. Se encontrarem algum erro na integração, 
            //me avisem para eu verificar o que consigo ajustar hoje, estarei no teams.

            //Coloquem os metodos la em baixo!
            
            int opcao = 0; // irei adicionar um readline conforme o metodo for executar para a escolha das opçoes, para no futuro integrar com um switch case

            do
            {
                mostrarMenu();
                opcao = int.Parse(Console.Readline()); 
                // iniciando a interface do menu usando um metodo que esta a baixo!
                // irei usar o switch pra fazer as escolha das opçoes do menu mostrando varios caso diferentes, tipo se o cara digitar 1 ele vai ver o cardapio e outras coisas relacionadas a ele.
                // alem que terei que usar switch case dentro deles msm pra poder fazer um menu mais dinamico e organizado 

                switch (opcao)
                {
                case 1:
                    Console.WriteLine("1 - MostrarCardapio");
                    Console.WriteLine("2 - CodigoValido");
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                    case 1:
                        mostrarMenu();
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
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
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
                    Console.WriteLIne("4 - Dia Mais Movimentado");
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
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
                }
                
            } while (opcao != 4);

            //Aqui em baixo vcs colocam todos os metodos pra manter organizado e tudo certinho!
            
            static void mostrarMenu()
            {
                Console.WriteLine("=========  *LANCHONETE SENAC* ==================");  // Mostrando as opções do Menu usando um Metodo para o menu, conforme o sistema for inciar!
                Console.WriteLine("---------- OPÇÕES ----------");
                Console.WriteLine("1 - Ver Cardapio ");
                Console.WriteLine("2 - Ver Vendas");
                Console.WriteLine("3 - Ver Resumo e faturamento");
                Console.WriteLine("4 - Sair");
            }

            
        }
    }
}
