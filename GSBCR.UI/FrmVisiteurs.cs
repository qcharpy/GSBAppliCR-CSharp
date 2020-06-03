using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmVisiteurs : Form
    {

        private VISITEUR leUtilisateur;
        private VAFFECTATION laAffectationUtilisateur;

        public FrmVisiteurs(VISITEUR leUtilisateur)
        {
            InitializeComponent();
            this.leUtilisateur = leUtilisateur;
        }

        private void FrmVisiteurs_Load(object sender, EventArgs e)
        {
            laAffectationUtilisateur = VisiteurManager.ChargerAffectationVisiteur(leUtilisateur.VIS_MATRICULE);

            if (laAffectationUtilisateur.TRA_ROLE == "Responsable")
            {
                btn_Modifier.Enabled = true;
                btn_Modifier.Visible = true;
            }
            else
            {
                btn_Modifier.Enabled = false;
                btn_Modifier.Visible = false;
            }

            AfficherAffectationsVisiteurs();
        }

        private void dgv_Visiteurs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VAFFECTATION affectationSelect;
            FrmDetailsVisiteur fenetreConsult;

            affectationSelect = (VAFFECTATION)bsVisiteurs[e.RowIndex];

            fenetreConsult = new FrmDetailsVisiteur(false, affectationSelect, leUtilisateur, laAffectationUtilisateur, this);

            fenetreConsult.ShowDialog();
        }

        private void btn_Consulter_Click(object sender, EventArgs e)
        {
            VAFFECTATION affectationSelect;
            FrmDetailsVisiteur fenetreDetails;

            if (dgv_Visiteurs.SelectedRows.Count != 0)
            {

                affectationSelect = (VAFFECTATION)bsVisiteurs[dgv_Visiteurs.SelectedRows[0].Index];

                fenetreDetails = new FrmDetailsVisiteur(false, affectationSelect, leUtilisateur, laAffectationUtilisateur, this);

                fenetreDetails.ShowDialog();
            }

        }

        /// <summary>
        /// Affiche les affectations des visiteurs dans la datagridview
        /// </summary>
        public void AfficherAffectationsVisiteurs()
        {
            List<VAFFECTATION> affectationsVisiteurs = null;

            if (laAffectationUtilisateur.TRA_ROLE == "Délégué")
            {
                affectationsVisiteurs = DelegueManager.ChargerAffectationsVisiteursByRegion(laAffectationUtilisateur.REG_CODE, laAffectationUtilisateur.TRA_ROLE);
            }
            else if (laAffectationUtilisateur.TRA_ROLE == "Responsable")
            {
                affectationsVisiteurs = ResponsableManager.ChargerAffectationsVisiteursBySecteur(laAffectationUtilisateur.SEC_CODE, laAffectationUtilisateur.TRA_ROLE);
            }

            bsVisiteurs.DataSource = affectationsVisiteurs;

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            VAFFECTATION affectationSelect;
            FrmDetailsVisiteur fenetreModif;

            if (dgv_Visiteurs.SelectedRows.Count != 0)
            {

                affectationSelect = (VAFFECTATION)bsVisiteurs[dgv_Visiteurs.SelectedRows[0].Index];

                fenetreModif = new FrmDetailsVisiteur(true, affectationSelect, leUtilisateur, laAffectationUtilisateur, this);

                fenetreModif.ShowDialog();
            }

        }
    }
}
