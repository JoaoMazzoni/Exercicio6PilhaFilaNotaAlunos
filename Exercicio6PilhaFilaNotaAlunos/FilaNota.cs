using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6PilhaFilaNotaAlunos
{
    internal class FilaNota
    {
        Nota headFila;
        Nota tailFila;

        public FilaNota()
        {
            this.headFila = null;
            this.tailFila = null;
        }

        public void push(Nota auxNota)
        {
            if (Empty())
            {
                headFila = auxNota;
                tailFila = auxNota;
            }
            else
            {
                tailFila.setNext(auxNota);
                tailFila = auxNota;
            }

        }

        public bool Empty()
        {
            return headFila == null;
        }

        public Nota pop()
        {
            if (Empty())
            {
                Console.WriteLine("Fila Vazia! Impossível Remover.");
                Console.Write("Pressione qualquer tecla para continuar:");
                Console.ReadKey();
                return null;
            }
            else
            {
                Nota notaRemovida = headFila;
                headFila = headFila.getNext();
                if (headFila == null)
                {
                    tailFila = null;
                }

                return notaRemovida;
            }
        }

        public void imprimirTodos()
        {
            if (headFila == null)
            {
                Console.WriteLine("\nNão há notas cadastradas.");
                Console.Write("\nPressione qualquer tecla para continuar: ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nNotas na fila:");
                Nota notaAtual = headFila;
                while (notaAtual != null)
                {
                    Console.WriteLine(notaAtual);
                    notaAtual = notaAtual.getNext();
                }
            }
        }



        public void calcularMedia(int matricula)
        {
            Nota matriculaAtual = headFila;

            while (matriculaAtual != null)
            {
                if (matriculaAtual.getMatricula() == matricula)
                {
                    if(matriculaAtual.getNota1() == 0  && matriculaAtual.getNota2() == 0)
                    {
                        Console.WriteLine("\nO aluno não possui notas ou não existe.");
                        Console.ReadLine();
                    }
                    else 
                    { 
                    Console.WriteLine("\nA media das notas é: {0:0.00}", (matriculaAtual.getNota1() + matriculaAtual.getNota2()) / 2);
                    }
                    }
                matriculaAtual = matriculaAtual.getNext();
            }
        }
        public bool removerAluno(int matricula)
        {
            if (tailFila.getMatricula() == matricula)
            {
                if (tailFila.getNota1() == 0 && tailFila.getNota2() == 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("\nO aluno não pode ser removido por possuir notas cadastradas!");
                    Console.Write("Pressione qualquer tecla para continuar: ");
                    Console.ReadLine();
                    return false;

                }
            }
            else
            {
                Console.WriteLine("\nO aluno não pode ser removido, devido a ordem da pilha!");
                Console.WriteLine("O aluno não está no topo da pilha.");
                Console.Write("Pressione qualquer tecla para continuar: ");
                Console.ReadLine();
                return false;
            }

        }

    }
}
