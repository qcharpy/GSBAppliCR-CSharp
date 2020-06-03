﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using GSBCR.DAL;

namespace GSBCR.BLL
{
    public static class VisiteurManager
    {


         /// <summary>
        /// Permet de charger un visiteur à partir de son login et mot de passe
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <param name="mdp">mot de passe Visiteur</param>
        /// <returns>objet VISITEUR</returns>
        public static VISITEUR ChargerVisiteur(string matricule, string mdp)
        {
            VISITEUR vis = new VisiteurDAO().FindById(matricule);
            if ((vis != null) && (vis.vis_mdp == mdp))
                return vis;
            else
                return null;

        }


        /// <summary>
        /// Permet de charger un visiteur à partir de son matricule
        /// </summary>
        /// <param name="matricule">Matricule du visiteur</param>
        /// <returns>objet VISITEUR</returns>
        public static VISITEUR loadVisiteur(String matricule) {
            VISITEUR vis = new VisiteurDAO().FindById(matricule);
            return vis;
        }

        /// <summary>
        /// Permet de mettre à jour les informations d'un visiteur grâce à son matricule
        /// </summary>
        /// <param name="mat">Matricule du visiteur</param>
        /// <param name="addr">Adresse du visiteur</param>
        /// <param name="cp">Code Postal du visiteur</param>
        /// <param name="town">Ville du visiteur</param>
        /// <param name="phone">Numéro de téléphone du visiteur</param>
        /// <param name="mail">Adresse mail du visiteur</param>
        /// <returns>Booléen update (confirmer la modification)</returns>
        public static bool updateVisiteur(String mat, String addr, String cp, String town, String phone, String mail) {
            bool update = false;
            try {
                new VisiteurDAO().updateVisiteur(mat, addr, cp, town, phone, mail);
                update = true;
            }
            catch (Exception ex) { throw ex; }

            return update;
        }

        /// <summary>
        /// Permet de mettre à jour le mot de passe d'un visiteur grâce à son matricule.
        /// </summary>
        /// <param name="matricule">Matricule du visiteur</param>
        /// <param name="password">Nouveau mot de passe du visiteur</param>
        /// <returns>Booléen update (confirmer la modification)</returns>
        public static bool updatePassword(String matricule, String password) {
            bool update = false;
            try {
                new VisiteurDAO().updatePassword(matricule, password);
                update = true;
            }
            catch (Exception ex) { throw ex; }

            return update;
        }


        /// <summary>
        /// Permet de charger une région à partir de son identifiant
        /// </summary>
        /// <param name="codeRegion">Code de la région à charger</param>
        /// <returns>La région spécifié</returns>
        public static REGION ChargerUneRegion(string codeRegion)
        {
            REGION laRegion = new RegionDAO().FindById(codeRegion);

            return laRegion;

        }


        /// <summary>
        /// Permet de charger la dernière affectation du visiteur
        /// et donc son profil (visiteur, délégué, responsabe secteur) et sa région
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <returns>objet VAFFECTATION</returns>
        public static VAFFECTATION ChargerAffectationVisiteur(string matricule)
        {
            VAFFECTATION vaff = new VaffectationDAO().FindByMatricule(matricule);
            return vaff;
        }


        /// <summary>
        /// Permet de charger les rapports non terminés du visiteur (état 1)
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <returns>List<RAPPORT_VISITE></returns>
        public static List<RAPPORT_VISITE> ChargerRapportVisiteurEncours(String m)
        {
            List<RAPPORT_VISITE> lr;
            List<string> lm = new List<string>();
            lm.Add(m);
            List<int> le = new List<int>();
            le.Add(1);
            lr = new RapportVisiteDAO().FindByEtatEtVisiteur(lm, le);
            return lr;
        }


        /// <summary>
        /// Permet de charger tous les rapports à l'état 3 du visiteur
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <returns>List<RAPPORT_VISITE></returns>
        public static List<RAPPORT_VISITE> ChargerRapportsConsulteVisiteur(String m)
        {
            List<RAPPORT_VISITE> lr;
            List<string> lm = new List<string>();
            lm.Add(m);
            List<int> le = new List<int>();
            le.Add(3);
            lr = new RapportVisiteDAO().FindByEtatEtVisiteur(lm, le);
            return lr;
        }


        /// <summary>
        /// Permet de charger un rapport de visite
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <param name="n">numéro rapport</param>
        /// <returns>RAPPORT_VISITE</returns>
        public static RAPPORT_VISITE ChargerRapportVisite(string m, int n)
        {
            RAPPORT_VISITE r = new RapportVisiteDAO().FindById(m, n);
            return r;
        }

        /// <summary>
        /// Permet de charger les rapports terminés du visiteur (état 2 et 3) 
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportVisiteurFinis(String m) {
            List<RAPPORT_VISITE> lr;

            List<string> lm = new List<string>();
            List<int> le = new List<int>();

            lm.Add(m);
            le.Add(2);
            le.Add(3);

            lr = new RapportVisiteDAO().FindByEtatEtVisiteur(lm, le);

            return lr;
        }


        /// <summary>
        /// Permet de charger les rapports terminés et consultés du visiteur (état 3) 
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportVisiteurFinisEtLus(String m)
        {
            List<RAPPORT_VISITE> lr;

            List<string> lm = new List<string>();
            List<int> le = new List<int>();

            lm.Add(m);
            le.Add(3);

            lr = new RapportVisiteDAO().FindByEtatEtVisiteur(lm, le);

            return lr;
        }

        /// <summary>
        /// Permet de créer un rapport dans la base de données 
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public static void CreateRapport(RAPPORT_VISITE r)
        {
            try
            {
                new RapportVisiteDAO().insert(r);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Permet de mettre à jour un rapport dans la base de données 
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public static void MajRapport(RAPPORT_VISITE r)
        {
            try
            {
                new RapportVisiteDAO().update(r);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// Permet de charger un médicament à partir de son nom de dépot légal
        /// </summary>
        /// <param name="depot">chaine caractères</param>
        public static MEDICAMENT ChargerLeMedicament(string depot)
        {
            MEDICAMENT l = new MedicamentDAO().FindById(depot);
            return l;
        }

        /// <summary>
        /// Permet de charger tous les médicaments
        /// </summary>
        public static List<MEDICAMENT> ChargerMedicaments()
        {
            List<MEDICAMENT> lm = new MedicamentDAO().FindAll();
            return lm;
        }

        /// <summary>
        /// Permet de charger tous les motifs visite
        /// </summary>
        public static List<MOTIF_VISITE> ChargerMotifVisites()
        {
            List<MOTIF_VISITE> lm = new MotifVisiteDAO().FindAll();
            return lm;
        }

        /// <summary>
        /// Permet de charger tous les praticiens
        /// </summary>
        public static List<PRATICIEN> ChargerPraticiens()
        {
            List<PRATICIEN> lp = new PratricienDAO().FindAll();
            return lp;
        }

        /// <summary>
        /// Permet de charger un praticien à partir de son numéro
        /// <param name="pranum">entier</param>
        /// </summary>
        public static PRATICIEN ChargerLePraticien(Int16 pranum)
        {
            // A faire
            PRATICIEN prat = new PratricienDAO().FindById(pranum);
            return prat;
        }

        /// <summary>
        /// Permet de charger un rapport de visite en fonction du medicament
        /// </summary>
        /// <param name="v">Visiteur connecté</param>
        /// <param name="m">Médicament selectionné</param>
        /// <returns>List<RAPPORT_VISITE></returns>
        public static List<RAPPORT_VISITE> ChargerRapportVisiteMedicament(VISITEUR v, MEDICAMENT m)
        {
            List<RAPPORT_VISITE> lrv = null;
            lrv = new RapportVisiteDAO().FindByMedicament(v, m);
            return lrv;
        }


        /// <summary>
        /// Permet de charger la liste des rapports qui concerne un praticien
        /// </summary>
        /// <param name="v">Visiteur connecté</param>
        /// <param name="p">Praticien concerné</param>
        /// <returns>List<RAPPORT_VISITE></returns>
        public static List<RAPPORT_VISITE> ChargerRapportsVisitesPraticien(VISITEUR v, PRATICIEN p)
        {

            List<RAPPORT_VISITE> lrv = null;
            lrv = new RapportVisiteDAO().FindByPraticien(v, p);
            return lrv;

        }

    }
}
