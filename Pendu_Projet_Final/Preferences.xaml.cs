using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pendu_Projet_Final
{
    /// <summary>
    /// Logique d'interaction pour Preferences.xaml
    /// </summary>
    public partial class Preferences : Window
    {
        private MainWindow mainWindow;
        private Dictionnaire dictionnaire;

        public Preferences()
        {
            InitializeComponent();
            ChargementPreferences();
        }

        // Bouton Enregistrer
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string langueSelectionnee;
            string niveauSelectionne;

            // Vérification de la langue et du niveau sélectionné
            if (radio_btn_francais.IsChecked == true)
            {
                langueSelectionnee = "Français";
            }
            else
            {
                langueSelectionnee = "Anglais";
            }

            // Vérification du niveau sélectionné
            if (radio_btn_facile.IsChecked == true)
            {
                niveauSelectionne = "Facile";
            }
            else if (radio_btn_moyen.IsChecked == true)
            {
                niveauSelectionne = "Moyen";
            }
            else
            {
                niveauSelectionne = "Difficile";
            }

            // Création d'un objet de type PreferencesEnregistrement
            PreferencesEnregistrement preferencesEnregistrement = new PreferencesEnregistrement(langueSelectionnee, niveauSelectionne);

            // Ajout de l'objet dans la base de données
            using (var context = new PenduContext())
            {
                context.Preferences.Add(preferencesEnregistrement);
                context.SaveChanges();
            }

            MessageBox.Show("Préférences enregistrées.");
        }

        // Bouton Dictionnaire
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (dictionnaire == null)
                dictionnaire = new Dictionnaire();
            dictionnaire.Show();
            this.Hide();
        }

        // Bouton Accueil
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (mainWindow == null)
                mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        // Bouton Quitter
        private void btn_quitter_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment quitter?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                // Code pour fermer l'application
                Application.Current.Shutdown();
            }
        }

        // Chargement des préférences
        private void ChargementPreferences()
        {
            using (var context = new PenduContext())
            {
                var dernierePreferenceEnregistree = context.Preferences.OrderByDescending(p => p.PreferencesId).FirstOrDefault();
                if (dernierePreferenceEnregistree != null)
                {
                    radio_btn_francais.IsChecked = dernierePreferenceEnregistree.Langue == "Français";
                    radio_btn_anglais.IsChecked = dernierePreferenceEnregistree.Langue == "Anglais";
                    radio_btn_facile.IsChecked = dernierePreferenceEnregistree.Niveau == "Facile";
                    radio_btn_moyen.IsChecked = dernierePreferenceEnregistree.Niveau == "Moyen";
                    radio_btn_difficile.IsChecked = dernierePreferenceEnregistree.Niveau == "Difficile";
                }
            }
        }
    }

}
