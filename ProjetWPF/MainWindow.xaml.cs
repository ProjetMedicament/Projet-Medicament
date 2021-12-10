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
using ProjetWPF.Vues;

namespace ProjetWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnVisiteurs_Click(object sender, RoutedEventArgs e)
        {
            Visiteurs pvisiteurs = new Visiteurs(); 
            pvisiteurs.ShowDialog();
        }

        private void btnAjoutRegion_Click(object sender, RoutedEventArgs e)
        {
            AjoutRegion pajoutregion = new AjoutRegion();
            pajoutregion.ShowDialog();
        }

        private void btnAjoutVisiteur_Click(object sender, RoutedEventArgs e)
        {
            AjoutVisiteur pajoutvisiteur = new AjoutVisiteur();
            pajoutvisiteur.ShowDialog();
        }

        private void btnAjoutRegionAVisiteur_Click(object sender, RoutedEventArgs e)
        {
            AjoutRegionAVisiteur pajoutregionavisiteur = new AjoutRegionAVisiteur();
            pajoutregionavisiteur.ShowDialog();
        }

        private void btnStats_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRegions_Click(object sender, RoutedEventArgs e)
        {
            Régions pregions = new Régions();
            pregions.ShowDialog();
        }
    }
}
