using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu_Projet_Final
{
    internal class PreferencesEnregistrement
    {
        // Attributs
        [Key]
        public int PreferencesId { get; set; }

        [Required]
        private string langue;

        [Required]
        private string niveau;

        // Constructeurs avec paramètres
        public PreferencesEnregistrement(string langue, string niveau)
        {
            this.langue = langue;
            this.niveau = niveau;
        }

        // Constructeur sans paramètre
        public PreferencesEnregistrement()
        {
        }

        // Encapsulation
        public string Langue { get => langue; set => langue = value; }
        public string Niveau { get => niveau; set => niveau = value; }

        // ToString()
        public override string ToString()
        {
            return "Préférences ID: " + PreferencesId + "Langue : " + langue + " Niveau : " + niveau;
        }
    }
}
