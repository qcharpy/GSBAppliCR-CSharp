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
    public partial class FrmPraticiens : Form
    {

        private int numPrat = -1;
        private VISITEUR leUtilisateur;
        private PRATICIEN lePraticienSelect;

        public FrmPraticiens(VISITEUR leUtilisateur)
        {
            InitializeComponent();
            this.leUtilisateur = leUtilisateur;
    
        }

        public FrmPraticiens(VISITEUR leUtilisateur, int numPraticien)
        {

            InitializeComponent();
            this.leUtilisateur = leUtilisateur;
            numPrat = numPraticien;

        }

        private void FrmPraticiens_Load(object sender, EventArgs e)
        {

            ucPraticien1.btn_ConsulterRapports.Click += new System.EventHandler(this.btn_ConsulterRapports_Click);

            Dictionary<String, PRATICIEN> listePraticiens = new Dictionary<string, PRATICIEN>();
            List<PRATICIEN> lesPraticiens;

            lesPraticiens = VisiteurManager.ChargerPraticiens();

            foreach (PRATICIEN lePraticien in lesPraticiens)
            {
                listePraticiens.Add(lePraticien.PRA_PRENOM + " " + lePraticien.PRA_NOM, lePraticien);
            }

            bsPraticiens.DataSource = listePraticiens;

            cbx_Praticiens.DataSource = bsPraticiens;
            cbx_Praticiens.DisplayMember = "Key";
            cbx_Praticiens.ValueMember = "Value";


            if (numPrat != -1)
            {
                int i = 0;
                bool pratiTrouve = false;
                

                while (cbx_Praticiens.Items.Count < i || !pratiTrouve)
                {
                    if (((KeyValuePair<String, PRATICIEN>)cbx_Praticiens.Items[i]).Value.PRA_NUM == numPrat)
                    {
                        cbx_Praticiens.SelectedIndex = i;
                        pratiTrouve = true;
                    }
                    else
                    {
                        i++;
                    }
                }

                cbx_Praticiens.Enabled = false;

            }
            else
            {
                ucPraticien1.Visible = false;
                cbx_Praticiens.SelectedIndex = -1;
            }


        }

        private void cbx_Praticiens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Praticiens.SelectedIndex != -1)
            {
                KeyValuePair<String, PRATICIEN> p = (KeyValuePair<String, PRATICIEN>)cbx_Praticiens.SelectedItem;
                ucPraticien1.Prati = p.Value;
                this.lePraticienSelect = p.Value;
                ucPraticien1.Visible = true;
            }
        }


        private void btn_ConsulterRapports_Click(object sender, EventArgs e)
        {

            FrmRapports fenRapportPraticien = new FrmRapports(leUtilisateur, VisiteurManager.ChargerRapportsVisitesPraticien(leUtilisateur, lePraticienSelect), FrmRapports.RapportPraticiens);

            fenRapportPraticien.ShowDialog();

        }
    }
}
