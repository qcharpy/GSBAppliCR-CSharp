using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace GSBCR.DAL
{
    public class VaffectationDAO
    {
        /// <summary>
        /// Permet de retrouver la dernière affectation d'un visiteur à partir de son matricule
        /// en utilisant la vue vaffectation
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <returns>VAFFECTATION</returns>
        public VAFFECTATION FindByMatricule(string matricule)
        {
            VAFFECTATION v = null;
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                var req = from vaff in context.VAFFECTATION
                          where vaff.VIS_MATRICULE == matricule
                          select vaff;
                v = req.SingleOrDefault();
            }
            return v;
        }

        /// <summary>
        /// Permet de retourner une liste d'affectations pour une région en utilisant la vue VAFFECTATION
        /// </summary>
        /// <param name="regionCode">code région</param>
        /// <param name="role">Rôle de l'utilisateur (délégué ou responsable)</param>
        /// <returns>List<VAFFECTATION></returns>
        public List<VAFFECTATION> FindByRegion(string regionCode, string role)
        {
            List<VAFFECTATION> lv = null;
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                if (role == "Délégué")
                {
                    var req = from vaff in context.VAFFECTATION
                              where vaff.REG_CODE == regionCode && vaff.TRA_ROLE == "Visiteur"
                              select vaff;

                    lv = req.ToList();
                }
                else if (role == "Responsable")
                {
                    var req = from vaff in context.VAFFECTATION
                              where vaff.REG_CODE == regionCode && (vaff.TRA_ROLE == "Visiteur" || vaff.TRA_ROLE == "Délégué")
                              select vaff;

                    lv = req.ToList();
                }

                
            }
            return lv;
        }


        /// <summary>
        /// Permet de retourner une liste d'affectations pour un secteur en utilisant la vue VAFFECTATION
        /// </summary>
        /// <param name="secteurCode">code du secteur</param>
        /// <param name="role">Rôle de l'utilisateur (délégué ou responsable)</param>
        /// <returns>List<VAFFECTATION></returns>
        public List<VAFFECTATION> FindBySecteur(string secteurCode, string role)
        {
            List<VAFFECTATION> lv = null;
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                if (role == "Délégué")
                {
                    var req = from vaff in context.VAFFECTATION
                              where vaff.SEC_CODE == secteurCode && vaff.TRA_ROLE == "Visiteur"
                              select vaff;

                    lv = req.ToList();
                }
                else if (role == "Responsable")
                {
                    var req = from vaff in context.VAFFECTATION
                              where vaff.SEC_CODE == secteurCode && (vaff.TRA_ROLE == "Visiteur" || vaff.TRA_ROLE == "Délégué")
                              select vaff;

                    lv = req.ToList();
                }


            }
            return lv;
        }

    }
}
