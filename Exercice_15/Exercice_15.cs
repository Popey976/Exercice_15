using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_15
{
    class Exercice_15
    {
        static void Main(string[] args)
        {

                                    // Code_perso

            string phrase = "Bonjour à tous, vous allez bien ?";

            Console.WriteLine(phrase.Replace(' ', '_'));
            Console.ReadLine();



                                            // code_correction

            // Saisie de la phrase
            Console.WriteLine("Entrez une phrase : ");
            string phrase = Console.ReadLine();
            // Remplacement des espaces par _
            string newphrase = phrase.Replace(' ', '_');
            // Affichage de la nouvelle phrase
            Console.WriteLine(newphrase);
            Console.ReadLine();

        }
    }
}
