﻿using System;
using System.Linq;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChangeString objChangeString = new ChangeString();

            string palabra = "Palabra 123";

            Console.WriteLine(objChangeString.build(palabra));

            Console.Read();

        }



    
    }
}
