using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class IHM
    {
         string choix = "";
        UserManager um;

        public IHM()
        {
            um = new UserManager();
        }

        public IHM(UserManager userManager)
        {
            um = userManager;
        }

        public string Choix { get => choix; set => choix = value; }

        public void Menu()
        {
            Console.WriteLine("1- Ajouter un utilisateur");
            Console.WriteLine("2- Lister les utilisateurs");
            Console.WriteLine("3- Authentifier un utilisateur");
            Console.WriteLine("4- Chercher un utilisateur");
            Console.WriteLine("5- Quitter");

            Console.WriteLine("6- Jeu");

            Console.Write("Choix : ");
        }

        public void Menu2()
        {
            
            Console.WriteLine("3- Authentification");
          
            
        }
        public void start()
        {
            Choix = Console.ReadLine()!;
            switch (Choix)
            {
                case "1":
                    Console.WriteLine("Ajouter un utilisateur");
                    Console.Write("Id: ");
                    int id = int.Parse(Console.ReadLine()!);
                    Console.Write("Nom: ");
                    string nom = Console.ReadLine()!;
                    Console.Write("Mot de passe: ");
                    string pass = Console.ReadLine()!;
                    Console.Write("Role: ");
                    string role = Console.ReadLine()!;
                    um.addUser(id, nom, pass,role);

                    break;
                case "2":
                    Console.WriteLine("Lister les utilisateurs");
                    List<User> us = um.getUsers();
                    foreach (User u in us)
                    {
                        Console.WriteLine($"Id: {u.Id}, Name: {u.Name}, Password: {u.Password}, Role: {u.Role}");
                    }
                    break;
                case "3":
                    Console.WriteLine("Authentifier un utilisateur");
                    break;
                case "4":
                    Console.WriteLine("Chercher un utilisateur");
                    break;
                case "5":
                    Console.WriteLine("Quitter");
                    break;
                case "6":
                    Console.WriteLine("Jeu");
                    Partie p=new Partie();
                    JeuMB j=new JeuMB();
                    j.genererSecret();
                    Console.WriteLine("Le secret a été généré. Devinez le nombre à 4 chiffres avec des chiffres uniques.");
                    int essais = 0;
                    string resultat = "";
                    while (resultat!="4M0B")
                    { 
                        Console.Write("Entrez votre proposition (4 chiffres uniques) : ");
                        string prop = Console.ReadLine()!;
                        essais++;
                         resultat = j.comparer(prop);
                        Console.WriteLine($"Résultat : {resultat}");
                    }
                    break;

                default:
                    Console.WriteLine("Choix invalide");
                    break;

            }
            Console.Write("Choix : ");
        }
        }
}
