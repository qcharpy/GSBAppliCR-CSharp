using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.BLL;
using GSBCR.modele;

namespace GSBCR.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            String login = txtLogin.Text;
            String password = txtMdp.Text;

            VISITEUR v = VisiteurManager.ChargerVisiteur(login, getPassord(password));
            if (v != null) {
                this.Hide();
                FrmMenuVisiteur FrmMenuVisiteur = new FrmMenuVisiteur(login, getPassord(password));
                FrmMenuVisiteur.ShowDialog();
                this.Close();
            } else {
                txtLogin.Text = "";
                txtMdp.Text = "";

                label3.Text = "Erreur : login ou mot de passe incorrecte !";
                label3.Visible = true;
            }
        }

        private String getPassord(String password) {
            String p = password;

            for (int i = password.Length; i < 40; i++) { p += " "; }

            return p;
        }
    }
}
