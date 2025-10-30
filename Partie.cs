using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Partie
    {

        int id;
        DateTime date;
        double score;

        int idjoueur;
        int idjeu;

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Score { get => score; set => score = value; }
        public int Idjoueur { get => idjoueur; set => idjoueur = value; }
        public int Idjeu { get => idjeu; set => idjeu = value; }


        public void demarer()
        {
            JeuMB j = new JeuMB();
            j.genererSecret();
            Console.WriteLine("Le secret a été généré. Devinez le nombre à 4 chiffres avec des chiffres uniques.");
            int essais = 0;
            string resultat = "";
            while (resultat != "4M0B")
            {
                Console.Write("Entrez votre proposition (4 chiffres uniques) : ");
                string prop = Console.ReadLine()!;
                essais++;
                resultat = j.comparer(prop);
                Console.WriteLine($"Résultat : {resultat}");
            }

        }
    }
}
