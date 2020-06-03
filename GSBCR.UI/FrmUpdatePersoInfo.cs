using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using GSBCR.BLL;
using GSBCR.modele;

namespace GSBCR.UI {
    public partial class FrmUpdatePersoInfo : Form {
        private Regex rgxCp = new Regex(@"[0-9]{5}");
        private Regex rgxTown = new Regex(@"[A-Z]{1,30}");
        private Regex rgxPhone = new Regex(@"[0-9]{10}");
        private Regex rgxMail = new Regex(@"^([\w.-_]+)@([\w-_]+)\.([\w]+)$");

        public FrmUpdatePersoInfo(VISITEUR v) {
            InitializeComponent();

            txtMatri.Text = v.VIS_MATRICULE;
            txtName.Text = v.VIS_NOM;
            txtFirstName.Text = v.Vis_PRENOM;

            txtAddr.Text = v.VIS_ADRESSE;
            txtCp.Text = v.VIS_CP;
            txtTown.Text = v.VIS_VILLE;

            txtPhone.Text = v.tel;
            txtMail.Text = v.mail;
        }

        private void btnCancel_Click(object sender, EventArgs e) { this.Close(); }

        private void btnValid_Click(object sender, EventArgs e) {
            if (rgxCp.IsMatch(txtCp.Text) && txtCp.TextLength == 5) {
                if (rgxTown.IsMatch(txtTown.Text)) {
                    if (rgxPhone.IsMatch(txtPhone.Text)) {
                        if (rgxMail.IsMatch(txtMail.Text)) {
                            if (VisiteurManager.updateVisiteur(txtMatri.Text, txtAddr.Text, txtCp.Text, txtTown.Text, 
                                    txtPhone.Text, txtMail.Text)) {
                                MessageBox.Show("Mise à jour de vos informations effectué avec succes.", "Mise à Jour des données"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }else {
                                MessageBox.Show("Un problème est survenue lors de la mise à jour de vos informations"
                                    , "Mise à Jour des données"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        } else {
                            getError();
                            lblMail.Visible = true;
                        }
                    } else {
                        getError();
                        lblPhone.Visible = true;
                    }
                } else {
                    getError();
                    lblTown.Visible = true;
                }
            } else {
                getError();
                lblCp.Visible = true;
            }
            
        }

        private void getError() {
            lblCp.Visible = false;
            lblMail.Visible = false;
            lblPhone.Visible = false;
            lblTown.Visible = false;

            MessageBox.Show("Erreur : Un ou plusieurs champs sont invalides !", "Mise à Jour des données"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
