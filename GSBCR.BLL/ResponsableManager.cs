using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using GSBCR.DAL;

namespace GSBCR.BLL
{
    public class ResponsableManager
    {

        /// <summary>
        /// Charge les regions d'un secteur
        /// </summary>
        /// <param name="codeSecteur">Code du secteur des régions</param>
        /// <returns>List<REGION></returns>
        public static List<REGION> ChargerRegionsSecteur(string codeSecteur)
        {
            List<REGION> lReg = new RegionDAO().FindBySecteur(codeSecteur);

            return lReg;
        }

        /// <summary>
        /// Permet de retourner une liste de visiteurs pour un secteur à partir de vaffectation
        /// </summary>
        /// <param name="secteurCode">code du secteur</param>
        /// /// <param name="role">Rôle de l'utilisateur (délégué ou responsable)</param>
        /// <returns>List<VAFFECTATION></returns>
        public static List<VAFFECTATION> ChargerAffectationsVisiteursBySecteur(string secteurCode, string role)
        {
            List<VAFFECTATION> lvaff = new VaffectationDAO().FindBySecteur(secteurCode, role);

            return lvaff;
        }

        /// <summary>
        /// Met à jour l'affectation d'un visiteur
        /// </summary>
        /// <param name="matricule">Matricule du visiteur</param>
        /// <param name="codeRegion">Code de la région de la nouvelle affectation</param>
        /// <param name="dateAffectation">Date de la nouvelle affectation</param>
        /// <param name="role">Role du visiteur pour sa nouvelle affectation</param>
        public static void MettreAjourAffectationVisiteur(string matricule, string codeRegion, DateTime dateAffectation, string role)
        {
            TRAVAILLER laAffectation = new TRAVAILLER();
            laAffectation.VIS_MATRICULE = matricule;
            laAffectation.REG_CODE = codeRegion;
            laAffectation.JJMMAA = dateAffectation;
            laAffectation.TRA_ROLE = role;

            new TravaillerDAO().insert(laAffectation);
        }

    }
}
