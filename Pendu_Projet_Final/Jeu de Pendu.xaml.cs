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
using System.Windows.Threading;

namespace Pendu_Projet_Final
{
    /// <summary>
    /// Logique d'interaction pour Jeu_de_Pendu.xaml
    /// </summary>
    public partial class Jeu_de_Pendu : Window
    {
        private MainWindow mainWindow;
        private Preferences preferences;
        private Historique historique;
        private Mot motPartie;
        private List<char> lettresDevinees;
        private int nombreErreurs;
        private DateTime heureDebut;
        private string Temps;
        private int score = 0;
        private DispatcherTimer timer;

        public Jeu_de_Pendu()
        {
            InitializeComponent();
            DesactiverBoutonsLettres();
            // Initialisation de lettresDevinees
            lettresDevinees = new List<char>();

            // Initialisation du timer
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }

        // Bouton Debuter le jeu
        private void btn_debuter_jeu_Click(object sender, RoutedEventArgs e)
        {
            // Vérification s'il y a déjà une partie en cours
            if (lettresDevinees.Count > 0) 
            {
                MessageBoxResult confirmation = MessageBox.Show(
                    "Une partie est déjà en cours. Voulez-vous vraiment recommencer ?",
                    "Conon",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);

                if (confirmation == MessageBoxResult.Yes)
                {
                    RecommencerJeu();
                 
                }
            }
            else
            {
                RecommencerJeu();
            }
        }


        // Bouton Preferences
        private void btn_preferences_Click(object sender, RoutedEventArgs e)
        {
            if (preferences == null)
                preferences = new Preferences();
            preferences.Show();
            this.Hide();
        }

        // Bouton Accueil
        private void btn_accueil_Click(object sender, RoutedEventArgs e)
        {
            if (mainWindow == null)
                mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        // Bouton Historique
        private void btn_historique_Click(object sender, RoutedEventArgs e)
        {
            if (historique == null)
                historique = new Historique();
            historique.Show();
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

        private void ActualiserAffichageMot()
        {
            StringBuilder motAffiche = new StringBuilder();

            // Parcours de chaque lettre du mot
            foreach (char c in motPartie.MotDictionnaire)
            {
                // Convertion de la lettre en minuscule pour la comparaison
                char lettreMinuscule = Char.ToLower(c);

                // Vérifier si la lettre a été devinée
                if (lettresDevinees.Contains(lettreMinuscule))
                {
                    // Si lettre devinée, ajout de la lettre (en minuscule ou majuscule selon le mot original)
                    motAffiche.Append(c + " ");
                }
                else
                {
                    // Si non devinée, ajout d'un underscore
                    motAffiche.Append("_ ");
                }
            }

            // Mise à jour de l'affichage du mot
            TextBlock_mot_cache.Text = motAffiche.ToString();
        }

        // Méthode qui désactive les boutons de lettres
        private void DesactiverBoutonsLettres()
        {
            foreach (var control in contenant_lettres.Children)
            {
                if (control is Button bouton)
                {
                    bouton.IsEnabled = false;
                }
            }
        }

        // Méthode qui détermine le comportement des boutons de lettres
        private void Lettre_Click(object sender, RoutedEventArgs e)
        {
            Button boutonLettre = sender as Button;

            // Désactivation du bouton pour empêcher de multiples clics
            boutonLettre.IsEnabled = false;

            char lettreChoisie = Char.ToLower(boutonLettre.Content.ToString()[0]);

            // Dans le cas ou la partie est terminée, ne rien faire
            if (motPartie.MotDictionnaire.ToLower().All(c => lettresDevinees.Contains(Char.ToLower(c))) || nombreErreurs >= 6)
            {
                return;
            }

            if (motPartie.MotDictionnaire.ToLower().Contains(lettreChoisie))
            {
                if (!lettresDevinees.Contains(lettreChoisie))
                {
                    lettresDevinees.Add(lettreChoisie);
                }

                ActualiserAffichageMot();

                score += 10;
            }
            else
            {
                nombreErreurs++;
                ActualiserAffichagePendu();

                // Soustraction des points seulement si le score actuel est supérieur à 5
                if (score > 5)
                {
                    score -= 5;
                }
                else
                {
                    // Dans le cas ou le score est inférieur ou égal à 5, le fixer à 0
                    score = 0; 
                }
            }

            label_score.Content = score.ToString();
            VerifierFinDeJeu();
        }

        // Methode qui change l'image du pendu selon de nombreErreurs
        private void ActualiserAffichagePendu()
        {
            try
            {
                string nomImage = $"images/image{nombreErreurs}.png"; 
                image_Bonhomme_Pendu.Source = new BitmapImage(new Uri(nomImage, UriKind.Relative));

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de chargement d'image : {ex.Message}");
            }

        }

        // Méthode qui vérifie si la partie est terminée
        private void VerifierFinDeJeu()
        {
            // Vérification que toutes les lettres ont été devinées
            bool lettresDuMotDevinees = motPartie.MotDictionnaire.ToLower().All(c => lettresDevinees.Contains(Char.ToLower(c)));

            if (lettresDuMotDevinees)
            {
                // Arrêt du timer car la partie est terminée
                timer.Stop();

                // Enregistrement du résultat de la partie dans l'historique
                EnregistrerDansHistorique(true);

                MessageBox.Show("Vous avez gagné ! Vous avez trouvé le mot !");
                DesactiverBoutonsLettres();
                
            }
            // Dans le cas ou le nombre d'erreurs est supérieur ou égal à 6 (nombre max d'erreurs)
            else if (nombreErreurs >= 6)
            {
                // Arrêt du timer car la partie est terminée
                timer.Stop();

                // Enregistrement du résultat de la partie dans l'historique
                EnregistrerDansHistorique(false);

                MessageBox.Show($"Échec ! Le mot était : {motPartie.MotDictionnaire}.\nMeilleure chance prochaine fois!");
                DesactiverBoutonsLettres();

            }
        }

        // Méthode qui enregistre le résultat de la partie dans l'historique
        private void EnregistrerDansHistorique(bool estGagné)
        {
            var enregistrement = new HistoriqueEnregistrement
            {
                Mot = motPartie.MotDictionnaire,
                // Calcul du pointage
                Pointage = CalculerPointage(),
                Erreurs = nombreErreurs,
                Date = DateTime.Now,
                // Calcul du temps écoulé
                Temps = CalculerTempsÉcoule(),
                Resultat = estGagné ? "SUCCES" : "ECHEC"
            };

            using (var context = new PenduContext())
            {
                context.Historiques.Add(enregistrement);
                context.SaveChanges();
            }
        }

        // Méthode qui calcule le pointage
        private int CalculerPointage()
        {
            int pointsParLettre = 10;
            int penaliteParErreur = 5;

            int nombreLettresDevinees = lettresDevinees.Count;
            int totalPoints = nombreLettresDevinees * pointsParLettre - nombreErreurs * penaliteParErreur;

            // Bonus donnée si le mot est deviné au complet
            if (motPartie.MotDictionnaire.All(c => lettresDevinees.Contains(c)))
            {
                totalPoints += 2; 
            }

            // Vérification que le pointage ne soit pas négatif
            return Math.Max(totalPoints, 0); 
        }

        // Méthode qui calcule le temps écoulé
        private string CalculerTempsÉcoule()
        {
            TimeSpan dureePartie = DateTime.Now - heureDebut;
            // Format HH:MM:SS
            return dureePartie.ToString(@"hh\:mm\:ss");
        }

        // Méthode qui permet de mettre à jour le temps écoulé
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan dureePartie = DateTime.Now - heureDebut;
            label_temps_ecoule.Content = dureePartie.ToString(@"hh\:mm\:ss");
        }

        // Methode qui permet de recommencer une partie
        private void RecommencerJeu()
        {
            using (var context = new PenduContext())
            {
                // Réinitialisation du score, du temps et des erreurs
                score = 0;
                label_score.Content = score.ToString();
                heureDebut = DateTime.Now;
                timer.Start();
                nombreErreurs = 0;

                // Réinitialisation de lettresDevinees
                lettresDevinees.Clear();

                var preferences = context.Preferences.OrderByDescending(p => p.PreferencesId).FirstOrDefault();

                var motsListe = context.Mots
                    .Where(m => m.Langue == preferences.Langue && m.Niveau == preferences.Niveau)
                    .ToList();

               

                if (motsListe.Count > 0)
                {
                    Random random = new Random();
                    motPartie = motsListe[random.Next(motsListe.Count)];
                    lettresDevinees = new List<char>();

                    ActualiserAffichageMot();
                    ActualiserAffichagePendu();
                    ReactiverBoutonsLettres();
                }
                else
                {
                    MessageBox.Show("Aucun mot disponible correspondant à vos préférences. Veuillez ajouter des mots ou changer vos préférences.");
                    DesactiverBoutonsLettres();
                }
            } 
        }


        // Methode qui réactive les boutons de lettres
        private void ReactiverBoutonsLettres()
        {
            foreach (var control in contenant_lettres.Children)
            {
                if (control is Button bouton)
                {
                    // Réactivation du bouton
                    bouton.IsEnabled = true; 
                }
            }
        }

    }
}
