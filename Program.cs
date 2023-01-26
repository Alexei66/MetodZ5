namespace NewAppMetogZ5
{
    internal class Program
    {
        static int CheckValue()
        {
            int correctValue;
            while (!int.TryParse(Console.ReadLine(), out correctValue))
            {
                Console.WriteLine("Неправильно! Попробуй еще раз.");
            }
            return correctValue;
        }
        /// <summary>
        /// Функция Аккермана
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        static int A(int n, int m)
        {
            if (n == 0)
            {
                return m + 1;
            }
            else if ((n != 0) &&( m ==0))
            {
                return A(n - 1, 1);
            }
            else
            {
                return A(n - 1, A(n, m - 1));
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введи число n: ");
            int n = CheckValue();
            Console.Write("Введи число m: ");
            int m = CheckValue();

            int res = A(n, m);
            Console.WriteLine(res);

            
        }
    }
}