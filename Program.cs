using System;

namespace pim_2semestre
{
  class Program
  {
    static void Main(string[] args)
    {

      //int seat = 1;

      int linha, coluna;
      int[] col = new int[2];
      int[] lin = new int[2];

      bool loop = true;
      while (loop)
      {
        //int i = seat++;

        Console.WriteLine("Bem vindo ao nosso evento, é um prazer tê-lo conosco!");

        int option = 0;
        Console.WriteLine("Digite '1' para se cadastrar! '2' para sair");
        option = Convert.ToInt32(Console.ReadLine());

        string date = DateTime.Now.ToString("dd-MM-yyyy");
       
        switch (option)
        {
          case 1:

            string name;
            Console.WriteLine("Olá, vamos iniciar seu cadastro!");

            Console.WriteLine("Qual seu nome?");
            name = Console.ReadLine();

            Console.WriteLine("Escolha primeiramente a linha de seu assento:");
            linha = Convert.ToInt32(Console.ReadLine());


            if (lin[linha] == 1)
            {
              Console.WriteLine("Assento ocupado!");
            }
            else
            {
              for (int k = 1; k < 2; k++)
              {
                if (linha == k)
                {
                  lin[k] = 1;
                }
              }

            Console.WriteLine("Escolha coluna");
            coluna = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j < 2; j++)
            {
              if (col[coluna] == 1)
              {
                Console.WriteLine("Assento ocupado!");
              }
              else
              {
                if (coluna == j)
                {
                  col[j] = 1;
                  
                  Console.WriteLine("Nome: " + name + "\r\nColuna: " + coluna + "\r\nLinha:" + linha +"\r\nRegistrado em: " + date);
                }

              }
            }
          }
           
            break;

          case 2:
            Console.WriteLine("Saindo do sistema!");
            loop = false;
            break;

          case 3:

            break;
          default:
            Console.WriteLine("Tecla inválida");
            break;
        }
      }
    }
  }
}
