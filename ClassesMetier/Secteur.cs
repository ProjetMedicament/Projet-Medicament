using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetier
{
    public class Secteur
    {
        private int codeSecteur;
        private string libSecteur;
        public Secteur(int unCode, string unLibelle)
        {
            CodeSecteur = unCode;
            LibSecteur = unLibelle;
        }

        public int CodeSecteur { get => codeSecteur; set => codeSecteur = value; }
        public string LibSecteur { get => libSecteur; set => libSecteur = value; }

    }
}
