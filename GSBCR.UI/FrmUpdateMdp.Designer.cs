namespace GSBCR.UI
{
    partial class FrmUpdateMdp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAncMdp = new System.Windows.Forms.TextBox();
            this.txtNewMdp = new System.Windows.Forms.TextBox();
            this.txtConfirmNewMdp = new System.Windows.Forms.TextBox();
            this.btnValid = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mot de Passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "_________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ancien mot de passe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nouveau mot de passe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirmer nouveau mot de passe";
            // 
            // txtAncMdp
            // 
            this.txtAncMdp.Location = new System.Drawing.Point(136, 162);
            this.txtAncMdp.Name = "txtAncMdp";
            this.txtAncMdp.PasswordChar = '*';
            this.txtAncMdp.Size = new System.Drawing.Size(214, 20);
            this.txtAncMdp.TabIndex = 5;
            // 
            // txtNewMdp
            // 
            this.txtNewMdp.Location = new System.Drawing.Point(136, 239);
            this.txtNewMdp.Name = "txtNewMdp";
            this.txtNewMdp.PasswordChar = '*';
            this.txtNewMdp.Size = new System.Drawing.Size(214, 20);
            this.txtNewMdp.TabIndex = 6;
            // 
            // txtConfirmNewMdp
            // 
            this.txtConfirmNewMdp.Location = new System.Drawing.Point(136, 312);
            this.txtConfirmNewMdp.Name = "txtConfirmNewMdp";
            this.txtConfirmNewMdp.PasswordChar = '*';
            this.txtConfirmNewMdp.Size = new System.Drawing.Size(214, 20);
            this.txtConfirmNewMdp.TabIndex = 7;
            // 
            // btnValid
            // 
            this.btnValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValid.Location = new System.Drawing.Point(380, 386);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(107, 39);
            this.btnValid.TabIndex = 8;
            this.btnValid.Text = "Valider";
            this.btnValid.UseVisualStyleBackColor = true;
            this.btnValid.Click += new System.EventHandler(this.btnValid_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(257, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 39);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(51, 95);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(51, 16);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "label6";
            this.lblError.Visible = false;
            // 
            // FrmUpdateMdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.txtConfirmNewMdp);
            this.Controls.Add(this.txtNewMdp);
            this.Controls.Add(this.txtAncMdp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdateMdp";
            this.Text = "FrmUpdateMdp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAncMdp;
        private System.Windows.Forms.TextBox txtNewMdp;
        private System.Windows.Forms.TextBox txtConfirmNewMdp;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblError;
    }
}