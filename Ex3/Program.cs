namespace Ex3
{
    internal class Program
    {
        static void Converter(int n)
        {
            if (n == 1)
            {
                Console.Write(1);
            }
            else
            {
                Converter(n/2);
                Console.Write(n%2);
            }
        }

        static void Main(string[] args)
        {
            Converter(123);
        }
    }
}
