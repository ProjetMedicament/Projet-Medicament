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
    /// Logique d'interaction pour AjoutRegionAVisiteur.xaml
    /// </summary>
    public partial class AjoutRegionAVisiteur : Window
    {
        GstBdd gstbdd = new GstBdd();
        public AjoutRegionAVisiteur()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            if (cboMatricules.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir un matricule visiteur", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (TxtDateAssignation.SelectedDate == null)
            {
                MessageBox.Show("Veuillez choisir une date d'assignation", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (cboCodesRégions.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une région", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (TxtPosteVisiteur.Text == "")
            {
                MessageBox.Show("Veuillez entrer un poste", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                gstbdd.AjouterRegionAVisiteur((cboMatricules.SelectedItem as ClassesMetier.Visiteurs).Matricule,TxtDateAssignation.SelectedDate.Value,(cboCodesRégions.SelectedItem as Region).CodeRegion,TxtPosteVisiteur.Text);

            }
        }

        private void btnRetour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboCodesRégions.ItemsSource = gstbdd.getAllRegions();
            cboMatricules.ItemsSource = gstbdd.getAllVisiteurs();
        }
    }
}
