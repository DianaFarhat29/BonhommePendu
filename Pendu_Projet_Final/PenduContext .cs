using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu_Projet_Final
{
    internal class PenduContext : DbContext
    {

        // Constructeur
        public PenduContext() : base("name=Jeu_De_Pendu_DB")
        {
        }

        // Encapsulation
        public DbSet<Mot> Mots { get; set; }
        public DbSet<HistoriqueEnregistrement> Historiques { get; set; }
        public DbSet<PreferencesEnregistrement> Preferences { get; set; }
    }
}
