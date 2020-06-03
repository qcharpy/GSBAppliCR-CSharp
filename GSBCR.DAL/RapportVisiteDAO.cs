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
    public class RapportVisiteDAO
    {
        /// <summary>
        /// Permet de retourner un rapport de visite en connaissant son id
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <param name="n">numéro rapport</param>
        /// <returns>RAPPORT_VISITE</returns>
        public RAPPORT_VISITE FindById(string m, int n)
        {
            RAPPORT_VISITE rv =null;
            // écrire et exécuter la requête Linq
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.RAPPORT_VISITE
                          where r.RAP_MATRICULE == m && r.RAP_NUM == n
                          select r;
                rv = req.SingleOrDefault<RAPPORT_VISITE>();
                
            }
            return rv;

        }
        /// <summary>
        /// Permet de créer une liste avec tous les rapports de visite de visiteurs qui ont un certain état
        /// </summary>
        /// <param name="lesMatricules">Liste de matricule (string)</param>
        /// <param name="lesEtats">Liste d'états (int)</param>
        /// <returns></returns>
        public List<RAPPORT_VISITE> FindByEtatEtVisiteur(List<string> lesMatricules, List<int> lesEtats)
        {
            List<RAPPORT_VISITE> lesRapports = null;
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                int i = 0;
                string reqStr = "select * from RAPPORT_VISITE r where r.RAP_MATRICULE in(";
                foreach (string m in lesMatricules)
                {
                    if (i != 0)
                        reqStr += ",";
                    else
                        i++;
                    reqStr += "'" + m + "'";
                }
                reqStr += ") and r.RAP_ETAT in(";
                i = 0;
                foreach (int e in lesEtats)
                {
                    if (i != 0)
                        reqStr += ",";
                    else
                        i++;
                    reqStr += e ;
                }
                reqStr += ")";


                lesRapports = context.RAPPORT_VISITE.SqlQuery(reqStr).ToList<RAPPORT_VISITE>();

                foreach (RAPPORT_VISITE leRapport in lesRapports)
                {
                    leRapport.LeVisiteur = new VisiteurDAO().FindById(leRapport.RAP_MATRICULE);
                }

            } 
            return lesRapports;
        }

        /// <summary>
        /// Permet de créer un rapport dans la base de données par appel de la procédure stockée addRapport
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public void insert(RAPPORT_VISITE r)
        {
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                try
                {
                    //ajout du rapport au contexte
                    context.RAPPORT_VISITE.Add(r);
                    //sauvegarde du contexte
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                } 
            }

        }

         /// <summary>
        /// Permet de mettre à jour un rapport dans la base de données par appel de la procédure stockée updRapport
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public void update(RAPPORT_VISITE r)
        {
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                try
                {
                    //mise à jour de l'état du rapport 
                    context.Entry(r).State = System.Data.EntityState.Modified;
                    //sauvegarde du contexte
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                
            }
        }

        /// <summary>
        /// Retourne une liste de rapport en fonction d'un medicament et d'un visiteur
        /// </summary>
        /// <param name="v"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public List<RAPPORT_VISITE> FindByMedicament(VISITEUR v, MEDICAMENT m)
        {
            List<RAPPORT_VISITE> lrv = null;
            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                var req = from rv in context.RAPPORT_VISITE
                          where (rv.RAP_MED1 == m.MED_DEPOTLEGAL || rv.RAP_MED2 == m.MED_DEPOTLEGAL) && rv.RAP_MATRICULE == v.VIS_MATRICULE
                          select rv;
                lrv = req.ToList<RAPPORT_VISITE>();

            }
            return lrv;
        }


        /// <summary>
        /// Retourne la liste des rapports qui concerne un praticien
        /// </summary>
        /// <param name="v">Visiteur connecté</param>
        /// <param name="p">Praticien concerné</param>
        /// <returns>List<RAPPORT_VISITE></returns>
        public List<RAPPORT_VISITE> FindByPraticien(VISITEUR v, PRATICIEN p)
        {

            List<RAPPORT_VISITE> lrv = null;

            using (var context = new GSB_visite_LEGUILLIEREntities())
            {
                var req = from rv in context.RAPPORT_VISITE
                          where rv.RAP_PRANUM == p.PRA_NUM && rv.RAP_MATRICULE == v.VIS_MATRICULE
                          select rv;

                lrv = req.ToList<RAPPORT_VISITE>();

            }

            return lrv;
        }

    }
}
