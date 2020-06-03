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
    public partial class UcPraticien : UserControl {

        private PRATICIEN prati;

        public PRATICIEN Prati {
            get { return prati; }
            set {
                prati = value;
                if (prati != null)
                {
                    ucPraticienRefresh();
                }
            }
        }

        public UcPraticien() { InitializeComponent(); }

        private void ucPraticienRefresh() {
            txtNum.Text = prati.PRA_NUM.ToString();
            txtName.Text = prati.PRA_NOM;
            txtFirstName.Text = prati.PRA_PRENOM;
            txtAddr.Text = prati.PRA_ADRESSE;
            txtCp.Text = prati.PRA_CP;
            txtVille.Text = prati.PRA_VILLE;
            txtCoefNoto.Text = prati.PRA_COEFNOTORIETE.ToString();
            txtCodeType.Text = prati.TYP_CODE;
            txtLibelType.Text = prati.LeType.TYP_LIBELLE;
        }
    }
}
