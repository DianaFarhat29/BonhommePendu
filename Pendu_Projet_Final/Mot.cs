using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu_Projet_Final
{
    internal class Mot
    {
        // Attributs
        [Key]
        public int MotId { get; set; }

        [Required]
        private string motDictionnaire;

        [Required]
        private string langue;

        [Required]
        private string niveau;

        // Constructeurs avec paramètres
        public Mot(string motDictionnaire, string langue, string niveau)
        {
            this.motDictionnaire = motDictionnaire;
            this.langue = langue;
            this.niveau = niveau;
        }

        // Constructeur sans paramètre
        public Mot()
        {
        }

        // Encapsulation
        public string MotDictionnaire { get => motDictionnaire; set => motDictionnaire = value; }
        public string Langue { get => langue; set => langue = value; }
        public string Niveau { get => niveau; set => niveau = value; }

        // ToString()
        public override string ToString()
        {
            return "Mot ID: " + MotId + "Mot : " + motDictionnaire + " Langue : " + langue + " Niveau : " + niveau;
        }


    }
}
