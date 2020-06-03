using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;

namespace GSBCR.UC {
    public partial class UcMedicament : UserControl {

        private MEDICAMENT medic;

        public MEDICAMENT Medic {
            get { return medic; }
            set {
                medic = value;
                if (medic != null) {
                    ucMedicamentRefresh();
                }
            }
        }

        public UcMedicament() {
            InitializeComponent();
        }

        private void UcMedicament_Load(object sender, EventArgs e) {

        }

        private void ucMedicamentRefresh() {
            txtDepot.Text = medic.MED_DEPOTLEGAL;
            txtNomCom.Text = medic.MED_NOMCOMMERCIAL;
            txtCodeFam.Text = medic.FAM_CODE;
            txtLibelFam.Text = medic.LaFamille.FAM_LIBELLE;
            txtCompo.Text = medic.MED_COMPOSITION;
            txtContreIndic.Text = medic.MED_CONTREINDIC;
            txtEffect.Text = medic.MED_EFFETS;
            txtPrix.Text = medic.MED_PRIXECHANTILLON.ToString();
        }
    }
}
