using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetier
{
    public class Region
    {
        private int codeRegion;
        private string nomRegion;
        private Secteur leSecteur;

        public Region(int unCode, string unNom,Secteur unSecteur)
        {
            CodeRegion = unCode;
            NomRegion = unNom;
            LeSecteur = unSecteur;
        }

        public int CodeRegion { get => codeRegion; set => codeRegion = value; }
        public string NomRegion { get => nomRegion; set => nomRegion = value; }
        public Secteur LeSecteur { get => leSecteur; set => leSecteur = value; }
    }
}
