using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Les cinémas SimplonTheater vous demandent de mettre au point un logiciel simple pour permettre aux utilisateurs de
choisir des places de cinéma dans une salle au format fixe : 8 rangées avec dans chaque rangée 9 sièges.

Les utilisateurs doivent pouvoir spécifier la rangée dans laquelle ils veulent être placés ainsi que le nombre de places
à réserver.

Une fois la rangée choisie et le nombre de places spécifiées, vous devez vérifier s'il y a effectivement assez de place
sur la rangée :
- Si tel est le cas, vous affichez la représentation de la salle à l'utilisateur et proposez une nouvelle saisie.
- Sinon, vous spécifiez à l'utilisateur qu'il n'y a plus de place sur la rangée ou qu'il n'y en a pas assez.
*/

namespace Reservation_theatre
{
    class Program
    {
        // Création d'un tableau d'entiers à deux dimensions (8 rangées et 9 places) rangMax et placeMax pour définir les dimensions du tableau

        static int rangMax = 8;
        static int placeMax = 9;
        static int[,] salle = new int[rangMax, placeMax];

        static void Main(string[] args)
        {

            int continuer = 1;

            // Boucle permettant plusieurs saisies
            do
            {
                Accueil();

                // Affichage de la salle
                // Parcours des lignes du tableau
                for (int i = 0; i < rangMax; i++)
                {

                    // Nulérotation des lignes du tableau (rangs)
                    Console.Write("Rang " + i + " ");

                    // Parcours des collonnes du tableau (places)
                    for (int j = 0; j < placeMax; j++)
                    {
                        // Affichage du status des places ([_] = disponnible / [X] = réservée)
                        string status_aff = "[_]";

                        if (salle[i, j] != 0)
                        {
                            status_aff = "[X]";
                        }
                        Console.Write(status_aff);
                    }
                    Console.WriteLine();


                }

                Console.WriteLine("\n1 - Continuer \n\n2 - Finir \n");
                continuer = Convert.ToInt16(Console.ReadLine());

            } while (continuer == 1);

        }

        // Methode Accueil et refresh console
        static void Accueil()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\nBienvenue au thêatre Simlpon. \n");

        }

    }
}
