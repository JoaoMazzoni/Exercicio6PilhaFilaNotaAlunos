
namespace Exercicio6PilhaFilaNotaAlunos
{
    internal class PilhaAluno
    {
        Aluno headPilha;

        public PilhaAluno()
        {
            this.headPilha = null;
            Console.WriteLine("\nPilha de Alunos Criada!");

        }

        public void push(Aluno auxAluno)
        {
            //Exemplo: Objeto Aluno1 vai ter como seu "anterior" o topo da pilha, e agora o topo da pilha vai ser o Aluno1 que entrou
            auxAluno.setAnterior(headPilha);
            headPilha = auxAluno;
        }

        public bool Empty()
        {
            return headPilha == null;
        }

        public Aluno pop()
        {
            if (Empty())
            {
                Console.WriteLine("Pilha Vazia! Impossível Remover.");
                Console.Write("Pressione qualquer tecla para continuar:");
                Console.ReadKey();
                return null;
            }
            else
            {
                Aluno alunoRemovido = headPilha;
                headPilha = headPilha.getAnterior();
                return alunoRemovido;
            }

        }
        public void ImprimirTodos()
        {
            if (headPilha == null)
            {
                Console.WriteLine("\nNão há alunos cadastrados.");
                Console.Write("\nPressione qualquer tecla para continuar: ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nAlunos cadastrados: ");
                Aluno atual = headPilha;
                while (atual != null)
                {
                    Console.WriteLine(atual.ToString());
                    atual = atual.getAnterior();
                }
            }
        }

    }
}
