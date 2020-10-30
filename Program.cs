using System;

namespace pim_2semestre
{
    class Program
    {
        public static void BemVindo()
        {
            Console.WriteLine("Bem vindo ao nosso evento, é um prazer tê-lo conosco!");
        }

        static void Main(string[] args)
        {
            int[] prof = new int[20];
            int[] pcd = new int[5];
            int[] aluno = new int[75];
            int input = 0;
            string name;
            string date = DateTime.Now.ToString("dd-MM-yyyy -" + " HH:mm:ss");
            int contP = 0;
            int contPcd = 21;
            int contA = 26;
            int cont = 0;
            int cont2 = 0;


            bool loop = true;
            while (loop)
            {

                BemVindo();

                Console.WriteLine("\r\nOlá, vamos iniciar seu cadastro!");

                Console.WriteLine("Qual seu nome?");
                name = Console.ReadLine();
                Console.Clear();

                Console.WriteLine(name + " qual seria o ingresso desejado?");
                Console.WriteLine("");



                Console.WriteLine("[Digite 1] - Professor(a) ou convidado(a) do palestrante");
                Console.WriteLine("[Digite 2] - Portadores de necessidades especiais ");
                Console.WriteLine("[Digite 3] - Aluno(a)");
                input = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (input == 1 && contP > 19)
                {
                    Console.WriteLine("");
                    Console.WriteLine("!!!!!! Assentos indisponiveis para Professores !!!!!!");
                    Console.WriteLine("");

                    input = 4;
                }

                if (input == 2 && cont > 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("!!!!!! Assentos indisponiveis para Portadores de necessidades especiais  !!!!!!");
                    Console.WriteLine("");
                    input = 4;
                }

                if (input == 3 && cont2 > 74)
                {
                    Console.WriteLine("");
                    Console.WriteLine("!!!!!! Assentos indisponiveis para Alunos !!!!!!");
                    Console.WriteLine("");
                    input = 4;
                }

                switch (input)
                {
                    case 1:

                        prof[contP] = contP;

                        if (contP < 10)
                        {
                            Console.WriteLine("Professor(a): " + name + "\r\nFileira: 1 " + "\r\nAssento:" + (contP + 1) + "\r\nRegistrado em: " + date);

                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (contP > 9 && contP < 20)
                        {
                            Console.WriteLine("Professor(a): " + name + "\r\nFileira: 2 " + "\r\nAssento:" + (contP + 1) + "\r\nRegistrado em: " + date);

                            Console.ReadKey();
                            Console.Clear();
                        }

                        contP++;
                        if (contP >= 20)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("!!!!!! Assentos indisponiveis para Professores !!!!!!");
                            Console.WriteLine("");

                        }

                        break;

                    case 2:
                        pcd[cont] = contPcd;


                        if (contPcd > 20 && contPcd < 26)
                        {
                            Console.WriteLine("Cliente Vip :) : " + name + "\r\nFileira: 3 " + "\r\nAssento:" + (contPcd) + "\r\nRegistrado em: " + date);

                            Console.ReadKey();
                            Console.Clear();
                        }
                        cont++;
                        contPcd++;

                        if (cont == 5)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("!!!!!! Assentos indisponiveis para Portadores de necessidades especiais !!!!!!");
                            Console.WriteLine("");

                        }

                        break;

                    case 3:
                        aluno[cont2] = contA;

                        if (contA > 25 && contA < 31)
                        {
                            Console.WriteLine("Aluno(a): " + name + "\r\nFileira: 3 " + "\r\nAssento:" + (contA) + "\r\nRegistrado em: " + date);

                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (contA > 30 && contA < 41)
                        {
                            Console.WriteLine("Aluno(a): " + name + "\r\nFileira: 4 " + "\r\nAssento:" + (contA) + "\r\nRegistrado em: " + date);

                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (contA > 40 && contA < 51)
                        {
                            Console.WriteLine("Aluno(a): " + name + "\r\nFileira: 5 " + "\r\nAssento:" + (contA) + "\r\nRegistrado em: " + date);

                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (contA > 50 && contA < 61)
                        {
                            Console.WriteLine("Aluno(a): " + name + "\r\nFileira: 6 " + "\r\nAssento:" + (contA) + "\r\nRegistrado em: " + date);

                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (contA > 60 && contA < 71)
                        {
                            Console.WriteLine("Aluno(a): " + name + "\r\nFileira: 7 " + "\r\nAssento:" + (contA) + "\r\nRegistrado em: " + date);

                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (contA > 70 && contA < 81)
                        {
                            Console.WriteLine("Aluno(a): " + name + "\r\nFileira: 8 " + "\r\nAssento:" + (contA) + "\r\nRegistrado em: " + date);

                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (contA > 80 && contA < 91)
                        {
                            Console.WriteLine("Aluno(a): " + name + "\r\nFileira: 9 " + "\r\nAssento:" + (contA) + "\r\nRegistrado em: " + date);

                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (contA > 90 && contA < 101)
                        {
                            Console.WriteLine("Aluno(a): " + name + "\r\nFileira: 10 " + "\r\nAssento:" + (contA) + "\r\nRegistrado em: " + date);

                            Console.ReadKey();
                            Console.Clear();
                        }

                        cont2++;
                        contA++;

                        if (cont2 == 75)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("!!!!!! Assentos indisponiveis para Alunos !!!!!!");
                            Console.WriteLine("");
                        }

                        break;

                    case 4:

                        Console.WriteLine("!!!! Opção Invalida !!!! ");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                }
            }
        }
    }
}

