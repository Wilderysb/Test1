using System;
using System.Linq;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChangeString objChangeString = new ChangeString();
            CompleteRange objCompleteRange = new CompleteRange();

            string palabra = "Palabra 123";

            Console.WriteLine(objChangeString.build(palabra));

            var arrayNumeros = new int[]{1,2,3,5,6 };

            Console.WriteLine(objCompleteRange.build(arrayNumeros));


            Console.Read();

        }



    
    }
}
