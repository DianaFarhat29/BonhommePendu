using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pendu_Projet_Final
{
    public class HistoriqueEnregistrement
    {
        // Attributs
        [Key]
        public int HistoriqueId { get; set; }

        [Required]
        private string mot;

        [Required]
        private int pointage;

        [Required]
        private int erreurs;

        [DataType(DataType.Date)]
        private DateTime date;

        [Required]
        private string temps;

        [Required]
        private string resultat;

        // Constructeurs avec paramètres
        public HistoriqueEnregistrement(string mot, int pointage, int erreurs, DateTime date, string temps, string resultat)
        {
            this.mot = mot;
            this.pointage = pointage;
            this.erreurs = erreurs;
            this.date = date;
            this.temps = temps;
            this.resultat = resultat;
        }

        // Constructeur sans paramètre
        public HistoriqueEnregistrement()
        {
        }

        // Encapsulation
        public string Mot { get => mot; set => mot = value; }
        public int Pointage { get => pointage; set => pointage = value; }
        public int Erreurs { get => erreurs; set => erreurs = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Temps { get => temps; set => temps = value; }
        public string Resultat { get => resultat; set => resultat = value; }
            
        // ToString()
        public override string ToString()
        {
            return "Historique ID: " + HistoriqueId + "Mot : " + mot + " Pointage : " + pointage + " Erreurs : " + erreurs + " Date : " + date + " Temps : " + temps + " Resultat : " + resultat;
        }



    }
}
