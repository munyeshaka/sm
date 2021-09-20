namespace View
{
    partial class usVenteAdmin
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
            this.btnRechercheVente = new System.Windows.Forms.Button();
            this.tRechercheVente = new System.Windows.Forms.TextBox();
            this.dgvVente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRechercheVente
            // 
            this.btnRechercheVente.Location = new System.Drawing.Point(622, 57);
            this.btnRechercheVente.Name = "btnRechercheVente";
            this.btnRechercheVente.Size = new System.Drawing.Size(75, 23);
            this.btnRechercheVente.TabIndex = 16;
            this.btnRechercheVente.Text = "Recherche";
            this.btnRechercheVente.UseVisualStyleBackColor = true;
            // 
            // tRechercheVente
            // 
            this.tRechercheVente.Location = new System.Drawing.Point(507, 60);
            this.tRechercheVente.Name = "tRechercheVente";
            this.tRechercheVente.Size = new System.Drawing.Size(100, 20);
            this.tRechercheVente.TabIndex = 15;
            // 
            // dgvVente
            // 
            this.dgvVente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVente.Location = new System.Drawing.Point(180, 86);
            this.dgvVente.Name = "dgvVente";
            this.dgvVente.Size = new System.Drawing.Size(517, 320);
            this.dgvVente.TabIndex = 14;
            // 
            // usVenteAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRechercheVente);
            this.Controls.Add(this.tRechercheVente);
            this.Controls.Add(this.dgvVente);
            this.Name = "usVenteAdmin";
            this.Size = new System.Drawing.Size(876, 463);
            this.Load += new System.EventHandler(this.usVenteAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRechercheVente;
        private System.Windows.Forms.TextBox tRechercheVente;
        private System.Windows.Forms.DataGridView dgvVente;
    }
}
