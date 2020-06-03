namespace GSBCR.UI
{
    partial class FrmRapports
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.dgv_Rapports = new System.Windows.Forms.DataGridView();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculeVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pratNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRapportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateVisiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifAutreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicament1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicament2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leRapportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRapports = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Details = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rapports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Details);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnQuitter);
            this.splitContainer1.Panel1.Controls.Add(this.btnNouveau);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_Rapports);
            this.splitContainer1.Size = new System.Drawing.Size(853, 411);
            this.splitContainer1.SplitterDistance = 96;
            this.splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vos rapports en cours";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(720, 62);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(544, 62);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(75, 23);
            this.btnNouveau.TabIndex = 0;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // dgv_Rapports
            // 
            this.dgv_Rapports.AutoGenerateColumns = false;
            this.dgv_Rapports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rapports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.matriculeVisiteurDataGridViewTextBoxColumn,
            this.nomVisiteurDataGridViewTextBoxColumn,
            this.prenomVisiteurDataGridViewTextBoxColumn,
            this.pratNumDataGridViewTextBoxColumn,
            this.dateRapportDataGridViewTextBoxColumn,
            this.dateVisiteDataGridViewTextBoxColumn,
            this.motifDataGridViewTextBoxColumn,
            this.motifAutreDataGridViewTextBoxColumn,
            this.medicament1DataGridViewTextBoxColumn,
            this.medicament2DataGridViewTextBoxColumn,
            this.leRapportDataGridViewTextBoxColumn});
            this.dgv_Rapports.DataSource = this.bsRapports;
            this.dgv_Rapports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Rapports.Location = new System.Drawing.Point(0, 0);
            this.dgv_Rapports.Name = "dgv_Rapports";
            this.dgv_Rapports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Rapports.Size = new System.Drawing.Size(853, 311);
            this.dgv_Rapports.TabIndex = 0;
            this.dgv_Rapports.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Rapports_CellDoubleClick);
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numéro";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matriculeVisiteurDataGridViewTextBoxColumn
            // 
            this.matriculeVisiteurDataGridViewTextBoxColumn.DataPropertyName = "MatriculeVisiteur";
            this.matriculeVisiteurDataGridViewTextBoxColumn.HeaderText = "Matricule";
            this.matriculeVisiteurDataGridViewTextBoxColumn.Name = "matriculeVisiteurDataGridViewTextBoxColumn";
            this.matriculeVisiteurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomVisiteurDataGridViewTextBoxColumn
            // 
            this.nomVisiteurDataGridViewTextBoxColumn.DataPropertyName = "NomVisiteur";
            this.nomVisiteurDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomVisiteurDataGridViewTextBoxColumn.Name = "nomVisiteurDataGridViewTextBoxColumn";
            this.nomVisiteurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomVisiteurDataGridViewTextBoxColumn
            // 
            this.prenomVisiteurDataGridViewTextBoxColumn.DataPropertyName = "PrenomVisiteur";
            this.prenomVisiteurDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prenomVisiteurDataGridViewTextBoxColumn.Name = "prenomVisiteurDataGridViewTextBoxColumn";
            this.prenomVisiteurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pratNumDataGridViewTextBoxColumn
            // 
            this.pratNumDataGridViewTextBoxColumn.DataPropertyName = "PratNum";
            this.pratNumDataGridViewTextBoxColumn.HeaderText = "Praticien";
            this.pratNumDataGridViewTextBoxColumn.Name = "pratNumDataGridViewTextBoxColumn";
            this.pratNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateRapportDataGridViewTextBoxColumn
            // 
            this.dateRapportDataGridViewTextBoxColumn.DataPropertyName = "DateRapport";
            this.dateRapportDataGridViewTextBoxColumn.HeaderText = "Date rapport";
            this.dateRapportDataGridViewTextBoxColumn.Name = "dateRapportDataGridViewTextBoxColumn";
            this.dateRapportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateVisiteDataGridViewTextBoxColumn
            // 
            this.dateVisiteDataGridViewTextBoxColumn.DataPropertyName = "DateVisite";
            this.dateVisiteDataGridViewTextBoxColumn.HeaderText = "Date visite";
            this.dateVisiteDataGridViewTextBoxColumn.Name = "dateVisiteDataGridViewTextBoxColumn";
            this.dateVisiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motifDataGridViewTextBoxColumn
            // 
            this.motifDataGridViewTextBoxColumn.DataPropertyName = "Motif";
            this.motifDataGridViewTextBoxColumn.HeaderText = "Motif";
            this.motifDataGridViewTextBoxColumn.Name = "motifDataGridViewTextBoxColumn";
            this.motifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motifAutreDataGridViewTextBoxColumn
            // 
            this.motifAutreDataGridViewTextBoxColumn.DataPropertyName = "MotifAutre";
            this.motifAutreDataGridViewTextBoxColumn.HeaderText = "Motif autre";
            this.motifAutreDataGridViewTextBoxColumn.Name = "motifAutreDataGridViewTextBoxColumn";
            this.motifAutreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicament1DataGridViewTextBoxColumn
            // 
            this.medicament1DataGridViewTextBoxColumn.DataPropertyName = "Medicament1";
            this.medicament1DataGridViewTextBoxColumn.HeaderText = "Medicament 1";
            this.medicament1DataGridViewTextBoxColumn.Name = "medicament1DataGridViewTextBoxColumn";
            this.medicament1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicament2DataGridViewTextBoxColumn
            // 
            this.medicament2DataGridViewTextBoxColumn.DataPropertyName = "Medicament2";
            this.medicament2DataGridViewTextBoxColumn.HeaderText = "Medicament 2";
            this.medicament2DataGridViewTextBoxColumn.Name = "medicament2DataGridViewTextBoxColumn";
            this.medicament2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leRapportDataGridViewTextBoxColumn
            // 
            this.leRapportDataGridViewTextBoxColumn.DataPropertyName = "LeRapport";
            this.leRapportDataGridViewTextBoxColumn.HeaderText = "LeRapport";
            this.leRapportDataGridViewTextBoxColumn.Name = "leRapportDataGridViewTextBoxColumn";
            this.leRapportDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsRapports
            // 
            this.bsRapports.DataSource = typeof(GSBCR.UI.TableRapportsVisites);
            // 
            // btn_Details
            // 
            this.btn_Details.Location = new System.Drawing.Point(632, 62);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(75, 23);
            this.btn_Details.TabIndex = 5;
            this.btn_Details.Text = "Détails";
            this.btn_Details.UseVisualStyleBackColor = true;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // FrmRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 411);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmRapports";
            this.Text = "FrmRapportEnCours";
            this.Load += new System.EventHandler(this.FrmRapports_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rapports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Rapports;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pratNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRapportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateVisiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifAutreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicament1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicament2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leRapportDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsRapports;
        private System.Windows.Forms.Button btn_Details;
    }
}