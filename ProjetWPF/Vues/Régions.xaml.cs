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
    /// Logique d'interaction pour Régions.xaml
    /// </summary>
    public partial class Régions : Window
    {
        GstBdd gstbdd = new GstBdd();
        public Régions()
        {
            InitializeComponent();
        }

        private void lstRégions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TxtNomRégion.Text = (lstRégions.SelectedItem as Region).NomRegion;
            cboCodesSecteur.SelectedValue = (lstRégions.SelectedItem as Region).LeSecteur.CodeSecteur;
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            if (TxtNomRégion.Text == "")
            {
                MessageBox.Show("Veuillez saisir une région", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (cboCodesSecteur.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir un secteur", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                gstbdd.UpdateRegion((lstRégions.SelectedItem as Region).CodeRegion,(cboCodesSecteur.SelectedItem as Secteur).CodeSecteur,TxtNomRégion.Text);
            }
        }

        private void btnRetour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstRégions.ItemsSource = gstbdd.getAllRegions();
            cboCodesSecteur.ItemsSource = gstbdd.getAllSecteurs();
        }
    }
}
