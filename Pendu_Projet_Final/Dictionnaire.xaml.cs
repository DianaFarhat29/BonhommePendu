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
    /// Logique d'interaction pour Dictionnaire.xaml
    /// </summary>
    /// 

    public partial class Dictionnaire : Window
    {
        private MainWindow mainWindow;

        public Dictionnaire()
        {
            InitializeComponent();
            ActualiserDataGridDictionnaire();
        }

        // Bouton Ajouter
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string mot = txt_box_mot.Text; 
            string langue = ((ComboBoxItem)combo_box_langue.SelectedItem).Content.ToString();
            string niveau = ((ComboBoxItem)combo_box_niveau.SelectedItem).Content.ToString();

            // Vérification si le mot est entré
            if (string.IsNullOrWhiteSpace(mot))
            {
                MessageBox.Show("Veuillez entrer un mot à ajouter.");
                return;
            }

            // Vérification si le mot existe déjà dans la base de données
            using (var context = new PenduContext())
            {
                var motExistant = context.Mots.FirstOrDefault(m => m.MotDictionnaire.ToLower() == mot.ToLower());

                if (motExistant != null)
                {
                    MessageBox.Show("Ce mot existe déjà dans le dictionnaire.");
                    return;
                }

                // Création de l'objet Mot
                Mot motAAjouter = new Mot(mot, langue, niveau);

                // Ajout du mot dans la base de données
                context.Mots.Add(motAAjouter);
                context.SaveChanges();
            }

            // Mise à jour du DataGrid
            ActualiserDataGridDictionnaire();

            MessageBox.Show("Le mot a été ajouté avec succès.");

            // Réinitialisation des champs
            txt_box_mot.Text = "ex. Éléphant"; 
            combo_box_langue.SelectedIndex = 0;
            combo_box_niveau.SelectedIndex = 0;
        }

        // Bouton Accueil
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (mainWindow == null)
                mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        // Bouton Supprimer
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var motASupprimer = datagrid_dictionnaire.SelectedItem as Mot;

            // Dans le cas où aucun mot n'est sélectionné
            if (motASupprimer == null)
            {
                MessageBox.Show("Veuillez sélectionner un mot à supprimer dans la liste de mots.");
                return;
            }

            MessageBoxResult réponse = MessageBox.Show("Confirmez-vous la suppression du mot sélectionné?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            // Dans le cas ou l'utilisateur confirme la suppresion du mot sélectionné
            if (réponse == MessageBoxResult.Yes)
            {
                // Suppression du mot dans la base de données
                using (var context = new PenduContext())
                {
                    context.Mots.Attach(motASupprimer);
                    context.Mots.Remove(motASupprimer);
                    context.SaveChanges();
                }

                // Mise à jour du DataGrid
                ActualiserDataGridDictionnaire();
            }
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

        // Méthode pour actualiser le DataGrid
        private void ActualiserDataGridDictionnaire()
        {
            using (var context = new PenduContext())
            {
                datagrid_dictionnaire.ItemsSource = context.Mots.ToList();
            }

        }

        // Méthode pour gérer le focus sur le TextBox
        private void txt_box_mot_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txt_box_mot.Text == "ex. Éléphant") 
            {
                txt_box_mot.Text = "";
            }
        }
    }
}
