using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetier
{
    public class SansSecteur
    {
        string nom;
        string prenom;

        public SansSecteur(string unNom,string unPrenom)
        {
            Nom = unNom;
            Prenom = unPrenom;
        }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
    }
}
