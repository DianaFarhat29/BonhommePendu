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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pendu_Projet_Final
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Preferences preferences;
        private Dictionnaire dictionnaire;
        private Jeu_de_Pendu jeu_De_Pendu;
        private Historique historique;

        public MainWindow()
        {
            InitializeComponent();
            var demarrageApp = new DemarrageApplication();
            demarrageApp.InitializeDatabase();
        }

        // Bouton Préférences
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (preferences == null)
                preferences = new Preferences();
            preferences.Show();
            this.Hide();
        }

        // Bouton Historique

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (historique == null)
                historique = new Historique();
            historique.Show();
            this.Hide();
        }

        // Bouton Jouer
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (jeu_De_Pendu == null)
                jeu_De_Pendu = new Jeu_de_Pendu();
            jeu_De_Pendu.Show();
            this.Hide();
        }

        // Bouton Dictionnaire
        private void btn_dictionnaire_Click(object sender, RoutedEventArgs e)
        {
            if (dictionnaire == null)
                dictionnaire = new Dictionnaire();
            dictionnaire.Show();
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

        
    }
}
