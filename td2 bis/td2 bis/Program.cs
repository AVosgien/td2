using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace td2_bis
{
    class Program
    {
        static void AfficherMois(string[] mois)
        {
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(mois[i]);
            }
        }
        static void Main(string[] args)
        {

            string[] mois = new string[12];
            mois[0] = "Janvier";
            mois[1] = "Février";
            mois[2] = "Mars";
            mois[3] = "Avril";
            mois[4] = "Mai";
            mois[5] = "Juin";
            mois[6] = "Juillet";
            mois[7] = "Août";
            mois[8] = "Septembre";
            mois[9] = "Octobre";
            mois[10] = "Novembre";
            mois[11] = "Décembre";

            string boucle = "o";

            while (boucle == "o"){

            Console.WriteLine("Choisir");
            Console.WriteLine("1: Lister les 12 mois");
            Console.WriteLine("2: Lister en rouge mois avec un R");
            Console.WriteLine("3: Lister les 12 mois avec leurs numéros");

            Console.WriteLine();

            string choix = Console.ReadLine();
            
            Console.WriteLine();

                switch (choix)
                {
                    case "1":
                        AfficherMois(mois);
                        break;

                    case "2":
                        for (int i = 0; i < 12; i++)
                        {
                            if (mois[i].Contains("R") || mois[i].Contains("r"))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }

                            Console.WriteLine(mois[i]);

                            if (mois[i].Contains("R") || mois[i].Contains("r"))
                            {
                                Console.ResetColor();
                            }
                        }
                        break;

                    case "3":
                        {
                            for (int i = 0; i < 12; i++)
                            {
                                Console.WriteLine((i + 1) + " " + mois[i]);
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Nombre Inutilisé");
                        break;

                }
                Console.WriteLine();
                Console.WriteLine("Continuer? (o/n)");
                Console.WriteLine();

                boucle = Console.ReadLine();
            }
        Console.ReadKey();
        }
    }
}
