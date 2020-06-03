namespace GSBCR.UI
{
    partial class FrmDetailsVisiteur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_Separateur = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txt_Role = new System.Windows.Forms.TextBox();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.btn_ConsulterRapports = new System.Windows.Forms.Button();
            this.txt_NbRapportsConsultes = new System.Windows.Forms.TextBox();
            this.lbl_NbRapportsConsultes = new System.Windows.Forms.Label();
            this.txt_Telephone = new System.Windows.Forms.TextBox();
            this.lbl_Telephone = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.dtp_DateAffectation = new System.Windows.Forms.DateTimePicker();
            this.pnl_Region = new System.Windows.Forms.Panel();
            this.txt_RegionCode = new System.Windows.Forms.TextBox();
            this.pnl_Secteur = new System.Windows.Forms.Panel();
            this.txt_SecteurLibelle = new System.Windows.Forms.TextBox();
            this.txt_SecteurCode = new System.Windows.Forms.TextBox();
            this.dtp_DateEmbauche = new System.Windows.Forms.DateTimePicker();
            this.txt_Adresse = new System.Windows.Forms.TextBox();
            this.pnl_Ville = new System.Windows.Forms.Panel();
            this.txt_Ville = new System.Windows.Forms.TextBox();
            this.txt_CodePostal = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.lbl_DateAffectation = new System.Windows.Forms.Label();
            this.lbl_Region = new System.Windows.Forms.Label();
            this.lbl_Secteur = new System.Windows.Forms.Label();
            this.lbl_DateEmbauche = new System.Windows.Forms.Label();
            this.lbl_Ville = new System.Windows.Forms.Label();
            this.lbl_Adresse = new System.Windows.Forms.Label();
            this.lbl_Prenom = new System.Windows.Forms.Label();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.txt_Matricule = new System.Windows.Forms.TextBox();
            this.lbl_Matricule = new System.Windows.Forms.Label();
            this.bsRegions = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Promouvoir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_Region.SuspendLayout();
            this.pnl_Secteur.SuspendLayout();
            this.pnl_Ville.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Separateur
            // 
            this.pnl_Separateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Separateur.Location = new System.Drawing.Point(23, 45);
            this.pnl_Separateur.Name = "pnl_Separateur";
            this.pnl_Separateur.Size = new System.Drawing.Size(398, 2);
            this.pnl_Separateur.TabIndex = 34;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.CausesValidation = false;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(168, 22);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(91, 20);
            this.lblTitre.TabIndex = 33;
            this.lblTitre.Text = "Le visiteur";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Enabled = false;
            this.btnAnnuler.Location = new System.Drawing.Point(322, 752);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 81;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Visible = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Enabled = false;
            this.btnValider.Location = new System.Drawing.Point(241, 752);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 80;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Visible = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(322, 69);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 79;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txt_Role
            // 
            this.txt_Role.BackColor = System.Drawing.Color.White;
            this.txt_Role.Location = new System.Drawing.Point(167, 600);
            this.txt_Role.Name = "txt_Role";
            this.txt_Role.ReadOnly = true;
            this.txt_Role.Size = new System.Drawing.Size(120, 20);
            this.txt_Role.TabIndex = 78;
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Location = new System.Drawing.Point(48, 604);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(29, 13);
            this.lbl_Role.TabIndex = 77;
            this.lbl_Role.Text = "Rôle";
            // 
            // btn_ConsulterRapports
            // 
            this.btn_ConsulterRapports.Location = new System.Drawing.Point(243, 705);
            this.btn_ConsulterRapports.Name = "btn_ConsulterRapports";
            this.btn_ConsulterRapports.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsulterRapports.TabIndex = 76;
            this.btn_ConsulterRapports.Text = "Consulter";
            this.btn_ConsulterRapports.UseVisualStyleBackColor = true;
            this.btn_ConsulterRapports.Click += new System.EventHandler(this.btn_ConsulterRapports_Click);
            // 
            // txt_NbRapportsConsultes
            // 
            this.txt_NbRapportsConsultes.BackColor = System.Drawing.Color.White;
            this.txt_NbRapportsConsultes.Location = new System.Drawing.Point(167, 706);
            this.txt_NbRapportsConsultes.Name = "txt_NbRapportsConsultes";
            this.txt_NbRapportsConsultes.ReadOnly = true;
            this.txt_NbRapportsConsultes.Size = new System.Drawing.Size(70, 20);
            this.txt_NbRapportsConsultes.TabIndex = 75;
            // 
            // lbl_NbRapportsConsultes
            // 
            this.lbl_NbRapportsConsultes.AutoSize = true;
            this.lbl_NbRapportsConsultes.Location = new System.Drawing.Point(48, 710);
            this.lbl_NbRapportsConsultes.Name = "lbl_NbRapportsConsultes";
            this.lbl_NbRapportsConsultes.Size = new System.Drawing.Size(98, 13);
            this.lbl_NbRapportsConsultes.TabIndex = 74;
            this.lbl_NbRapportsConsultes.Text = "Rapports consultés";
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.BackColor = System.Drawing.Color.White;
            this.txt_Telephone.Location = new System.Drawing.Point(167, 282);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.ReadOnly = true;
            this.txt_Telephone.Size = new System.Drawing.Size(230, 20);
            this.txt_Telephone.TabIndex = 73;
            this.txt_Telephone.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Telephone_Validating);
            // 
            // lbl_Telephone
            // 
            this.lbl_Telephone.AutoSize = true;
            this.lbl_Telephone.Location = new System.Drawing.Point(48, 286);
            this.lbl_Telephone.Name = "lbl_Telephone";
            this.lbl_Telephone.Size = new System.Drawing.Size(58, 13);
            this.lbl_Telephone.TabIndex = 72;
            this.lbl_Telephone.Text = "Téléphone";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.White;
            this.txt_Email.Location = new System.Drawing.Point(167, 229);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(230, 20);
            this.txt_Email.TabIndex = 71;
            this.txt_Email.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Email_Validating);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(48, 233);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 70;
            this.lbl_Email.Text = "Email";
            // 
            // dtp_DateAffectation
            // 
            this.dtp_DateAffectation.Location = new System.Drawing.Point(167, 653);
            this.dtp_DateAffectation.Name = "dtp_DateAffectation";
            this.dtp_DateAffectation.Size = new System.Drawing.Size(200, 20);
            this.dtp_DateAffectation.TabIndex = 69;
            // 
            // pnl_Region
            // 
            this.pnl_Region.Controls.Add(this.txt_RegionCode);
            this.pnl_Region.Location = new System.Drawing.Point(167, 545);
            this.pnl_Region.Name = "pnl_Region";
            this.pnl_Region.Size = new System.Drawing.Size(230, 24);
            this.pnl_Region.TabIndex = 68;
            // 
            // txt_RegionCode
            // 
            this.txt_RegionCode.BackColor = System.Drawing.Color.White;
            this.txt_RegionCode.Location = new System.Drawing.Point(0, 2);
            this.txt_RegionCode.Name = "txt_RegionCode";
            this.txt_RegionCode.ReadOnly = true;
            this.txt_RegionCode.Size = new System.Drawing.Size(70, 20);
            this.txt_RegionCode.TabIndex = 13;
            // 
            // pnl_Secteur
            // 
            this.pnl_Secteur.Controls.Add(this.txt_SecteurLibelle);
            this.pnl_Secteur.Controls.Add(this.txt_SecteurCode);
            this.pnl_Secteur.Location = new System.Drawing.Point(167, 492);
            this.pnl_Secteur.Name = "pnl_Secteur";
            this.pnl_Secteur.Size = new System.Drawing.Size(230, 24);
            this.pnl_Secteur.TabIndex = 67;
            // 
            // txt_SecteurLibelle
            // 
            this.txt_SecteurLibelle.BackColor = System.Drawing.Color.White;
            this.txt_SecteurLibelle.Location = new System.Drawing.Point(76, 2);
            this.txt_SecteurLibelle.Name = "txt_SecteurLibelle";
            this.txt_SecteurLibelle.ReadOnly = true;
            this.txt_SecteurLibelle.Size = new System.Drawing.Size(154, 20);
            this.txt_SecteurLibelle.TabIndex = 13;
            // 
            // txt_SecteurCode
            // 
            this.txt_SecteurCode.BackColor = System.Drawing.Color.White;
            this.txt_SecteurCode.Location = new System.Drawing.Point(0, 2);
            this.txt_SecteurCode.Name = "txt_SecteurCode";
            this.txt_SecteurCode.ReadOnly = true;
            this.txt_SecteurCode.Size = new System.Drawing.Size(70, 20);
            this.txt_SecteurCode.TabIndex = 13;
            // 
            // dtp_DateEmbauche
            // 
            this.dtp_DateEmbauche.Location = new System.Drawing.Point(167, 441);
            this.dtp_DateEmbauche.Name = "dtp_DateEmbauche";
            this.dtp_DateEmbauche.Size = new System.Drawing.Size(200, 20);
            this.dtp_DateEmbauche.TabIndex = 66;
            // 
            // txt_Adresse
            // 
            this.txt_Adresse.BackColor = System.Drawing.Color.White;
            this.txt_Adresse.Location = new System.Drawing.Point(167, 335);
            this.txt_Adresse.Name = "txt_Adresse";
            this.txt_Adresse.ReadOnly = true;
            this.txt_Adresse.Size = new System.Drawing.Size(230, 20);
            this.txt_Adresse.TabIndex = 65;
            // 
            // pnl_Ville
            // 
            this.pnl_Ville.Controls.Add(this.txt_Ville);
            this.pnl_Ville.Controls.Add(this.txt_CodePostal);
            this.pnl_Ville.Location = new System.Drawing.Point(167, 386);
            this.pnl_Ville.Name = "pnl_Ville";
            this.pnl_Ville.Size = new System.Drawing.Size(230, 24);
            this.pnl_Ville.TabIndex = 64;
            // 
            // txt_Ville
            // 
            this.txt_Ville.BackColor = System.Drawing.Color.White;
            this.txt_Ville.Location = new System.Drawing.Point(76, 2);
            this.txt_Ville.Name = "txt_Ville";
            this.txt_Ville.ReadOnly = true;
            this.txt_Ville.Size = new System.Drawing.Size(154, 20);
            this.txt_Ville.TabIndex = 13;
            this.txt_Ville.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Ville_Validating);
            // 
            // txt_CodePostal
            // 
            this.txt_CodePostal.BackColor = System.Drawing.Color.White;
            this.txt_CodePostal.Location = new System.Drawing.Point(0, 2);
            this.txt_CodePostal.Name = "txt_CodePostal";
            this.txt_CodePostal.ReadOnly = true;
            this.txt_CodePostal.Size = new System.Drawing.Size(70, 20);
            this.txt_CodePostal.TabIndex = 13;
            this.txt_CodePostal.Validating += new System.ComponentModel.CancelEventHandler(this.txt_CodePostal_Validating);
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.BackColor = System.Drawing.Color.White;
            this.txt_Prenom.Location = new System.Drawing.Point(167, 176);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.ReadOnly = true;
            this.txt_Prenom.Size = new System.Drawing.Size(120, 20);
            this.txt_Prenom.TabIndex = 63;
            // 
            // txt_Nom
            // 
            this.txt_Nom.BackColor = System.Drawing.Color.White;
            this.txt_Nom.Location = new System.Drawing.Point(167, 123);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.ReadOnly = true;
            this.txt_Nom.Size = new System.Drawing.Size(120, 20);
            this.txt_Nom.TabIndex = 62;
            // 
            // lbl_DateAffectation
            // 
            this.lbl_DateAffectation.AutoSize = true;
            this.lbl_DateAffectation.Location = new System.Drawing.Point(48, 657);
            this.lbl_DateAffectation.Name = "lbl_DateAffectation";
            this.lbl_DateAffectation.Size = new System.Drawing.Size(102, 13);
            this.lbl_DateAffectation.TabIndex = 61;
            this.lbl_DateAffectation.Text = "Date de l\'affectation";
            // 
            // lbl_Region
            // 
            this.lbl_Region.AutoSize = true;
            this.lbl_Region.Location = new System.Drawing.Point(48, 551);
            this.lbl_Region.Name = "lbl_Region";
            this.lbl_Region.Size = new System.Drawing.Size(41, 13);
            this.lbl_Region.TabIndex = 60;
            this.lbl_Region.Text = "Region";
            // 
            // lbl_Secteur
            // 
            this.lbl_Secteur.AutoSize = true;
            this.lbl_Secteur.Location = new System.Drawing.Point(48, 498);
            this.lbl_Secteur.Name = "lbl_Secteur";
            this.lbl_Secteur.Size = new System.Drawing.Size(44, 13);
            this.lbl_Secteur.TabIndex = 59;
            this.lbl_Secteur.Text = "Secteur";
            // 
            // lbl_DateEmbauche
            // 
            this.lbl_DateEmbauche.AutoSize = true;
            this.lbl_DateEmbauche.Location = new System.Drawing.Point(48, 445);
            this.lbl_DateEmbauche.Name = "lbl_DateEmbauche";
            this.lbl_DateEmbauche.Size = new System.Drawing.Size(102, 13);
            this.lbl_DateEmbauche.TabIndex = 58;
            this.lbl_DateEmbauche.Text = "Date de l\'embauche";
            // 
            // lbl_Ville
            // 
            this.lbl_Ville.AutoSize = true;
            this.lbl_Ville.Location = new System.Drawing.Point(48, 392);
            this.lbl_Ville.Name = "lbl_Ville";
            this.lbl_Ville.Size = new System.Drawing.Size(26, 13);
            this.lbl_Ville.TabIndex = 57;
            this.lbl_Ville.Text = "Ville";
            // 
            // lbl_Adresse
            // 
            this.lbl_Adresse.AutoSize = true;
            this.lbl_Adresse.Location = new System.Drawing.Point(48, 339);
            this.lbl_Adresse.Name = "lbl_Adresse";
            this.lbl_Adresse.Size = new System.Drawing.Size(45, 13);
            this.lbl_Adresse.TabIndex = 56;
            this.lbl_Adresse.Text = "Adresse";
            // 
            // lbl_Prenom
            // 
            this.lbl_Prenom.AutoSize = true;
            this.lbl_Prenom.Location = new System.Drawing.Point(48, 180);
            this.lbl_Prenom.Name = "lbl_Prenom";
            this.lbl_Prenom.Size = new System.Drawing.Size(43, 13);
            this.lbl_Prenom.TabIndex = 55;
            this.lbl_Prenom.Text = "Prénom";
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Location = new System.Drawing.Point(48, 127);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(29, 13);
            this.lbl_Nom.TabIndex = 54;
            this.lbl_Nom.Text = "Nom";
            // 
            // txt_Matricule
            // 
            this.txt_Matricule.BackColor = System.Drawing.Color.White;
            this.txt_Matricule.Location = new System.Drawing.Point(167, 70);
            this.txt_Matricule.Name = "txt_Matricule";
            this.txt_Matricule.ReadOnly = true;
            this.txt_Matricule.Size = new System.Drawing.Size(70, 20);
            this.txt_Matricule.TabIndex = 53;
            // 
            // lbl_Matricule
            // 
            this.lbl_Matricule.AutoSize = true;
            this.lbl_Matricule.Location = new System.Drawing.Point(48, 74);
            this.lbl_Matricule.Name = "lbl_Matricule";
            this.lbl_Matricule.Size = new System.Drawing.Size(50, 13);
            this.lbl_Matricule.TabIndex = 52;
            this.lbl_Matricule.Text = "Matricule";
            // 
            // btn_Promouvoir
            // 
            this.btn_Promouvoir.Enabled = false;
            this.btn_Promouvoir.Location = new System.Drawing.Point(322, 599);
            this.btn_Promouvoir.Name = "btn_Promouvoir";
            this.btn_Promouvoir.Size = new System.Drawing.Size(75, 23);
            this.btn_Promouvoir.TabIndex = 82;
            this.btn_Promouvoir.Text = "Promouvoir";
            this.btn_Promouvoir.UseVisualStyleBackColor = true;
            this.btn_Promouvoir.Visible = false;
            this.btn_Promouvoir.Click += new System.EventHandler(this.btn_Promouvoir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmDetailsVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 792);
            this.Controls.Add(this.btn_Promouvoir);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txt_Role);
            this.Controls.Add(this.lbl_Role);
            this.Controls.Add(this.btn_ConsulterRapports);
            this.Controls.Add(this.txt_NbRapportsConsultes);
            this.Controls.Add(this.lbl_NbRapportsConsultes);
            this.Controls.Add(this.txt_Telephone);
            this.Controls.Add(this.lbl_Telephone);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.dtp_DateAffectation);
            this.Controls.Add(this.pnl_Region);
            this.Controls.Add(this.pnl_Secteur);
            this.Controls.Add(this.dtp_DateEmbauche);
            this.Controls.Add(this.txt_Adresse);
            this.Controls.Add(this.pnl_Ville);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.lbl_DateAffectation);
            this.Controls.Add(this.lbl_Region);
            this.Controls.Add(this.lbl_Secteur);
            this.Controls.Add(this.lbl_DateEmbauche);
            this.Controls.Add(this.lbl_Ville);
            this.Controls.Add(this.lbl_Adresse);
            this.Controls.Add(this.lbl_Prenom);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.txt_Matricule);
            this.Controls.Add(this.lbl_Matricule);
            this.Controls.Add(this.pnl_Separateur);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmDetailsVisiteur";
            this.Text = "Visiteurs";
            this.Load += new System.EventHandler(this.FrmDetailsVisiteur_Load);
            this.pnl_Region.ResumeLayout(false);
            this.pnl_Region.PerformLayout();
            this.pnl_Secteur.ResumeLayout(false);
            this.pnl_Secteur.PerformLayout();
            this.pnl_Ville.ResumeLayout(false);
            this.pnl_Ville.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Separateur;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txt_Role;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.Button btn_ConsulterRapports;
        private System.Windows.Forms.TextBox txt_NbRapportsConsultes;
        private System.Windows.Forms.Label lbl_NbRapportsConsultes;
        private System.Windows.Forms.TextBox txt_Telephone;
        private System.Windows.Forms.Label lbl_Telephone;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.DateTimePicker dtp_DateAffectation;
        private System.Windows.Forms.Panel pnl_Region;
        private System.Windows.Forms.TextBox txt_RegionCode;
        private System.Windows.Forms.Panel pnl_Secteur;
        private System.Windows.Forms.TextBox txt_SecteurLibelle;
        private System.Windows.Forms.TextBox txt_SecteurCode;
        private System.Windows.Forms.DateTimePicker dtp_DateEmbauche;
        private System.Windows.Forms.TextBox txt_Adresse;
        private System.Windows.Forms.Panel pnl_Ville;
        private System.Windows.Forms.TextBox txt_Ville;
        private System.Windows.Forms.TextBox txt_CodePostal;
        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.Label lbl_DateAffectation;
        private System.Windows.Forms.Label lbl_Region;
        private System.Windows.Forms.Label lbl_Secteur;
        private System.Windows.Forms.Label lbl_DateEmbauche;
        private System.Windows.Forms.Label lbl_Ville;
        private System.Windows.Forms.Label lbl_Adresse;
        private System.Windows.Forms.Label lbl_Prenom;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.TextBox txt_Matricule;
        private System.Windows.Forms.Label lbl_Matricule;
        private System.Windows.Forms.TextBox txt_RegionLibelle;
        private System.Windows.Forms.ComboBox cbx_Region;
        private System.Windows.Forms.BindingSource bsRegions;
        private System.Windows.Forms.Button btn_Promouvoir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}