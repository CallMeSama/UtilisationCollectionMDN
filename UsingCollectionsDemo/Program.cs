using System;
using System.Collections;

namespace UsageCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList lstEtudiant = new SortedList();
            Console.WriteLine("Bienvenue dans votre programme de saisie de données des informations des étudiants");
            Console.WriteLine("Veuillez saisir le nombre d'étudiants à enregistrer");
            int nombreEtudiant = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisir les informations des etudiants : ");
            for (int i = 0; i < nombreEtudiant; i++)
            {
                Console.WriteLine("Etudiant " + (i + 1));
                Console.WriteLine("Saisir le nom de l'étudiant : ");
                string nom = Console.ReadLine();
                Console.WriteLine("Saisir le prénom de l'étudiant : ");
                string prenom = Console.ReadLine();
                Console.WriteLine("Saisir le numéro d'ordre de l'étudiant : ");
                string no = Console.ReadLine();
                Console.WriteLine("Saisir la note du contrôle continu de l'étudiant : ");
                string noteCC = Console.ReadLine();
                Console.WriteLine("Saisir la note du devoir de l'étudiant : ");
                string noteDevoir = Console.ReadLine();
                Etudiant etudiant = new Etudiant()
                {
                    Nom = nom,
                    PreNom = prenom,
                    NO = no,
                    NoteCC = noteCC,
                    NoteDevoir = noteDevoir
                };
                lstEtudiant.Add(etudiant.NO, etudiant);
                Console.WriteLine("Les informations de l'étudiant sont : ");
                Console.WriteLine($"Nom : {etudiant.Nom}, Prénom : {etudiant.PreNom}, Numéro : {etudiant.NO}, Note du contrôle continu : {etudiant.NoteCC}, Note du devoir : {etudiant.NoteDevoir}");
            }
        }
    }
}
