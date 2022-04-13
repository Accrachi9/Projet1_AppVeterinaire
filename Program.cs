using System;
namespace Projet_1
{
    class Program
    {

        // Zone d'exécution du logiciel

        static string entree = "";
        static int numEntree;
        static void Main(string[] args)
        {
            Box box = new Box();
            bool isActiveLogiciel = true;
            while (isActiveLogiciel)
            {
                Console.WriteLine("********************************************************************");
                Console.WriteLine("******LOGICIEL DE GESSION DE LA LISTE DES ANIMAUX EN PENSIONS*******");
                Console.WriteLine("********************************************************************");
                Console.WriteLine("********************************************************************");
                Console.WriteLine("Faire un choix parmis les huit options suivantes:");
                Console.WriteLine("1- Ajouter un animal");
                Console.WriteLine(" \t ID, type d'animal, son nom, son âge, son poids, la couleur (rouge, bleu et violet uniquement)");
                Console.WriteLine("\t le nom du propriétaire");
                Console.WriteLine("2- Voir la liste de tous les animaux en pension");
                Console.WriteLine("3- Voir la liste de tous les propriétaires");
                Console.WriteLine("4- Voir le nombre total d'animaux en pension");
                Console.WriteLine("5- Voir le poids total de tous les animaux en pension");
                Console.WriteLine("6- Voir la liste des animaux d'une couleur (rouge, bleu ou violet)");
                Console.WriteLine("7- Retirer un animal de la liste");
                Console.WriteLine("8- Quitter");
                Console.WriteLine("Votre option?");
                entree = Console.ReadLine();
                numEntree = int.Parse(entree);
                switch (numEntree)
                {
                    case 1:
                        box.MenuVeterinaire(numEntree);
                        break;
                    case 2:
                        box.MenuVeterinaire(numEntree);
                        break;
                    case 3:
                        box.MenuVeterinaire(numEntree);
                        break;
                    case 4:
                        box.MenuVeterinaire(numEntree);
                        break;
                    case 5:
                        box.MenuVeterinaire(numEntree);
                        break;
                    case 6:
                        box.MenuVeterinaire(numEntree);
                        break;
                    case 7:
                        box.MenuVeterinaire(numEntree);
                        break;
                    case 8:
                        box.MenuVeterinaire(numEntree);
                        break;
                    default:
                        Console.WriteLine("Le choix n'est pas valide...");
                        break;
                }
                
            } 

        }
    }

    // Zone de traitement des différentes tâches (Mes fonctions)
    class Box
    {



        // Décaration de mes variables globales
        static int nombreAnimal = 0;
        static int poidsTotAnimaux = 0;

        static string[,] listeAnimal = new string[10, 7]; // Mon tableau d'animaux


        // Menu 1: Fonction qui ajoute un animal au tableau d'animaux
        public void AjouterAnimal()
        {

            if(nombreAnimal < 10) // test si le tableau n'est pas plein
            {
                Console.WriteLine("Veiller saisir le type de l'animal");
                string typAnimal = Console.ReadLine();

                Console.WriteLine("Veiller saisir le nom de l'animal");
                string nomAnimal = Console.ReadLine();

                Console.WriteLine("Veiller saisir l'age de l'animal (En nombre entier)");
                string ageAnimal = Console.ReadLine();

                Console.WriteLine("Veiller saisir le poids de l'animal (En nombre entier)");
                string poidsAnimal = Console.ReadLine();

                // Controler les couleurs admissibles
                string couleurAnimal;
                do
                {
                    Console.WriteLine("Veiller saisir la couleur de l'animal (rouge ou bleu ou violet)");
                    couleurAnimal = Console.ReadLine();

                } while ((couleurAnimal != "rouge") && (couleurAnimal != "bleu") && (couleurAnimal != "violet"));



                Console.WriteLine("Veiller saisir le nom du propriétaire de l'animal");
                string propiAnimal = Console.ReadLine();

                // Tableau des infos remplies en entrée et l'indentifiant allant de 0 à 9
                int ID = nombreAnimal;
                string[] nouveauAnimal = new string[] { Convert.ToString(ID), typAnimal, nomAnimal, ageAnimal, poidsAnimal, couleurAnimal, propiAnimal };
                // Ajout l'animale à la ligne nombreAnimal (première fois nombreAnimal=0)
                for (int i = 0; i < 7; i++)
                {

                    listeAnimal[nombreAnimal, i] = nouveauAnimal[i];
                }

                poidsTotAnimaux = poidsTotAnimaux + int.Parse(poidsAnimal);
                nombreAnimal = nombreAnimal + 1;

            }
            else
            {
                Console.WriteLine("Le nombre total d'adimaux admise est 10");
            }
           

        }

        // Menu 2: Fonction qui affiche la liste des animaux
        public void AfficherTousAnimaux()
        {

            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("   ID   |   TYPE ANIMAL   |   NOM   |   AGE   |   POIDS   |   COULEUR   |   PROPRIÉTAIRE   |");
            Console.WriteLine("--------------------------------------------------------------------------------------------");

            for (int i = 0; i <= nombreAnimal; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("   " + listeAnimal[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine(" &&&&&&&&&&&&&&&&&&&&&&  UNE AUTRE TRAITEMENT?  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("--------------------------------------------------------------------------------------------");

        }

        // Menu 3: Fonction qui affiche la liste des propriétaires des animaux
        public void AfficherProprietaires()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine(" |   PROPRIÉTAIRE |");
            Console.WriteLine("--------------------------------------------------------------------------------------------");

         // Affiche la clonne 6 contenant les propriétaires
                for (int i = 0; i <= nombreAnimal; i++)
                {
                    Console.Write( "   " + listeAnimal[i, 6] + "  \n ");
                }
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine(" &&&&&&&&&&&&&&&&&&&&&&  UNE AUTRE TRAITEMENT?  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
        }

        // Menu 4: Fonction qui affiche le nombre total des animaux  
        public void AfficherTotalAnimaux()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine(" |   NOMBRE ANIMAUX |");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine( "   " + nombreAnimal);
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine(" &&&&&&&&&&&&&&&&&&&&&&  UNE AUTRE TRAITEMENT?  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
        }

        // Menu 5: Fonction qui affiche le poids total des animaux
        public void AfficherPoidsTotalAnimaux()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine(" |   POIDS TOTAL |");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine( "   " + poidsTotAnimaux);
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine(" &&&&&&&&&&&&&&&&&&&&&&  UNE AUTRE TRAITEMENT?  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
        }

        // Menu 6: Fonction qui affiche la liste des animaux selon la couleur 
        public void AfficherAnimauxParCouleur()
        {
            string couleurAnimal;
            do
            {
                Console.WriteLine("Veiller saisir la couleur des animaux à afficher (rouge ou bleu ou violet)");
                couleurAnimal = Console.ReadLine();

            } while ((couleurAnimal != "rouge") && (couleurAnimal != "bleu") && (couleurAnimal != "violet"));

            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("   ID   |   TYPE ANIMAL   |   NOM   |   AGE   |   POIDS   |   COULEUR   |   PROPRIÉTAIRE   |");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            
            for (int i = 0; i <= nombreAnimal; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (listeAnimal[i, 5] == couleurAnimal)
                    {
                        Console.Write( "   " + listeAnimal[i, j] + "\t");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine(" &&&&&&&&&&&&&&&&&&&&&&  UNE AUTRE TRAITEMENT?  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("--------------------------------------------------------------------------------------------");

        }

        // Menu 7: Fonction qui retire un animal du tableau d'animaux
        public void RetirerAnimal()
        {
            string ID_suprime;
            do
            {
                Console.WriteLine("Veiller saisir le numéro (ID) de l'animal à suprimer de la liste (de 0 à "+nombreAnimal+")");
                ID_suprime = Console.ReadLine();

            } while (int.Parse(ID_suprime) > nombreAnimal );

            int IDsuprime = int.Parse(ID_suprime);
            if (IDsuprime == 0)
            {
                for (int i = 0; i < 7; i++)
                {

                    listeAnimal[0, i] = null;
                }

                Console.WriteLine("--------------------------------------------------------------------------------------------");
                Console.WriteLine("   ID   |   TYPE ANIMAL   |   NOM   |   AGE   |   POIDS   |   COULEUR   |   PROPRIÉTAIRE   |");
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                Console.WriteLine("Liste vide");
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                Console.WriteLine(" &&&&&&&&&&&&&&&&&&&&&&  UNE AUTRE TRAITEMENT?  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
                Console.WriteLine("--------------------------------------------------------------------------------------------");
            }
            else
            {
                for (int i = IDsuprime + 1; i <= nombreAnimal; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {

                        listeAnimal[i-1, j] = listeAnimal[i, j];
                    }
                }
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                Console.WriteLine("   ID   |   TYPE ANIMAL   |   NOM   |   AGE   |   POIDS   |   COULEUR   |   PROPRIÉTAIRE   |");
                Console.WriteLine("--------------------------------------------------------------------------------------------");

                for (int i = 0; i <= nombreAnimal; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write("   " + listeAnimal[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                // après suppression diminuer le nombre d'animal
                nombreAnimal = nombreAnimal - 1;
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                Console.WriteLine(" &&&&&&&&&&&&&&&&&&&&&&  UNE AUTRE TRAITEMENT?  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
                Console.WriteLine("--------------------------------------------------------------------------------------------");
            }

        }

        // Menu de gestion des différentes traitement
        public void MenuVeterinaire(int monChoix)
        {
            switch (monChoix)
            {
                case 1: AjouterAnimal();
                    break;
                case 2: AfficherTousAnimaux();
                    break;
                case 3: AfficherProprietaires();
                    break;
                case 4: AfficherTotalAnimaux();
                    break;
                case 5: AfficherPoidsTotalAnimaux();
                    break;
                case 6: AfficherAnimauxParCouleur();
                    break;
                case 7: RetirerAnimal();
                    break;
                case 8: Environment.Exit(0);
                    break;
                default: Console.WriteLine("Le choix n'est pas valide...");
                    break;
            }
        }


    }
}