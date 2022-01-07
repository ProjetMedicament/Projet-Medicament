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
    /// Logique d'interaction pour AjoutRegion.xaml
    /// </summary>
    public partial class AjoutRegion : Window
    {   
        GstBdd gstbdd = new GstBdd();
        public AjoutRegion()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            if(TxtNomRégion.Text == "")
            {
                MessageBox.Show("Veuillez entrer le nom d'une région", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if(cboCodesSecteur.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir un secteur", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                gstbdd.AjouterRegion(TxtNomRégion.Text,(cboCodesSecteur.SelectedItem as Secteur).CodeSecteur);
                MessageBox.Show("Modification réussie", "GSB", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void btnRetour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboCodesSecteur.ItemsSource = gstbdd.getAllSecteurs();
            
        }
    }
}
