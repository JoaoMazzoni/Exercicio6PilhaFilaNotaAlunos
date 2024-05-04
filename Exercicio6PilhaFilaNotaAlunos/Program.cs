using System;
using System.Xml;

namespace Exercicio6PilhaFilaNotaAlunos
{
    class Program
    {
        static int cont = 0;
        static void Main(string[] args)
        {
            PilhaAluno pilha = new PilhaAluno();
            FilaNota fila = new FilaNota();
            int opc;

            do
            {
                Console.Clear();
                Console.WriteLine("\n---- MENU ----\n");
                Console.WriteLine("|1| - Inserir Aluno e Notas");
                Console.WriteLine("|2| - Media do Aluno");
                Console.WriteLine("|3| - Remover Aluno");
                Console.WriteLine("|4| - Imprimir Alunos");
                Console.WriteLine("|5| - Sair");
                Console.Write("\nInforme a opção desejada: ");
                opc = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opc)
                {

                    case 1:
                        pilha.push(cadastrarAluno());
                        fila.push(cadastrarNota());
                        break;
                    case 2:
                        int aux;
                        Console.Write("Informe o número de matrícula do Aluno: ");
                        aux = int.Parse(Console.ReadLine());
                        if (aux > cont || aux <= 0)
                        {
                            Console.WriteLine("\nO número de matrícula informado não existe!");
                            Console.Write("\nPressione qualquer tecla para retornar ao menu: ");
                        }

                        fila.calcularMedia(aux);
                        Console.ReadKey();
                        break;

                    case 3:
                        if (pilha.Empty())
                        {

                            Console.WriteLine("Pilha Vazia! Impossível Remover.");
                            Console.WriteLine("\nPressione qualquer tecla para continuar:");
                            Console.ReadKey();
                        }
                        else
                        {
                            int aux2;
                            Console.Write("Informe o número de matrícula do Aluno: ");
                            aux2 = int.Parse(Console.ReadLine());
                            if (aux2 > cont || aux2 <= 0)
                            {
                                Console.WriteLine("\nO número de matrícula informado não existe!");
                                Console.Write("\nPressione qualquer tecla para retornar ao menu: ");
                            }
                            if (fila.removerAluno(aux2) == true)
                            {
                                pilha.pop();
                                Console.WriteLine($"\nO aluno correspondente foi removido.");
                                Console.ReadLine();
                            }
                        }
                        break;

                    case 4:
                        pilha.ImprimirTodos(); fila.imprimirTodos();
                        Console.ReadLine();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\nOpcão inválida!");
                        Console.ReadLine();
                        break;
                }
            } while (opc != 5);

        }

        public static Aluno cadastrarAluno()
        {
            string nome;
            int matricula;
            Console.Write("Informe o nome do aluno: ");
            nome = Console.ReadLine();
            cont++;
            matricula = cont;

            return new Aluno(nome, matricula);
        }


        public static Nota cadastrarNota()
        {
            float nota1, nota2;
            int matricula;
            Console.Write("Informe a nota 1 do aluno: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Informe a nota 2 do aluno: ");
            nota2 = float.Parse(Console.ReadLine());
            matricula = cont;

            return new Nota(nota1, nota2, matricula);

        }





    }
}
