using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using GSBCR.DAL;

namespace GSBCR.BLL
{
    public static class DelegueManager
    {
        /// <summary>
        /// Permet de retourner une liste de visiteurs pour une région à partir de vaffectation
        /// </summary>
        /// <param name="regionCode">code région</param>
        /// /// <param name="role">Rôle de l'utilisateur (délégué ou responsable)</param>
        /// <returns>List<VAFFECTATION></returns>
        public static List<VAFFECTATION> ChargerAffectationsVisiteursByRegion(string regionCode, string role)
        {
            List<VAFFECTATION> lvaff = new VaffectationDAO().FindByRegion(regionCode, role);
            
            return lvaff;
        }


        /// <summary>
        /// Permet de charger les rapports non consultés (état 2) des visiteurs d'une région  
        /// </summary>
        /// <param name="code">code région</param>
        /// <param name="role">Rôle de l'utilisateur (délégué ou responsable)</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportRegionNonLus(String code, string role)
        {
            List<String> visMat = new List<string>();
            List<VAFFECTATION> lvaff = new VaffectationDAO().FindByRegion(code, role);
            List<RAPPORT_VISITE> lesRaps = new List<RAPPORT_VISITE>();

            foreach (VAFFECTATION laAffectation in lvaff)
            {
                visMat.Add(laAffectation.VIS_MATRICULE.ToString());
            }

            lesRaps = new RapportVisiteDAO().FindByEtatEtVisiteur(visMat, new List<int>() {2});

            return lesRaps;
        }



        /// <summary>
        /// Permet de charger les rapports terminés et consultés (état 3) des visiteurs d'une région 
        /// </summary>
        /// <param name="r">code région</param>
        /// <param name="role">Rôle de l'utilisateur (délégué ou responsable)</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportRegionLus(String r, string role)
        {
            List<String> visMat = new List<string>();
            List<VAFFECTATION> lvaff = new VaffectationDAO().FindByRegion(r, role);
            List<RAPPORT_VISITE> lesRaps = new List<RAPPORT_VISITE>();

            foreach (VAFFECTATION laAffectation in lvaff)
            {
                visMat.Add(laAffectation.VIS_MATRICULE.ToString());
            }

            lesRaps = new RapportVisiteDAO().FindByEtatEtVisiteur(visMat, new List<int>() { 3 });

            return lesRaps;
        }

    }
}
