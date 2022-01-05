using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClassesMetier;

namespace GstBDD
{
    public class GstBdd
    {
        private MySqlConnection cnx;
        private MySqlCommand cmd;
        private MySqlDataReader dr;

        // Constructeur
        public GstBdd()
        {
            string chaine = "Server=localhost;Database=gestionvisiteurgsb;Uid=root;Pwd=";
            cnx = new MySqlConnection(chaine);
            cnx.Open();
        }

        public List<Region> getAllRegions()
        {
            List<Region> mesRegions = new List<Region>();
            // Ecrire votre requête
            cmd = new MySqlCommand("SELECT REG_CODE,REG_NOM,region.SEC_CODE,SEC_LIBELLE FROM region INNER JOIN secteur on region.SEC_CODE = secteur.SEC_CODE GROUP BY REG_CODE", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Region uneNouvelleRegion = new Region(Convert.ToInt16(dr[0].ToString()), (dr[1].ToString()),new Secteur(Convert.ToInt16(dr[2].ToString()),(dr[3].ToString())));
                mesRegions.Add(uneNouvelleRegion);

            }
            dr.Close();
            return mesRegions;
        }

        public List<Visiteurs> getAllVisiteurs()
        {
            List<Visiteurs> mesVisiteurs = new List<Visiteurs>();
            // Ecrire votre requête
            cmd = new MySqlCommand("SELECT VIS_MATRICULE, VIS_NOM, VIS_PRENOM, VIS_ADRESSE, VIS_CP, VIS_VILLE, VIS_DATEEMBAUCHE, visiteur.SEC_CODE,SEC_LIBELLE, visiteur.LAB_CODE,LAB_NOM,LAB_CHEFVENTE FROM `visiteur` INNER JOIN labo ON visiteur.LAB_CODE = labo.LAB_CODE INNER JOIN secteur on visiteur.SEC_CODE = secteur.SEC_CODE", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Visiteurs unNouveauVisiteur = new Visiteurs(Convert.ToInt16(dr[0].ToString()),(dr[1].ToString()), (dr[2].ToString()), (dr[3].ToString()), (dr[4].ToString()), (dr[5].ToString()), Convert.ToDateTime(dr[6].ToString()),new Secteur(Convert.ToInt16(dr[7].ToString()), (dr[8].ToString())),new Labo(Convert.ToInt16(dr[9].ToString()), (dr[10].ToString()), (dr[11].ToString())));
                mesVisiteurs.Add(unNouveauVisiteur);

            }
            dr.Close();
            return mesVisiteurs;
        }


        public void UpdateRegion(int numRegion, int numSecteur , string nomRegion)
        {
            cmd = new MySqlCommand("UPDATE region SET REG_NOM = " +nomRegion+ ",region.SEC_CODE ="+numSecteur+" WHERE region.REG_CODE =" + numRegion, cnx);
            dr = cmd.ExecuteReader();
            dr.Read();
            dr.Close();
        }

        public void UpdateVisiteurs(string nom,string prenom,string adressse,string cp,int secteur,string ville,DateTime date,int codeLabo, string matricule)
        {
            cmd = new MySqlCommand("UPDATE visiteurs SET VIS_NOM =" + nom + ",VIS_PRENOM = " + prenom + ",VIS_ADRESSE = " + adressse + ",VIS_CP = " + cp + ",visiteur.SEC_CODE = " + secteur + ",VIS_VILLE = " + ville + ",VIS_DATEEMBAUCHE = " + date + ",visiteurs.LAB_CODE = " + codeLabo + "  WHERE VIS_MATRICULE =" + matricule, cnx);
            dr = cmd.ExecuteReader();
            dr.Read();
            dr.Close();
        }


        public void AjouterRegion(string nomRegion,int secteur)
        {
            cmd = new MySqlCommand("INSERT INTO region (REG_NOM,SEC_CODE) VALUES (" + nomRegion + "," + secteur +")", cnx);
            cmd.ExecuteNonQuery();

            dr.Close();
        }

        public void AjouterVisiteur(string nom, string prenom, string adresse, string cp,int secteur,string ville, DateTime date,int codeLabo)
        {
            cmd = new MySqlCommand("INSERT INTO visiteurs (VIS_NOM,VIS_PRENOM,VIS_ADRESSE,VIS_CP,visiteurs.SEC_CODE,VIS_VILLE,VIS_DATEEMBACUHE) VALUES ("+ nom + "," + prenom + ", " + adresse + ", " + cp + ", " + secteur + ", " + ville + ", " + date + ", " + codeLabo + ")", cnx);
            cmd.ExecuteNonQuery();

            dr.Close();
        }

        public void AjouterRegionAVisiteur(string matricule, DateTime dateassignation, int coderegion, string poste)
        {
            cmd = new MySqlCommand("INSERT INTO travailler (VIS_MATRICULE,JJMMAA,REG_CODE,TRA_ROLE) VALUES (" + matricule + "," + dateassignation + "," + coderegion + ", " + poste + ")", cnx);
            cmd.ExecuteNonQuery();

            dr.Close();
        }
    }
}

