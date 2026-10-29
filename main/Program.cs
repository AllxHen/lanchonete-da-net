using System;

namespace ProjetoLanchonete 
{
    public class ProjetoLanchonete 
    {
        public static void Main(string[] args) 
        {
            //Parte do Allex
            //Pessoal, vou terminar minha parte da Main e da integração hoje e mandar tudo para vocês, 
            //junto com uma explicação de como o código funciona e como executar o projeto. Como amanhã não vou conseguir ir, 
            //quero deixar minha parte organizada para vocês conseguirem testar e apresentar. Se encontrarem algum erro na integração, 
            //me avisem para eu verificar o que consigo ajustar hoje, estarei no teams.

            //Coloquem os metodos la em baixo!
            
            int opcao = 0; // irei adicionar um readline conforme o metodo for executar para a escolha das opçoes, para no futuro integrar com um switch case
            int subopcao = 0; // Uma opção para os segundos switch para nao dar conflito

            do //mantem o menu principal em execuçao, repetindo as opçoes ate o usuario escolher 0 para sair
            {
                mostrarMenu();
                opcao = int.Parse(Console.ReadLine()); 
                // iniciando a interface do menu usando um metodo que esta a baixo!
                // irei usar o switch pra fazer as escolha das opçoes do menu mostrando varios caso diferentes, tipo se o cara digitar 1 ele vai ver o cardapio e outras coisas relacionadas a ele.
                // alem que terei que usar switch case dentro deles msm pra poder fazer um menu mais dinamico e organizado 

                switch (opcao)
                {
                case 1:
                    Console.WriteLine("1 - MostrarCardapio");
                    Console.WriteLine("2 - CodigoValido");
                    subopcao = int.Parse(Console.ReadLine());

                    switch (subopcao) //aqui criei mais um switch case pra opcao dentro delas
                    {
                    case 1:
                        MostrarCardapio(); // executando os metodos
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
                
            } while (opcao != 0); // aqui o while enquanto ele for diferente de zero ele ainda vai continuar executando ate vc colocar 0 pra parar esse loop

        }
             //AVISOOOOO! Aqui em baixo vcs colocam todos os metodos pra manter organizado e tudo certinho!
            static void mostrarMenu()
            {
                Console.WriteLine("=========  *LANCHONETE SENAC* ==================");  // Mostrando as opções do Menu usando um Metodo para o menu, conforme o sistema for inciar!
                Console.WriteLine("---------- OPÇÕES ----------");
                Console.WriteLine("1 - Ver Cardapio ");
                Console.WriteLine("2 - Ver Vendas");
                Console.WriteLine("3 - Ver Resumo e faturamento");
                Console.WriteLine("0 - Sair");
            }
            
            // irei deixar ja no gatilho pra vcs terem ideia de como colocar

            static void MostrarCardapio(){
                
            }

            static void CodigoValido(){
                
            }

            static void RegistrarVenda(){
                
            }

            static void TotalProduto(){
                
            }

            static void TotalDia(){
                
            }

            static void FaturamentoProduto(){
                
            }

            static void FaturamentoSemana(){
                
            }

            static void ProdutoCampeao(){
                
            }

            static void DiaMaisMovimentado(){
        }
    }
}
