using System;
using System.Globalization;

class URI
{
    class Program
    {
        static void Main(string[] args)
        {

            int x= int.Parse (Console.ReadLine());


            double sum = 0;
            double cont = 0;
            while (x >= 0)
            {
                sum = sum + x;
                cont = cont + 1;
                x = int.Parse(Console.ReadLine());
            }
            double resultado = (double) sum / cont;
            Console.WriteLine(resultado.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}