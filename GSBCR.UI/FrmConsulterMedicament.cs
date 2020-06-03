using GSBCR.modele;
using GSBCR.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBCR.UI
{
    public partial class FrmConsulterMedicament : Form
    {
        private MEDICAMENT leMedocSelect;
        private MEDICAMENT leMedoc;
        private VISITEUR leUtilisateur;

        public FrmConsulterMedicament(VISITEUR leUtilisateur)
        {
            InitializeComponent();
            this.leUtilisateur = leUtilisateur;

        }

        public FrmConsulterMedicament(VISITEUR leUtilisateur, MEDICAMENT leMedoc)
        {
            InitializeComponent();
            this.leUtilisateur = leUtilisateur;
            this.leMedoc = leMedoc;

        }

        private void cbxMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMedicament.SelectedIndex != -1)
            {
                MEDICAMENT m = (MEDICAMENT)cbxMedicament.SelectedItem;
                this.leMedocSelect = m;
                ucMedicament1.Medic = m;
                ucMedicament1.Visible = true;
            }
            
        }

        private void FrmConsulterMedicament_Load(object sender, EventArgs e)
        {

            List<MEDICAMENT> listMed = VisiteurManager.ChargerMedicaments();
            cbxMedicament.DataSource = listMed;
            cbxMedicament.DisplayMember = "MED_NOMCOMMERCIAL";
            cbxMedicament.ValueMember = "MED_DEPOTLEGAL";

            if (leMedoc != null)
            {
                cbxMedicament.SelectedValue = leMedoc.MED_DEPOTLEGAL;
                cbxMedicament.Enabled = false;
            }
            else
            {
                cbxMedicament.SelectedIndex = -1;
                ucMedicament1.Visible = false;
                this.leMedocSelect = null;
            }

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_voirRapport_Click(object sender, EventArgs e)
        {
            if (leMedocSelect != null)
            {
                FrmRapports frmRapport = new FrmRapports(leUtilisateur, VisiteurManager.ChargerRapportVisiteMedicament(leUtilisateur, leMedocSelect), FrmRapports.RapportsMedicaments);
                frmRapport.ShowDialog();
            }
            
           
        }
    }
}
