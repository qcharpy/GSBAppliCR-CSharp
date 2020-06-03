namespace GSBCR.UI
{
    partial class FrmConsulterMedicament
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
            this.cbxMedicament = new System.Windows.Forms.ComboBox();
            this.bsMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.btnVoirRapport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ucMedicament1 = new GSBCR.UC.UcMedicament();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxMedicament
            // 
            this.cbxMedicament.FormattingEnabled = true;
            this.cbxMedicament.Location = new System.Drawing.Point(341, 12);
            this.cbxMedicament.Name = "cbxMedicament";
            this.cbxMedicament.Size = new System.Drawing.Size(197, 21);
            this.cbxMedicament.TabIndex = 1;
            this.cbxMedicament.SelectedIndexChanged += new System.EventHandler(this.cbxMedicament_SelectedIndexChanged);
            // 
            // btnVoirRapport
            // 
            this.btnVoirRapport.Location = new System.Drawing.Point(574, 8);
            this.btnVoirRapport.Name = "btnVoirRapport";
            this.btnVoirRapport.Size = new System.Drawing.Size(233, 35);
            this.btnVoirRapport.TabIndex = 5;
            this.btnVoirRapport.Text = "Voir les rapports de visite";
            this.btnVoirRapport.UseVisualStyleBackColor = true;
            this.btnVoirRapport.Click += new System.EventHandler(this.btn_voirRapport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucMedicament1
            // 
            this.ucMedicament1.Location = new System.Drawing.Point(13, 64);
            this.ucMedicament1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMedicament1.Medic = null;
            this.ucMedicament1.Name = "ucMedicament1";
            this.ucMedicament1.Size = new System.Drawing.Size(1046, 340);
            this.ucMedicament1.TabIndex = 7;
            // 
            // FrmConsulterMedicament
            // 
            this.ClientSize = new System.Drawing.Size(1073, 505);
            this.Controls.Add(this.ucMedicament1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVoirRapport);
            this.Controls.Add(this.cbxMedicament);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmConsulterMedicament";
            this.Text = "Consulter un medicament";
            this.Load += new System.EventHandler(this.FrmConsulterMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxMedicament;
        private System.Windows.Forms.BindingSource bsMedicament;
        private System.Windows.Forms.Button btnVoirRapport;
        private System.Windows.Forms.Button button1;
        private UC.UcMedicament ucMedicament1;
    }
}