namespace CheckifSquare.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CheckifSquare
            Console.WriteLine("Enter The Width : ");
            Double Width=Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Enter The Length : ");
            Double Length = Convert.ToDouble(Console.ReadLine());
            if (Width == Length)
            {
                Console.WriteLine("This is a Squre");
            }
            else
            {
                Console.WriteLine("This is not a Squre");

            }
            #endregion
        }
    }
}