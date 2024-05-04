
namespace Exercicio6PilhaFilaNotaAlunos
{
    internal class Nota
    {
        float nota1;
        float nota2;
        int matricula;
        Nota proximo;

        public Nota(float nota1, float nota2, int matricula)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.matricula = matricula;
            this.proximo = null;
        }

        public void setNota1(float nota1)
        {
            this.nota1 = nota1;
        }

        public float getNota1()
        {
            return this.nota1;
        }

        public void setNota2(float nota2)
        {
            this.nota2 = nota2;
        }

        public float getNota2()
        {
            return this.nota2;
        }

        public int getMatricula()
        {
            return this.matricula;
        }

        public void setNext(Nota auxNota)
        {
            this.proximo = auxNota;
        }

        public Nota getNext()
        {
            return this.proximo;
        }

        public override string? ToString()
        {
            return $"\nMatricula: {this.matricula}\nNota 1: {this.nota1}\nNota 2: {this.nota2}";
        }
    }




}
