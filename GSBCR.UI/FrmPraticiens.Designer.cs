namespace GSBCR.UI
{
    partial class FrmPraticiens
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
            this.cbx_Praticiens = new System.Windows.Forms.ComboBox();
            this.lbl_Praticien = new System.Windows.Forms.Label();
            this.ucPraticien1 = new GSBCR.UC.UcPraticien();
            this.bsPraticiens = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticiens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Separateur
            // 
            this.pnl_Separateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Separateur.Location = new System.Drawing.Point(23, 45);
            this.pnl_Separateur.Name = "pnl_Separateur";
            this.pnl_Separateur.Size = new System.Drawing.Size(398, 2);
            this.pnl_Separateur.TabIndex = 29;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.CausesValidation = false;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(162, 22);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(121, 20);
            this.lblTitre.TabIndex = 28;
            this.lblTitre.Text = "Les praticiens";
            // 
            // cbx_Praticiens
            // 
            this.cbx_Praticiens.FormattingEnabled = true;
            this.cbx_Praticiens.Location = new System.Drawing.Point(168, 76);
            this.cbx_Praticiens.Name = "cbx_Praticiens";
            this.cbx_Praticiens.Size = new System.Drawing.Size(230, 21);
            this.cbx_Praticiens.TabIndex = 31;
            this.cbx_Praticiens.SelectedIndexChanged += new System.EventHandler(this.cbx_Praticiens_SelectedIndexChanged);
            // 
            // lbl_Praticien
            // 
            this.lbl_Praticien.AutoSize = true;
            this.lbl_Praticien.Location = new System.Drawing.Point(45, 80);
            this.lbl_Praticien.Name = "lbl_Praticien";
            this.lbl_Praticien.Size = new System.Drawing.Size(48, 13);
            this.lbl_Praticien.TabIndex = 30;
            this.lbl_Praticien.Text = "Praticien";
            // 
            // ucPraticien1
            // 
            this.ucPraticien1.Location = new System.Drawing.Point(14, 103);
            this.ucPraticien1.Name = "ucPraticien1";
            this.ucPraticien1.Prati = null;
            this.ucPraticien1.Size = new System.Drawing.Size(420, 386);
            this.ucPraticien1.TabIndex = 32;
            // 
            // FrmPraticiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 492);
            this.Controls.Add(this.ucPraticien1);
            this.Controls.Add(this.cbx_Praticiens);
            this.Controls.Add(this.lbl_Praticien);
            this.Controls.Add(this.pnl_Separateur);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmPraticiens";
            this.Text = "Praticiens";
            this.Load += new System.EventHandler(this.FrmPraticiens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticiens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Separateur;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ComboBox cbx_Praticiens;
        private System.Windows.Forms.Label lbl_Praticien;
        private UC.UcPraticien ucPraticien1;
        private System.Windows.Forms.BindingSource bsPraticiens;
    }
}