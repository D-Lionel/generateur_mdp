using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class outils //Classe servant à "stocker" les fonctions utiles pour le programme principal
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue);
        }

        public static int DemanderNombreEntre(string question, int min, int max)
        {
            int nombre = DemanderNombre(question);
            if (nombre >= min && nombre <= max)
            {
                return nombre;
            }
            else
            {
                Console.WriteLine($"Erreur : entrez un nombre entre {min} et {max}");
                Console.WriteLine();
                return DemanderNombreEntre(question, min, max);
            }

        }

        public static int DemanderNombre(string question)
        {
            int longueurInt = 0;
            Console.Write(question);
            while (true)
            {
                string longueurstr = Console.ReadLine();
                try
                {
                    longueurInt = int.Parse(longueurstr);
                    break;
                }
                catch
                {
                    Console.WriteLine("Entrez un nombre valide");
                }
            }


            return longueurInt;
        }
    }
}
