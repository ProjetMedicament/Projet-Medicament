using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetier
{
    public class Visiteurs
    {
        private int matricule;
        private string nomVisiteur;
        private string prenomVisiteur;
        private string adresseVisiteur;
        private string codePostal;
        private string villeVisiteur;
        private DateTime dateEmbauche;
        private Secteur leSecteur;
        private Labo leLabo;

        public Visiteurs(int unMatricule, string unNom, string unPrenom,string uneAdresse,string unCP,string uneVille,DateTime uneDate,Secteur unSecteur,Labo unLabo)
        {
            Matricule = unMatricule;
            NomVisiteur = unNom;
            PrenomVisiteur = unPrenom;
            AdresseVisiteur = uneAdresse;
            CodePostal = unCP;
            VilleVisiteur = uneVille;
            DateEmbauche = uneDate;
            LeSecteur = unSecteur;
            LeLabo = unLabo;
        }

        public int Matricule { get => matricule; set => matricule = value; }
        public string NomVisiteur { get => nomVisiteur; set => nomVisiteur = value; }
        public string PrenomVisiteur { get => prenomVisiteur; set => prenomVisiteur = value; }
        public string AdresseVisiteur { get => adresseVisiteur; set => adresseVisiteur = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }
        public string VilleVisiteur { get => villeVisiteur; set => villeVisiteur = value; }
        public DateTime DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }
        public Secteur LeSecteur { get => leSecteur; set => leSecteur = value; }
        public Labo LeLabo { get => leLabo; set => leLabo = value; }
    }
}
