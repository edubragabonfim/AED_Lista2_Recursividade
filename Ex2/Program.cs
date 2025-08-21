namespace Ex2
{
    internal class Program
    {
        static int SomaIntervalo(int x, int y)
        {
            int result;
            if (x == y)
            {
                result = x;
            }
            else
            {
                result = SomaIntervalo(x, y - 1) + y;
            }
            return result;
        }

        static void Main(string[] args)
        {
            int conta = SomaIntervalo(4, 7);
            Console.WriteLine($"Resultado: {conta}");
        }
    }
}
