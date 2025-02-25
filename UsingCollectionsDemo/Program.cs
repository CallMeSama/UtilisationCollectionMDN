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
                double noteCC = double.Parse(Console.ReadLine());
                Console.WriteLine("Saisir la note du devoir de l'étudiant : ");
                double noteDevoir = double.Parse(Console.ReadLine());
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

            Console.WriteLine("Veuillez choisir le nombre de lignes par page (entre 1 et 15) : ");
            int lignesParPage = int.Parse(Console.ReadLine());
            if (lignesParPage < 1 || lignesParPage > 15)
            {
                lignesParPage = 5;
            }

            int totalEtudiants = lstEtudiant.Count;
            int totalPages = (int)Math.Ceiling((double)totalEtudiants / lignesParPage);
            double moyenneClasse = 0;

            for (int page = 1; page <= totalPages; page++)
            {
                Console.WriteLine($"Page {page}/{totalPages}");
                for (int i = (page - 1) * lignesParPage; i < page * lignesParPage && i < totalEtudiants; i++)
                {
                    Etudiant etudiant = (Etudiant)lstEtudiant.GetByIndex(i);
                    double moyenne = etudiant.NoteCC * 0.33 + etudiant.NoteDevoir * 0.67;
                    moyenneClasse += moyenne;
                    Console.WriteLine($"Numéro : {etudiant.NO}, Nom : {etudiant.Nom}, Prénom : {etudiant.PreNom}, NoteCC : {etudiant.NoteCC}, NoteDevoir : {etudiant.NoteDevoir}, Moyenne : {moyenne}");
                }
                Console.WriteLine("Appuyez sur une touche pour continuer...");
                Console.ReadKey();
            }

            moyenneClasse /= totalEtudiants;
            Console.WriteLine($"Moyenne de la classe : {moyenneClasse}");
            Console.WriteLine("Appuyez sur une touche pour sortir...");
            Console.ReadKey();
        }
    }
}
