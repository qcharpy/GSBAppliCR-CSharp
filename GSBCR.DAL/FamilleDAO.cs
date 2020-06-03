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
    public class FamilleDAO
    {
        /// <summary>
        /// Retourne une famille de médicament spécifié
        /// </summary>
        /// <param name="code">Code de la famille de médicament</param>
        /// <returns>La famille de médicament spécifié</returns>
        public FAMILLE FindById(string code)
        {
            //A faire : rechercher une famille de médicaments par son nom
            FAMILLE med = null;
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                var req = from f in context.FAMILLE
                          where f.FAM_CODE == code
                          select f;
                med = req.SingleOrDefault<FAMILLE>();
            }
            return med;
        }

        /// <summary>
        /// Retourne toute les familles de médicaments
        /// </summary>
        /// <returns>Liste des familles de médicaments</returns>
        public List<FAMILLE> FindAll()
        {
            //A faire : charger toutes les familles de médicaments
            List<FAMILLE> fam = null;
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from f in context.FAMILLE
                          select f;
                fam = req.ToList<FAMILLE>();
            }
            return fam;
        }

    }
}
