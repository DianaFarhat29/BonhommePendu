using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logique d'interaction pour Historique.xaml
    /// </summary>
    public partial class Historique : Window
    {
        private MainWindow mainWindow;
        public ObservableCollection<HistoriqueEnregistrement> ListeHistoriques { get; private set; }

        public Historique()
        {
            InitializeComponent();
            ListeHistoriques = new ObservableCollection<HistoriqueEnregistrement>();
            ChargerHistoriques();
            // Lier l'ObservableCollection au DataGrid
            datagrid_dictionnaire.ItemsSource = ListeHistoriques;
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

        // Charger les données de l'historique depuis la base de données
        private void ChargerHistoriques()
        {
            using (var context = new PenduContext())
            {
                foreach (var historique in context.Historiques.ToList())
                {
                    ListeHistoriques.Add(historique);
                }
            }
        }


    }
}
