

namespace Exercicio6PilhaFilaNotaAlunos
{
    internal class Aluno
    {
        string nome;
        int matricula;
        Aluno anterior;

        public Aluno(string nome, int matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.anterior = null;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;

        }

        public void setMatricula(int numero)
        {
            this.matricula = numero;
        }

        public int getMatricula()
        {
            return this.matricula;
        }

        public void setAnterior(Aluno anterior)
        {

            this.anterior = anterior;
        }

        public Aluno getAnterior()
        {
            return this.anterior;
        }

        public override string? ToString()
        {
            return $"\nNome: {this.nome} \nMatrícula: {this.matricula}";
        }
    }



}
