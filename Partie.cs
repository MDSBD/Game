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
    }
}
