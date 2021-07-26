using FormationCS;
using System;

namespace generateur_mdp
{
    class Program
    {

        
        static void Main(string[] args)
        {
            const int NB_MDP = 3;

            int longueurmdp = outils.DemanderNombrePositifNonNul("Longueur du mdp : ");
            int choix = outils.DemanderNombreEntre("Vous voulez un mdp avec :\n" +
                "1 - minuscules \n" +
                "2 - minuscules et majuscules \n" +
                "3 - caractère et chiffres \n" +
                "4 - Tout \n" +
                "Votre choix : ", 1, 4);

            string minuscules = "azertyuiopqsdfghjklmlwxcvbn";
            string maj = minuscules.ToUpper();
            string chiffres = "123456789";
            string spec = "!@?#";
            string alphabet = "";

            //En fonction du choix du user, on construit le type d'alphabet
            if (choix == 1)
            {
                alphabet = minuscules;
            }
            else if(choix == 2)
            {
                alphabet = minuscules + maj;
            }
            else if(choix == 3)
            {
                alphabet = minuscules + maj + chiffres;
            }
            else
            {
                alphabet = minuscules + maj + chiffres + spec;
            }

            
            string mdp = "";
            int l = alphabet.Length;

            
            for (int j = 0; j<NB_MDP; j++) //Boucle sur chaque mot de passe
            {

                for (int k = 0; k < longueurmdp; k++) //Boucle pour construire chaque caractère du mdp en cours
                {
                    Random rand = new Random();
                    int i = rand.Next(0, l);
                    mdp += alphabet[i];
                }

                Console.WriteLine("Mot de passe : " + mdp);
                mdp = "";
            }
            
            
        }
    }
}
