namespace Ex5
{
    internal class Program
    {
        static int ContarNegativos(int[] array, int n)
        {
            if (n == 0)
                return 0;

            int atual = array[n - 1] < 0 ? 1 : 0;

            return atual + ContarNegativos(array, n - 1);
        }

        static void Main(string[] args)
        {
            int[] numeros = { -5, 10, -3, 7, -1, 0, 8 };
            int tamanho = numeros.Length;

            int quantidadeNegativos = ContarNegativos(numeros, tamanho);

            Console.WriteLine("Quantidade de números negativos: " + quantidadeNegativos);
        }
    }
}
