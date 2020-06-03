using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace GSBCR.DAL {
    public class TypePraticienDAO {

        /// <summary>
        /// Retourne le type de praticien en fonction de son code 
        /// </summary>
        /// <param name="code">Code du Type de Praticien</param>
        /// <returns>TYPE_PRATICIEN</returns>
        public TYPE_PRATICIEN FindById(string code) {

            TYPE_PRATICIEN type = null;
            using (var context = new GSB_visite_LEGUILLIEREntities()) {
                var request = from tp in context.TYPE_PRATICIEN
                              where tp.TYP_CODE == code
                              select tp;

                type = request.SingleOrDefault<TYPE_PRATICIEN>();
            }

            return type;
        }

        /// <summary>
        /// Retourne tous les type de praticien
        /// </summary>
        /// <returns>List<TYPE_PRATICIEN></returns>
        public List<TYPE_PRATICIEN> FindAll() {

            List<TYPE_PRATICIEN> types = null;
            using (var context = new GSB_visite_LEGUILLIEREntities()) {
                var request = from tp in context.TYPE_PRATICIEN
                              select tp;

                types = request.ToList<TYPE_PRATICIEN>();
            }

            return types;
        }

    }
}
