namespace Calculadora.Services
{
    using System.Collections;

    public class Calculadora
    {
        private Queue<string> historico;

        public Calculadora()
        {
            historico = new Queue<string>();
        }

        private void AtualizaHistorico(string operacao)
        {
            historico.Enqueue(operacao);

            if (historico.Count > 3)
            {
                historico.Dequeue();
            }
        }

        public float Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }
            float resultado = (float)num1 / num2;
            AtualizaHistorico($"{num1} / {num2} = {resultado}");

            return resultado;
        }

        public Queue<string> Historico()
        {
            return historico;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;

            AtualizaHistorico($"{num1} * {num2} = {resultado}");
            return resultado;
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;

            AtualizaHistorico($"{num1} + {num2} = {resultado}");
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;

            AtualizaHistorico($"{num1} - {num2} = {resultado}");
            return resultado;
        }
    }
}
