using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu_Projet_Final
{
    internal class DemarrageApplication
    {
        public void InitializeDatabase()
        {
            using (var context = new PenduContext())
            {
                if (!DoesDataExist(context))
                {
                    AddDefaultData(context);
                }
            }
        }

        private bool DoesDataExist(PenduContext context)
        {
            // Vérifiez si des données spécifiques existent
            return context.Mots.Any() && context.Historiques.Any();
        }

        private void AddDefaultData(PenduContext context)
        {
            if (!context.Mots.Any())
            {
                AddDefaultDictionnaireData(context);
            }

            if (!context.Historiques.Any())
            {
                AddDefaultHistoriqueData(context);
            }

            context.SaveChanges();
        }

        private void AddDefaultDictionnaireData(PenduContext context)
        {
            var mots = new List<Mot>
            {
                // Enregistrements des mots
                new Mot { MotDictionnaire = "Chien", Langue = "Français", Niveau = "Facile" },
                new Mot { MotDictionnaire = "Fraise", Langue = "Français", Niveau = "Facile" },
                new Mot { MotDictionnaire = "Chien", Langue = "Français", Niveau = "Moyen" },
                new Mot { MotDictionnaire = "Dog", Langue = "Anglais", Niveau = "Facile" },
                new Mot { MotDictionnaire = "Cat", Langue = "Anglais", Niveau = "Facile" },
                new Mot { MotDictionnaire = "Unbelievable", Langue = "Anglais", Niveau = "Difficile" },
                new Mot { MotDictionnaire = "Anticonstitutionnelle", Langue = "Français", Niveau = "Difficile" },
                new Mot { MotDictionnaire = "Rhum", Langue = "Français", Niveau = "Moyen" },
                new Mot { MotDictionnaire = "Lynx", Langue = "Français", Niveau = "Difficile" },
                new Mot { MotDictionnaire = "Rock", Langue = "Français", Niveau = "Difficile" },
                new Mot { MotDictionnaire = "Thym", Langue = "Français", Niveau = "Difficile" },
                new Mot { MotDictionnaire = "Azimut", Langue = "Français", Niveau = "Difficile" },
                new Mot { MotDictionnaire = "Basson", Langue = "Français", Niveau = "Difficile" },
                new Mot { MotDictionnaire = "Coccyx", Langue = "Français", Niveau = "Difficile" },
                new Mot { MotDictionnaire = "Bird", Langue = "Anglais", Niveau = "Facile" },
                new Mot { MotDictionnaire = "Food", Langue = "Anglais", Niveau = "Facile" },
                new Mot { MotDictionnaire = "Snow", Langue = "Anglais", Niveau = "Facile" },
                new Mot { MotDictionnaire = "Island", Langue = "Anglais", Niveau = "Moyen" },
                new Mot { MotDictionnaire = "Mountain", Langue = "Anglais", Niveau = "Moyen" },
                new Mot { MotDictionnaire = "Ground", Langue = "Anglais", Niveau = "Moyen" },
                new Mot { MotDictionnaire = "Irregardless", Langue = "Anglais", Niveau = "Difficile" },
                new Mot { MotDictionnaire = "Nonplussed", Langue = "Anglais", Niveau = "Difficile" },
                new Mot { MotDictionnaire = "Disinterested", Langue = "Anglais", Niveau = "Difficile" },
                new Mot { MotDictionnaire = "Enormity", Langue = "Anglais", Niveau = "Difficile" },
                new Mot { MotDictionnaire = "Whom", Langue = "Anglais", Niveau = "Difficile" },
                new Mot { MotDictionnaire = "Unabashed", Langue = "Anglais", Niveau = "Difficile" },

            };

            context.Mots.AddRange(mots);
        }

        private void AddDefaultHistoriqueData(PenduContext context)
        {
            var historiques = new List<HistoriqueEnregistrement>
            {
                // Enregistrements historiques 
                new HistoriqueEnregistrement("UNBELIEVABLE", 115, 1, new DateTime(2023, 8, 7, 14, 44, 18), "00:00:27", "SUCCES"),
                new HistoriqueEnregistrement("UNABASHED", 75, 4, new DateTime(2023, 8, 7, 17, 12, 52), "00:00:23", "SUCCES"),
                new HistoriqueEnregistrement("BIRD", 35, 1, new DateTime(2023, 8, 8, 17, 56, 53), "00:00:18", "SUCCES"),
                new HistoriqueEnregistrement("FOOD", 25, 2, new DateTime(2023, 8, 8, 17, 58, 25), "00:00:48", "SUCCES"),
                new HistoriqueEnregistrement("SNOW", 0, 6, new DateTime(2023, 8, 8, 18, 01, 33), "00:00:12", "ECHEC"),
                new HistoriqueEnregistrement("FOOD", 25, 4, new DateTime(2023, 8, 8, 18, 02, 18), "00:00:55", "SUCCES"),
                new HistoriqueEnregistrement("CAT", 45, 0, new DateTime(2023, 8, 8, 18, 02, 29), "00:01:00", "SUCCES"),
                new HistoriqueEnregistrement("CAT", 45, 0, new DateTime(2023, 8, 8, 18, 07, 40), "00:00:03", "SUCCES"),
                new HistoriqueEnregistrement("CAT", 45, 0, new DateTime(2023, 8, 8, 18, 07, 57), "00:00:03", "SUCCES"),
                new HistoriqueEnregistrement("BIRD", 30, 2, new DateTime(2023, 8, 8, 18, 08, 17), "00:00:14", "SUCCES"),
                new HistoriqueEnregistrement("FOOD", 25, 4, new DateTime(2023, 11, 28, 10, 24, 35), "00:00:08", "SUCCES"),
                new HistoriqueEnregistrement("ENORMITY", 0, 6, new DateTime(2023, 11, 28, 10, 45, 48), "00:00:17", "ECHEC"),
                new HistoriqueEnregistrement("ENORMITY", 0, 6, new DateTime(2023, 11, 28, 10, 46, 58), "00:00:11", "ECHEC")
            };

            context.Historiques.AddRange(historiques);
        }
    }
}