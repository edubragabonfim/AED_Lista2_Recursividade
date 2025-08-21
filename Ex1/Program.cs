// 1) Escreva um método recursivo que receba dois inteiros positivos a e n e calcule a elevado a n


// 2 elevado a 3 = (2 elevado a 2) * 2 
// 2 elevado a 2 = (2 elevado a 1) * 2
// 2 elevado a 1 = 2


namespace Ex1
{
    internal class Program
    {
        static int Potencia(int a, int n)
        {
            int result;
            if (n == 1) // caso base
            {
                result = a;
            }
            else
            {
                result = Potencia(a, n-1) * a; // Passo recursivo
            }
            return result;
        }

        static void Main(string[] args)
        {
            int potencia = Potencia(2, 4);
            Console.WriteLine($"Resultado: {potencia}");
        }
    }
}
