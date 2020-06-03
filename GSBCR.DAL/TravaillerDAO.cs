using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;

namespace GSBCR.DAL
{
    public class TravaillerDAO
    {
        /// <summary>
        /// Ajoute une nouvelle affectation en base de données
        /// </summary>
        /// <param name="laAffectation">Affectation à ajouter</param>
        public void insert(TRAVAILLER laAffectation)
        {
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                try
                {
                    //ajout du rapport au contexte
                    context.TRAVAILLER.Add(laAffectation);
                    //sauvegarde du contexte
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
