using System;


namespace ProjetoLanchonetesenac
{
    internal class cardapio
    {   
        static void MostrarMenu()
        {
            Console.WriteLine("=========  *LANCHONETE SENAC* ==================");  // LINHA 10 A LINHA 18 OPÇOES DO CARDAPIO 
            Console.WriteLine("========= OPÇÕES ==============");
            Console.WriteLine("1- VER CARDÁPIO ");
            Console.WriteLine("2 - REGISTRAR VENDA");
            Console.WriteLine("3 - RELATÓRIO DO PRODUTO");
            Console.WriteLine("4-  RELATÓRIO POR DIA ");
            Console.WriteLine("5- RESUMO DA SEMANA");
            Console.WriteLine("0 - SAIR ");
            Console.WriteLine("OPÇÃO:");
              
            Console.WriteLine("Digite uma opção:");
            string opcao= Console.ReadLine();
        }
    }
}
  static void MostrarCardapio()
{
    Console.WriteLine("=========  *CARDÁPIO* ==================");  // LINHA 24 A LINHA 29 OPÇOES DO CARDAPIO 
    Console.WriteLine("1. Coxinha | R$ 7,00");
    Console.WriteLine("2. Pão de queijo | R$ 5,00");
    Console.WriteLine("3. Suco | R$ 6,00");
    Console.WriteLine("4. Café | R$ 4,00");
    Console.WriteLine("5. Bolo | R$ 8,00 ");
      Console.WriteLine("6.Sair");
       Console.WriteLine(" Digite uma opção:");
      
      int opcoes = int.Parse(Console.ReadLine());
      
      string opcao = Console.ReadLine();

      

            

      
      double[] precos = { 7.0, 5.0, 6.0, 4.0, 8.0 }; // CRIANDO VETOR DE PREÇOS E DIAS 
string[] dias = { "Seg", "Ter", "Qua", "Qui", "Sex" };


static bool CodigoValido( int codigo, int tamanho)   //ADICIONANDO UM MÉTODO AONDE 
{
  return codigo >= 0 && codigo <= tamanho;

    Console.ReadLine();
    
    CodigoValido(2,produtos.Length);


}
  



}
