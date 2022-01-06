using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetier
{
    class Travailler
    {
        private DateTime dateAssignement;
        private string libPoste;
        private Visiteurs leVisiteur;
        private Region laRegion;

        public Travailler(DateTime uneDate, string unLibelle,Visiteurs unVisiteur,Region uneRegion)
        {
            DateAssignement = uneDate;
            LibPoste = unLibelle;
            LeVisiteur = unVisiteur;
            LaRegion = uneRegion;
            
        }

        public DateTime DateAssignement { get => dateAssignement; set => dateAssignement = value; }
        public string LibPoste { get => libPoste; set => libPoste = value; }
        public Visiteurs LeVisiteur { get => leVisiteur; set => leVisiteur = value; }
        public Region LaRegion { get => laRegion; set => laRegion = value; }
    }
}
