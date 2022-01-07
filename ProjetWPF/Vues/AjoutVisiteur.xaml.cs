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
using System.Windows.Shapes;
using GstBDD;
using ClassesMetier;

namespace ProjetWPF.Vues
{
    /// <summary>
    /// Logique d'interaction pour AjoutVisiteur.xaml
    /// </summary>
    public partial class AjoutVisiteur : Window
    {
        GstBdd gstbdd = new GstBdd();
        public AjoutVisiteur()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            if (TxtNomVisiteur.Text == "")
            {
                MessageBox.Show("Veuillez entrer un nom", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (TxtPrenomVisiteur.Text == "")
            {
                MessageBox.Show("Veuillez entrer un prénom", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (TxtAdresseVisiteur.Text == "")
            {
                MessageBox.Show("Veuillez entrer une adresse", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (cboCodeSecteurs.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir un secteur", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (TxtVilleVisiteur.Text == "")
            {
                MessageBox.Show("Veuillez entrer un poste", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (TxtDEVisiteur.SelectedDate == null)
            {
                MessageBox.Show("Veuillez choisir une date", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (cboCodesLabos.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir un laboratoire", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                gstbdd.AjouterVisiteur(TxtNomVisiteur.Text, TxtPrenomVisiteur.Text, TxtAdresseVisiteur.Text, TxtCPVisiteur.Text,(cboCodeSecteurs.SelectedItem as Secteur).CodeSecteur, TxtVilleVisiteur.Text, TxtDEVisiteur.SelectedDate.Value.Year, TxtDEVisiteur.SelectedDate.Value.Month, TxtDEVisiteur.SelectedDate.Value.Day, TxtDEVisiteur.SelectedDate.Value.TimeOfDay,(cboCodesLabos.SelectedItem as Labo).CodeLabo);
                MessageBox.Show("Modification réussie", "GSB", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnRetour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboCodeSecteurs.ItemsSource = gstbdd.getAllSecteurs();
            cboCodesLabos.ItemsSource = gstbdd.getAllLabos();
        }
    }
}
