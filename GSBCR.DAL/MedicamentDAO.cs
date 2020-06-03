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
    public class MedicamentDAO
    {
        /// <summary>
        /// Permet de trouver un médicament par son nom de dépot
        /// </summary>
        /// <param name="depot"></param>
        /// <returns></returns>
        public MEDICAMENT FindById(string depot)
        {
            //rechercher un médicament par son nom de dépot
            MEDICAMENT med = null;
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MEDICAMENT.Include("laFamille")
                          where m.MED_DEPOTLEGAL == depot
                          select m;
                med = req.SingleOrDefault<MEDICAMENT>();

            }
            return med;
        }

        /// <summary>
        /// Permet de charger tous les médicaments
        /// </summary>
        /// <returns></returns>
        public List<MEDICAMENT> FindAll()
        {
            //charger tous les médicaments
            List<MEDICAMENT> meds = null;
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MEDICAMENT.Include("laFamille")
                          select m;
                meds = req.ToList<MEDICAMENT>();

            }
            return meds;
            
        }

        /// <summary>
        /// Permet de charger tous les médicaments d'une famille
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<MEDICAMENT> FindByFamille(string code)
        {
            //A faire : charger tous les médicaments d'une famille
            List<MEDICAMENT> med = null;
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                var req = from m in context.MEDICAMENT.Include("laFamille")
                          where m.FAM_CODE == code
                          select m;
                med = req.ToList<MEDICAMENT>();
            }
            return med;
        }
    }
}
