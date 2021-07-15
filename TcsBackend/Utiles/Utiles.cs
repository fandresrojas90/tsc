using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TcsBackend.Utiles
{
    public class Utiles
    {
        public static dynamic words(string parrafo)
        {
            if (parrafo == "")
            {
                return "El parrafo es obligatorio";
            }
            else
            {
                IEnumerable<string> words = GetWordList(parrafo);
                var result = words
                    .GroupBy(x => x)
                    .Select(group => new { Word = group.Key, Count = group.Count() })
                    .OrderByDescending(x => x.Count).ToList();
                return result;
            }

        }

        private static IEnumerable<string> GetWordList(string linea)
        {
            return linea.Split(' ').Where(st => !st.Equals(""));
        }

        public static string metodoRaro()
        {
            string[] letras = { "W", "A", "E", "F", "L", "H", "C", "J", "O", "O", "M", "T", "E" };
            int n = letras.Length;
            int izq = 0, der = 0, aux = 0;
            string salida = "";
            for (int i = 0; i < n; i++)
            {
                if (aux > n)
                    break;
                der = aux + 1;
                while (der >= izq)
                {
                    if (der == izq)
                    {
                        salida += letras[aux];
                        aux = aux + izq;
                    }
                    der--;
                }
                izq++;
            }
            return salida;
        }

    }
}
