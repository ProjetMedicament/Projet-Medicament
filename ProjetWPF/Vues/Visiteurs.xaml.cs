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
    /// Logique d'interaction pour Visiteurs.xaml
    /// </summary>
    public partial class Visiteurs : Window
    {
        GstBdd gstbdd = new GstBdd();
        public Visiteurs()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstVisiteurs.ItemsSource = gstbdd.getAllVisiteurs();
            cboCodeSecteurs.ItemsSource = gstbdd.getAllSecteurs();
            cboCodesLabos.ItemsSource = gstbdd.getAllLabos();
        }

        private void lstVisiteurs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstVisiteurs.SelectedItem != null)
            {
                TxtNomVisiteur.Text = (lstVisiteurs.SelectedItem as ClassesMetier.Visiteurs).NomVisiteur;
                TxtPrenomVisiteur.Text = (lstVisiteurs.SelectedItem as ClassesMetier.Visiteurs).PrenomVisiteur;
                TxtAdresseVisiteur.Text = (lstVisiteurs.SelectedItem as ClassesMetier.Visiteurs).AdresseVisiteur;
                TxtCPVisiteur.Text = (lstVisiteurs.SelectedItem as ClassesMetier.Visiteurs).CodePostal;
                cboCodeSecteurs.SelectedItem = (lstVisiteurs.SelectedItem as ClassesMetier.Visiteurs).LeSecteur.CodeSecteur;
                TxtVilleVisiteur.Text = (lstVisiteurs.SelectedItem as ClassesMetier.Visiteurs).VilleVisiteur;
                TxtDEVisiteur.SelectedDate = (lstVisiteurs.SelectedItem as ClassesMetier.Visiteurs).DateEmbauche;
                cboCodesLabos.SelectedItem = (lstVisiteurs.SelectedItem as ClassesMetier.Visiteurs).LeLabo.CodeLabo;
            }
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {   
            if (lstVisiteurs.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir un visiteur", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (TxtNomVisiteur.Text == "")
            {
                MessageBox.Show("Veuillez saisir un nom", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (TxtPrenomVisiteur.Text == "")
            {
                MessageBox.Show("Veuillez saisir un prénom", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (TxtAdresseVisiteur.Text == "")
            {
                MessageBox.Show("Veuillez saisir une adresse", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (TxtCPVisiteur.Text == "")
            {
                MessageBox.Show("Veuillez saisir un code postal", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (cboCodeSecteurs.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir un secteur", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (TxtVilleVisiteur.Text == "")
            {
                MessageBox.Show("Veuillez choisir une ville", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
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
                gstbdd.UpdateVisiteurs(TxtNomVisiteur.Text, TxtPrenomVisiteur.Text, TxtAdresseVisiteur.Text, TxtCPVisiteur.Text,(cboCodeSecteurs.SelectedItem as Secteur).CodeSecteur, TxtVilleVisiteur.Text,TxtDEVisiteur.SelectedDate.Value.Year, TxtDEVisiteur.SelectedDate.Value.Month, TxtDEVisiteur.SelectedDate.Value.Day,TxtDEVisiteur.SelectedDate.Value.TimeOfDay,(cboCodesLabos.SelectedItem as Labo).CodeLabo,(lstVisiteurs.SelectedItem as ClassesMetier.Visiteurs).Matricule.ToString());
                lstVisiteurs.ItemsSource = gstbdd.getAllVisiteurs();
                MessageBox.Show("Modification réussie", "GSB", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnRetour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
