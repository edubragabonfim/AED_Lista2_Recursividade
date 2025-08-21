namespace Ex4
{
    internal class Program
    {
        static int MDC(int x, int y)
        {
            int result;
            if(x == y)
            {
                result = x;
            }
            else
            {
                if(x > y)
                {
                    result = MDC(x - y, y);
                }
                else
                {
                    result = MDC(y, x);
                }
            }
            return result;

        }
        static void Main(string[] args)
        {
            int resultado = MDC(30, 15);
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
