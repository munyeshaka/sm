namespace View
{
    partial class ucAdmin
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelVente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.White;
            this.panelAdmin.Location = new System.Drawing.Point(184, 3);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(895, 570);
            this.panelAdmin.TabIndex = 1;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(46, 135);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(78, 16);
            this.labelUser.TabIndex = 9;
            this.labelUser.Text = "Utilisateur";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.Color.White;
            this.labelStock.Location = new System.Drawing.Point(46, 71);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(47, 16);
            this.labelStock.TabIndex = 7;
            this.labelStock.Text = "Stock";
            this.labelStock.Click += new System.EventHandler(this.labelStock_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "DASHBOARD";
            // 
            // labelVente
            // 
            this.labelVente.AutoSize = true;
            this.labelVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVente.ForeColor = System.Drawing.Color.White;
            this.labelVente.Location = new System.Drawing.Point(46, 102);
            this.labelVente.Name = "labelVente";
            this.labelVente.Size = new System.Drawing.Size(48, 16);
            this.labelVente.TabIndex = 8;
            this.labelVente.Text = "Vente";
            this.labelVente.Click += new System.EventHandler(this.labelVente_Click);
            // 
            // ucAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelVente);
            this.Controls.Add(this.panelAdmin);
            this.Name = "ucAdmin";
            this.Size = new System.Drawing.Size(1094, 576);
            this.Load += new System.EventHandler(this.ucAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelVente;
    }
}
