﻿using System;
using System.Linq;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChangeString changeString = new ChangeString();

            string palabra = "Palabra 123";

            Console.WriteLine(changeString.build(palabra));

            Console.Read();

        }



    
    }
}
