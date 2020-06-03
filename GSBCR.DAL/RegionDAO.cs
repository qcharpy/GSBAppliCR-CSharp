using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace GSBCR.DAL {
    public class RegionDAO {

        /// <summary>
        /// Retourne une région en fonction de son code
        /// </summary>
        /// <param name="code">Code de la région</param>
        /// <returns>REGION</returns>
        public REGION FindById(string code) {

            REGION reg = null;
            using (var context = new GSB_visite_LEGUILLIEREntities()) {
                var request = from r in context.REGION.Include("LeSecteur")
                              where r.REG_CODE == code
                              select r;

                reg = request.SingleOrDefault<REGION>();
            }

            return reg;
        }

        /// <summary>
        /// Retourne la liste de toutes les régions
        /// </summary>
        /// <returns>List<REGION></returns>
        public List<REGION> FindAll() {

            List<REGION> regs = null;
            using (var context = new GSB_visite_LEGUILLIEREntities()) {
                var request = from r in context.REGION
                              select r;

                regs = request.ToList<REGION>();
            }

            return regs;
        }


        /// <summary>
        /// Retourne la liste des régions d'un secteur
        /// </summary>
        /// <param name="codeSecteur">Code du secteur des régions</param>
        /// <returns>List<REGION></returns>
        public List<REGION> FindBySecteur(string codeSecteur)
        {
            List<REGION> regs = null;
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                var request = from r in context.REGION
                              where r.SEC_CODE == codeSecteur
                              select r;

                regs = request.ToList<REGION>();
            }

            return regs;
        }
    }
}
