using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetier
{
    public class Labo
    {
        private int codeLabo;
        private string nomLabo;
        private string chefVente;
        public Labo(int unCode, string unNom,string unChef)
        {
            CodeLabo = unCode;
            NomLabo = unNom;
            ChefVente = unChef;
        }

        public int CodeLabo { get => codeLabo; set => codeLabo = value; }
        public string NomLabo { get => nomLabo; set => nomLabo = value; }
        public string ChefVente { get => chefVente; set => chefVente = value; }
    }
}
