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
            
            int opcao = int.Parse(Console.Readline()); // irei adicionar um readline conforme o metodo for executar para a escolha das opçoes, para no futuro integrar com um switch case

            do
            mostrarMenu();
            opcao = int.Parse(Console.Readline()); 
            // iniciando a interface do menu usando um metodo que esta a baixo!
            // irei usar o switch pra fazer as escolha das opçoes do menu mostrando varios caso diferentes, tipo se o cara digitar 1 ele vai ver o cardapio e outras coisas relacionadas a ele.
            // alem que terei que usar switch case dentro deles msm pra poder fazer um menu mais dinamico e organizado 
                
              

            








            
            static void mostrarMenu();
            {
                Console.WriteLine("=========  *LANCHONETE SENAC* ==================");  // Mostrando as opções do Menu usando um Metodo para o menu, conforme o sistema for inciar!
                Console.WriteLine("---------- OPÇÕES ----------");
                Console.WriteLine("1 - Ver Cardapio ");
                Console.WriteLine("2 - Registrar Venda");
                Console.WriteLine("3 - Relatorio do Produto");
                Console.WriteLine("4 - Relatorio por Dia");
                Console.WriteLine("5 - Resumo da Semana");
                Console.WriteLine("6 - Sair");
            }

            
        }
    }
}
