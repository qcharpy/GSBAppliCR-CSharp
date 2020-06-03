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
    public class VisiteurDAO
    {
        /// <summary>
        /// Permet de retrouver les infos d'un visiteur à partir de son login et mot de passe
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <returns>VISITEUR</returns>
        public VISITEUR FindById(string matricule)
        {
            VISITEUR vis = null;
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from v in context.VISITEUR
                          where v.VIS_MATRICULE == matricule
                          select v; 
                vis = req.SingleOrDefault<VISITEUR>();
            }
            return vis;
        }

        /// <summary>
        /// Permet de mettre à jour les informations d'un visiteur grâce à son matricule
        /// </summary>
        /// <param name="matricule">Matricule du visiteur</param>
        /// <param name="addr">Adresse du visiteur</param>
        /// <param name="cp">Code Postal du visiteur</param>
        /// <param name="town">Ville du visiteur</param>
        /// <param name="phone">Numéro de téléphone du visiteur</param>
        /// <param name="mail">Adresse mail du visiteur</param>
        public void updateVisiteur(String matricule, String addr, String cp, String town, String phone, String mail) {
            using (var context = new GSB_visite_LEGUILLIEREntities()) {
                var v = context.VISITEUR.First(obj => obj.VIS_MATRICULE == matricule);

                v.VIS_ADRESSE = addr;
                v.VIS_CP = cp;
                v.VIS_VILLE = town;
                v.tel = phone;
                v.mail = mail;

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Permet de mettre à jour le mot de passe d'un visiteur grâce à son matricule
        /// </summary>
        /// <param name="matricule">Matricule du visiteur</param>
        /// <param name="password">Nouveau mot de passe du vistieur</param>
        public void updatePassword(String matricule, String password) {
            using (var context = new GSB_visite_LEGUILLIEREntities()) {
                var v = context.VISITEUR.First(obj => obj.VIS_MATRICULE == matricule);

                v.vis_mdp = password;

                context.SaveChanges();
            }
        }
              
    }
}
