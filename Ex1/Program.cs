// 1) Escreva um método recursivo que receba dois inteiros positivos a e n e calcule a elevado a n

namespace Ex1
{
    internal class Program
    {
        static int Potencia(int a, int n)
        {
            int result;
            if (n == 1)
            {
                result = a;
            }
            else
            {
                result = Potencia(a, n-1) * a;
            }
            return result;
        }

        static void Main(string[] args)
        {
            int potencia = Potencia(3, 3);
            Console.WriteLine($"Resultado: {potencia}");
        }
    }
}
