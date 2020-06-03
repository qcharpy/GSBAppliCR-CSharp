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
    public partial class FrmUpdateMdp : Form {
        private VISITEUR visiteur;
        private Regex rgxPassword = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$");
        private readonly String[] error = {
            "Erreur : Les champs 'Nouveau mot de passe' et\n 'Confirmer nouveau mot de passe' ne correspondent pas !",
            "Erreur : Votre nouveau mot de passe ne peut être identique\n à votre ancien mot de passe !",
            "Erreur : Le champ 'Ancien mot de passe' est incorrecte !",
            "Erreur : L'un des champ n'est pas pas renseigné !",
            "Erreur : Le mot de passe doit être de minimum 8 caractère,\n et doit contenir 1 majuscule, 1 minuscule et 1 chiffre"
        };

        public FrmUpdateMdp(VISITEUR v) {
            InitializeComponent();

            visiteur = v;
        }

        private void btnCancel_Click(object sender, EventArgs e) { this.Close(); }

        private void btnValid_Click(object sender, EventArgs e) {
            if (txtAncMdp.Text == "" || txtNewMdp.Text == "" || txtConfirmNewMdp.Text == "") {
                deleteDataOnTxtBox();
                showError(3);
            } else {
                if (getPassord(txtAncMdp.Text) == visiteur.vis_mdp) {
                    if (txtNewMdp.Text != visiteur.vis_mdp) {
                        if (rgxPassword.IsMatch(txtNewMdp.Text)) {
                            if (txtNewMdp.Text == txtConfirmNewMdp.Text) {
                                if (VisiteurManager.updatePassword(visiteur.VIS_MATRICULE, txtNewMdp.Text)) {
                                    MessageBox.Show("Votre mot de passe a été modifié avec succes", "Mise à Jour des données"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                } else {
                                    MessageBox.Show("Un problème est survenue lors de la mise à jour de votre mot de passe"
                                        , "Mise à Jour des données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    deleteDataOnTxtBox();
                                }
                            } else { showError(0); }
                        } else { showError(4); }
                    } else { showError(1); }
                } else { showError(2); }
            }
        }

        private void deleteDataOnTxtBox() {
            txtAncMdp.Text = "";
            txtNewMdp.Text = "";
            txtConfirmNewMdp.Text = "";
        }

        private void showError(int codeError) {
            lblError.Text = error[codeError];
            lblError.Visible = true;
            deleteDataOnTxtBox();
        }

        private String getPassord(String password) {
            String p = password;

            for (int i = password.Length; i < 40; i++) { p += " "; }

            return p;
        }
    }
}
