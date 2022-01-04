using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
            string chaine = "Server=localhost;Database=gestionvisiteurbdd;Uid=root;Pwd=";
            cnx = new MySqlConnection(chaine);
            cnx.Open();
        }

        public List<Region> getAllRegions()
        {
            List<Region> mesRegions = new List<Region>();
            // Ecrire votre requête
            cmd = new MySqlCommand("SELECT region.REG_CODE,region.REG_NOM FROM region", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Region uneNouvelleRegion = new Region(Convert.ToInt16(dr[0].ToString()), (dr[1].ToString()));
                mesRegions.Add(uneNouvelleRegion);

            }
            dr.Close();
            return mesRegions;
        }

        public List<Visiteurs> getAllVisiteurs()
        {
            List<Visiteurs> mesVisiteurs = new List<Visiteurs>();
            // Ecrire votre requête
            cmd = new MySqlCommand("SELECT VIS_NOM,VIS_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBAUCHE,LAB_CODE visiteurs", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Visiteur unNouveauVisiteur = new Visiteur((dr[0].ToString()), (dr[1].ToString()), (dr[2].ToString()), (dr[3].ToString()), (dr[4].ToString()), (dr[5].ToString()), Convert.ToInt16(dr[6].ToString()));
                mesVisiteurs.Add(unNouveauVisiteur);

            }
            dr.Close();
            return mesVisiteurs;
        }


        public void UpdateRegion(int numRegion, string nomRegion , string anciennom)
        {
            cmd = new MySqlCommand("UPDATE region SET REG_CODE =" + numRegion + ",REG_NOM = " +nomRegion+ " WHERE REG_NOM =" + anciennom, cnx);
            dr = cmd.ExecuteReader();
            dr.Read();
            dr.Close();
        }

        public void UpdateVisiteurs(string nom,string prenom,string adressse,string cp,string ville,DateTime date,string matricule)
        {
            cmd = new MySqlCommand("UPDATE visiteurs SET VIS_NOM =" + nom + ",VIS_PRENOM = " + prenom + ",VIS_ADRESSE = " + adressse + ",VIS_CP = " + cp + ",VIS_VILLE = " + ville + ",VIS_DATEEMBAUCHE = " + date + "  WHERE VIS_MATRICULE =" + matricule, cnx);
            dr = cmd.ExecuteReader();
            dr.Read();
            dr.Close();
        }


        public void AjouterRegion(string nomRegion,int numRegion,string secteur)
        {
            cmd = new MySqlCommand("INSERT INTO region (REG_CODE,REG_NOM,SEC_NOM) VALUES (" + numRegion + "," + nomRegion + "," + secteur +")", cnx);
            cmd.ExecuteNonQuery();

            dr.Close();
        }

        public void AjouterVisiteur(string nom, string prenom, string adresse, string cp, string ville, DateTime date, string matricule)
        {
            cmd = new MySqlCommand("INSERT INTO visiteurs (VIS_MATRICULE,VIS_NOM,VIS_PRENOM,VIS_ADRESSE,VIS_CP,VIS_VILLE,VIS_DATEEMBACUHE) VALUES (" + matricule + "," + nom + "," + prenom + ", " + adresse + ", " + cp + ", " + ville + ", " + date + ")", cnx);
            cmd.ExecuteNonQuery();

            dr.Close();
        }

        public void AjouterRegionAVisiteur(string matricule, DateTime dateassignation, string coderegion, string poste)
        {
            cmd = new MySqlCommand("INSERT INTO travailler (VIS_MATRICULE,JJMMAA,REG_CODE,TRA_ROLE) VALUES (" + matricule + "," + dateassignation + "," + coderegion + ", " + poste + ")", cnx);
            cmd.ExecuteNonQuery();

            dr.Close();
        }
    }
}
}
