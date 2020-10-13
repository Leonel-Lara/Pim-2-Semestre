using System;

namespace pim_2semestre
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Bem vindo ao nosso evento, é um prazer tê-lo conosco!");

      int seat = 1;

      bool loop = true;
      while (loop)
      {
        int i = seat++;

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

            if (i > 5)
            {
              Console.WriteLine("Todos os assentos estão reservados!");
            }
            else
            {
              Console.WriteLine("Nome: " + name + "\r\nAssento: " + i + "\r\nRegistrado em: " + date);
            }

            break;

          case 2:
            Console.WriteLine("Saindo do sistema!");
            loop = false;
            break;
        }
      }
    }
  }
}
