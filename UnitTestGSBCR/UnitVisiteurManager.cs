using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GSBCR.BLL;
using GSBCR.modele;

namespace UnitTestGSBCR {
    [TestClass]
    public class UnitVisiteurManager {
        [TestMethod]
        public void TestChargerVisiteur() {
            VISITEUR v = VisiteurManager.ChargerVisiteur("a131", "30BFD069");
            Assert.IsNotNull(v, "Le visiteur a131 mdp 30BFD069 non chargé");
            VISITEUR v1 = VisiteurManager.ChargerVisiteur("a131", "");
            Assert.IsNull(v1, "Le visiteur a131 est chargé sans mot de passe");
        }

        [TestMethod]
        public void TestChargerRapportVisiteEnCours() {
            bool ok = false;
            List<RAPPORT_VISITE> lr = VisiteurManager.ChargerRapportVisiteurEncours("a131");
            foreach (RAPPORT_VISITE r in lr) {
                Assert.AreEqual("a131", r.RAP_MATRICULE, "le rapport n''appartient pas au matricule a131");
                Assert.AreEqual("1", r.RAP_ETAT, "état rapport différent de en cours (1)");
                ok = (r.RAP_NUM >= 46 && r.RAP_NUM <= 54);
                Assert.IsTrue(ok, "n° de rapport faux");
            }
        }

        [TestMethod]
        public void TestChargerRapportVisiteFinis() {
            bool ok = false;
            bool etatOk = false;
            List<RAPPORT_VISITE> lr = VisiteurManager.ChargerRapportVisiteurFinis("a131");
            foreach (RAPPORT_VISITE r in lr) {
                Assert.AreEqual("a131", r.RAP_MATRICULE, "le rapport n''appartient pas au matricule a131");
                etatOk = (r.RAP_ETAT == "2" || r.RAP_ETAT == "3");
                Assert.IsTrue(etatOk, "état rapport différent de Finis (2 ou 3)");
                ok = (r.RAP_NUM >= 3 && r.RAP_NUM <= 49);
                Assert.IsTrue(ok, "n° de rapport faux");
            }
        }
    }

}
