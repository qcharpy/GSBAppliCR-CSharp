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
using System.Runtime.InteropServices.WindowsRuntime;

namespace GSBCR.UI
{

    public struct TableRapportsVisites
    {
        private RAPPORT_VISITE leRapport;

        public int Numero
        {
            get
            {
                return LeRapport.RAP_NUM;
            }
        }

        public string MatriculeVisiteur
        {
            get
            {
                return leRapport.RAP_MATRICULE;
            }
        }

        public string NomVisiteur
        {
            get
            {
                if (leRapport.LeVisiteur != null)
                {
                    return leRapport.LeVisiteur.VIS_NOM;
                }
                else
                {
                    return null;
                }
            }
        }

        public string PrenomVisiteur
        {
            get
            {
                if (leRapport.LeVisiteur != null)
                {
                    return leRapport.LeVisiteur.Vis_PRENOM;
                }
                else
                {
                    return null;
                }
            }
        }

        public int PratNum
        {
            get
            {
                return leRapport.RAP_PRANUM;
            }
        }

        public DateTime DateRapport
        {
            get
            {
                return leRapport.RAP_DATE;
            }
        }

        public DateTime DateVisite
        {
            get
            {
                return leRapport.RAP_DATVISIT;
            }
        }

        public string Motif
        {
            get
            {
                return leRapport.RAP_MOTIF;
            }
        }


        public string MotifAutre
        {
            get
            {
                return leRapport.RAP_MOTIFAUTRE;
            }
        }

        public string Medicament1
        {
            get
            {
                return leRapport.RAP_MED1;
            }
        }

        public string Medicament2
        {
            get
            {
                return leRapport.RAP_MED2;
            }
        }

        public RAPPORT_VISITE LeRapport { get => leRapport; set => leRapport = value; }
    }


    public partial class FrmRapports : Form
    {

        public const int RapportsEnCoursVisiteurs = 1;
        public const int RapportsValidesVisiteurs = 2;
        public const int RapportsMedicaments = 3;
        public const int RapportPraticiens = 4;
        public const int NouveauxRapportsRegion = 5;
        public const int RapportsConsultesVisiteurs = 6;

        private VISITEUR leVisiteur;
        private int fonction;
        public FrmRapports(VISITEUR v, List<RAPPORT_VISITE> lr, int fonction)
        {
            List<TableRapportsVisites> lesRapports = new List<TableRapportsVisites>();
            TableRapportsVisites laLigne;

            InitializeComponent();
            this.fonction = fonction;
            leVisiteur = v;
            label2.Text = leVisiteur.VIS_NOM;
            label3.Text = leVisiteur.Vis_PRENOM;

            foreach (RAPPORT_VISITE leRapport in lr)
            {
                laLigne = new TableRapportsVisites();
                laLigne.LeRapport = leRapport;
                lesRapports.Add(laLigne);
            }

            bsRapports.DataSource = lesRapports;
            bsRapports.Sort = "NomVisiteur ASC, PrenomVisiteur ASC, DateVisite ASC";
            dgv_Rapports.DataSource = bsRapports;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            r.RAP_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmSaisir f = new FrmSaisir(r, true);
            if (f.ShowDialog() == DialogResult.OK)
            {
                bsRapports.Add(r);
            }
        }

        private void FrmRapports_Load(object sender, EventArgs e)
        {
            if(this.fonction == 5)
            {
                this.label2.Visible = false;
                this.label3.Visible = false;
                this.matriculeVisiteurDataGridViewTextBoxColumn.Visible = true;
                this.nomVisiteurDataGridViewTextBoxColumn.Visible = true;
                this.prenomVisiteurDataGridViewTextBoxColumn.Visible = true;
            }
            else
            {
                this.label2.Visible = true;
                this.label3.Visible = true;
                this.matriculeVisiteurDataGridViewTextBoxColumn.Visible = false;
                this.nomVisiteurDataGridViewTextBoxColumn.Visible = false;
                this.prenomVisiteurDataGridViewTextBoxColumn.Visible = false;
            }

            if (this.fonction == 1)
            {
                this.btnNouveau.Enabled = true;
                this.btnNouveau.Visible = true;
            }
            else
            {
                this.btnNouveau.Enabled = false;
                this.btnNouveau.Visible = false;
            }

            switch (this.fonction)
            {
                case 1:
                    this.label1.Text = "Vos rapports en cours";
                    break;

                case 2:
                    this.label1.Text = "Vos rapports validés";
                    break;

                case 3:
                    this.label1.Text = "Les rapports du médicaments";
                    break;

                case 4:
                    this.label1.Text = "Les rapports du praticiens";
                    break;

                case 5:
                    this.label1.Text = "Les nouveaux rapports";
                    break;

                case 6:
                    this.label1.Text = "Les rapports du visiteur";
                    break;

                default:
                    this.label1.Text = "Les rapports de visites";
                    break;
            }
        }

        private void dgv_Rapports_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RAPPORT_VISITE r = null;
            FrmSaisir f;

            r = ((TableRapportsVisites)bsRapports.Current).LeRapport;


            if (fonction == 5 || fonction == 6)
            {
                f = new FrmSaisir(r, false);
            }
            else
            {
                f = new FrmSaisir(r, true);
            }
            f.ShowDialog();

            if (this.fonction == 1)
            {
                //On relance la liaison de données pour actualiser l'état des rapports
                if (r.RAP_ETAT == "2")
                {
                    //les rapports à l'état 2 ('saisie terminée') ne doivent pas apparaitre dans la liste
                    bsRapports.RemoveCurrent();
                }
                else
                {
                    bsRapports.ResetCurrentItem();
                }
            }
            else if (this.fonction == 5)
            {
                if (r.RAP_ETAT == "3")
                {
                    //les rapports à l'état 3 ('consulté') ne doivent pas apparaitre dans la liste
                    bsRapports.RemoveCurrent();
                }
                else
                {
                    bsRapports.ResetCurrentItem();
                }
            }
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = null;
            FrmSaisir f;

            r = ((TableRapportsVisites)bsRapports.Current).LeRapport;

            if (fonction == 5 || fonction == 6)
            {
                f = new FrmSaisir(r, false);
            }
            else
            {
                f = new FrmSaisir(r, true);
            }
            
            f.ShowDialog();

            if (this.fonction == 1)
            {
                //On relance la liaison de données pour actualiser l'état des rapports
                if (r.RAP_ETAT == "2")
                {
                    //les rapports à l'état 2 ('saisie terminée') ne doivent pas apparaitre dans la liste
                    bsRapports.RemoveCurrent();
                }
                else
                {
                    bsRapports.ResetCurrentItem();
                }
            }
            else if (this.fonction == 5)
            {
                if (r.RAP_ETAT == "3")
                {
                    //les rapports à l'état 3 ('consulté') ne doivent pas apparaitre dans la liste
                    bsRapports.RemoveCurrent();
                }
                else
                {
                    bsRapports.ResetCurrentItem();
                }
            }
        }
    }
}
