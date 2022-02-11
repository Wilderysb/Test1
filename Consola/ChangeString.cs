using System;
using System.Collections.Generic;
using System.Text;

namespace Consola
{
    internal class ChangeString
    {
        public string build(string escrito) {

            var arrayAlfabeto = new string[] {"a","b","c","d","e","f","g",
                "h","i","j","k","l","m","n","ñ","o","p","q","r","s","t","u"
                ,"v","w","x","y","z"};

            var contador = 0;

            int indice;

            var escritoSplit = escrito.ToLower().ToCharArray();

            foreach (char c in escritoSplit)
            {

                indice = Array.IndexOf(arrayAlfabeto, c.ToString());

                if (indice >= 0)
                {
                    escritoSplit[contador] = char.Parse(arrayAlfabeto[indice + 1]);
                }


                contador++;
            }
            string.Join("", escritoSplit);
        }
    }

    
}
