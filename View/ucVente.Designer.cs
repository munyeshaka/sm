namespace View
{
    partial class ucVente
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRechercheVente = new System.Windows.Forms.Button();
            this.tRechercheVente = new System.Windows.Forms.TextBox();
            this.dgvVente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tidProdVente = new System.Windows.Forms.TextBox();
            this.idProdll = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSupprimerVente = new System.Windows.Forms.Button();
            this.btnModifierVente = new System.Windows.Forms.Button();
            this.tPrixProdVente = new System.Windows.Forms.TextBox();
            this.tQuantiteProdVente = new System.Windows.Forms.TextBox();
            this.tNomProdVente = new System.Windows.Forms.TextBox();
            this.btnAjouterVente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTE";
            // 
            // btnRechercheVente
            // 
            this.btnRechercheVente.Location = new System.Drawing.Point(678, 235);
            this.btnRechercheVente.Name = "btnRechercheVente";
            this.btnRechercheVente.Size = new System.Drawing.Size(75, 23);
            this.btnRechercheVente.TabIndex = 13;
            this.btnRechercheVente.Text = "Recherche";
            this.btnRechercheVente.UseVisualStyleBackColor = true;
            // 
            // tRechercheVente
            // 
            this.tRechercheVente.Location = new System.Drawing.Point(557, 237);
            this.tRechercheVente.Name = "tRechercheVente";
            this.tRechercheVente.Size = new System.Drawing.Size(100, 20);
            this.tRechercheVente.TabIndex = 12;
            // 
            // dgvVente
            // 
            this.dgvVente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVente.Location = new System.Drawing.Point(236, 264);
            this.dgvVente.Name = "dgvVente";
            this.dgvVente.Size = new System.Drawing.Size(517, 320);
            this.dgvVente.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tidProdVente);
            this.groupBox1.Controls.Add(this.idProdll);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSupprimerVente);
            this.groupBox1.Controls.Add(this.btnModifierVente);
            this.groupBox1.Controls.Add(this.tPrixProdVente);
            this.groupBox1.Controls.Add(this.tQuantiteProdVente);
            this.groupBox1.Controls.Add(this.tNomProdVente);
            this.groupBox1.Controls.Add(this.btnAjouterVente);
            this.groupBox1.Location = new System.Drawing.Point(236, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 148);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // tidProdVente
            // 
            this.tidProdVente.Enabled = false;
            this.tidProdVente.Location = new System.Drawing.Point(92, 19);
            this.tidProdVente.Name = "tidProdVente";
            this.tidProdVente.Size = new System.Drawing.Size(100, 20);
            this.tidProdVente.TabIndex = 8;
            // 
            // idProdll
            // 
            this.idProdll.AutoSize = true;
            this.idProdll.Location = new System.Drawing.Point(30, 22);
            this.idProdll.Name = "idProdll";
            this.idProdll.Size = new System.Drawing.Size(14, 13);
            this.idProdll.TabIndex = 7;
            this.idProdll.Text = "#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantitée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix";
            // 
            // btnSupprimerVente
            // 
            this.btnSupprimerVente.Location = new System.Drawing.Point(282, 112);
            this.btnSupprimerVente.Name = "btnSupprimerVente";
            this.btnSupprimerVente.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerVente.TabIndex = 5;
            this.btnSupprimerVente.Text = "Supprimer";
            this.btnSupprimerVente.UseVisualStyleBackColor = true;
            // 
            // btnModifierVente
            // 
            this.btnModifierVente.Location = new System.Drawing.Point(188, 112);
            this.btnModifierVente.Name = "btnModifierVente";
            this.btnModifierVente.Size = new System.Drawing.Size(75, 23);
            this.btnModifierVente.TabIndex = 4;
            this.btnModifierVente.Text = "Modifier";
            this.btnModifierVente.UseVisualStyleBackColor = true;
            // 
            // tPrixProdVente
            // 
            this.tPrixProdVente.Location = new System.Drawing.Point(336, 12);
            this.tPrixProdVente.Name = "tPrixProdVente";
            this.tPrixProdVente.Size = new System.Drawing.Size(100, 20);
            this.tPrixProdVente.TabIndex = 3;
            // 
            // tQuantiteProdVente
            // 
            this.tQuantiteProdVente.Location = new System.Drawing.Point(336, 48);
            this.tQuantiteProdVente.Name = "tQuantiteProdVente";
            this.tQuantiteProdVente.Size = new System.Drawing.Size(100, 20);
            this.tQuantiteProdVente.TabIndex = 2;
            // 
            // tNomProdVente
            // 
            this.tNomProdVente.Location = new System.Drawing.Point(92, 55);
            this.tNomProdVente.Name = "tNomProdVente";
            this.tNomProdVente.Size = new System.Drawing.Size(100, 20);
            this.tNomProdVente.TabIndex = 1;
            // 
            // btnAjouterVente
            // 
            this.btnAjouterVente.Location = new System.Drawing.Point(92, 112);
            this.btnAjouterVente.Name = "btnAjouterVente";
            this.btnAjouterVente.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterVente.TabIndex = 0;
            this.btnAjouterVente.Text = "Ajouter";
            this.btnAjouterVente.UseVisualStyleBackColor = true;
            this.btnAjouterVente.Click += new System.EventHandler(this.btnAjouterVente_Click);
            // 
            // ucVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRechercheVente);
            this.Controls.Add(this.tRechercheVente);
            this.Controls.Add(this.dgvVente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ucVente";
            this.Size = new System.Drawing.Size(1001, 522);
            this.Load += new System.EventHandler(this.ucVente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRechercheVente;
        private System.Windows.Forms.TextBox tRechercheVente;
        private System.Windows.Forms.DataGridView dgvVente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tidProdVente;
        private System.Windows.Forms.Label idProdll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSupprimerVente;
        private System.Windows.Forms.Button btnModifierVente;
        private System.Windows.Forms.TextBox tPrixProdVente;
        private System.Windows.Forms.TextBox tQuantiteProdVente;
        private System.Windows.Forms.TextBox tNomProdVente;
        private System.Windows.Forms.Button btnAjouterVente;
    }
}
