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
            this.btnRechercheVente = new System.Windows.Forms.Button();
            this.tRechercheVente = new System.Windows.Forms.TextBox();
            this.dgvVente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualiser = new System.Windows.Forms.Button();
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
            this.VENTE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRechercheVente
            // 
            this.btnRechercheVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercheVente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRechercheVente.Location = new System.Drawing.Point(789, 231);
            this.btnRechercheVente.Name = "btnRechercheVente";
            this.btnRechercheVente.Size = new System.Drawing.Size(99, 23);
            this.btnRechercheVente.TabIndex = 13;
            this.btnRechercheVente.Text = "Recherche";
            this.btnRechercheVente.UseVisualStyleBackColor = true;
            this.btnRechercheVente.Click += new System.EventHandler(this.btnRechercheVente_Click);
            // 
            // tRechercheVente
            // 
            this.tRechercheVente.Location = new System.Drawing.Point(673, 233);
            this.tRechercheVente.Name = "tRechercheVente";
            this.tRechercheVente.Size = new System.Drawing.Size(100, 20);
            this.tRechercheVente.TabIndex = 12;
            // 
            // dgvVente
            // 
            this.dgvVente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVente.Location = new System.Drawing.Point(98, 263);
            this.dgvVente.Name = "dgvVente";
            this.dgvVente.Size = new System.Drawing.Size(790, 237);
            this.dgvVente.TabIndex = 11;
            this.dgvVente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVente_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.btnActualiser);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(98, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 126);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // btnActualiser
            // 
            this.btnActualiser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnActualiser.Location = new System.Drawing.Point(551, 81);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(95, 23);
            this.btnActualiser.TabIndex = 10;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // tidProdVente
            // 
            this.tidProdVente.Enabled = false;
            this.tidProdVente.Location = new System.Drawing.Point(92, 19);
            this.tidProdVente.Name = "tidProdVente";
            this.tidProdVente.Size = new System.Drawing.Size(100, 22);
            this.tidProdVente.TabIndex = 8;
            // 
            // idProdll
            // 
            this.idProdll.AutoSize = true;
            this.idProdll.Location = new System.Drawing.Point(30, 22);
            this.idProdll.Name = "idProdll";
            this.idProdll.Size = new System.Drawing.Size(16, 16);
            this.idProdll.TabIndex = 7;
            this.idProdll.Text = "#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantitée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix";
            // 
            // btnSupprimerVente
            // 
            this.btnSupprimerVente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSupprimerVente.Location = new System.Drawing.Point(416, 81);
            this.btnSupprimerVente.Name = "btnSupprimerVente";
            this.btnSupprimerVente.Size = new System.Drawing.Size(89, 23);
            this.btnSupprimerVente.TabIndex = 5;
            this.btnSupprimerVente.Text = "Supprimer";
            this.btnSupprimerVente.UseVisualStyleBackColor = true;
            this.btnSupprimerVente.Click += new System.EventHandler(this.btnSupprimerVente_Click);
            // 
            // btnModifierVente
            // 
            this.btnModifierVente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnModifierVente.Location = new System.Drawing.Point(285, 81);
            this.btnModifierVente.Name = "btnModifierVente";
            this.btnModifierVente.Size = new System.Drawing.Size(85, 23);
            this.btnModifierVente.TabIndex = 4;
            this.btnModifierVente.Text = "Modifier";
            this.btnModifierVente.UseVisualStyleBackColor = true;
            this.btnModifierVente.Click += new System.EventHandler(this.btnModifierVente_Click);
            // 
            // tPrixProdVente
            // 
            this.tPrixProdVente.Location = new System.Drawing.Point(247, 19);
            this.tPrixProdVente.Name = "tPrixProdVente";
            this.tPrixProdVente.Size = new System.Drawing.Size(123, 22);
            this.tPrixProdVente.TabIndex = 3;
            // 
            // tQuantiteProdVente
            // 
            this.tQuantiteProdVente.Location = new System.Drawing.Point(678, 16);
            this.tQuantiteProdVente.Name = "tQuantiteProdVente";
            this.tQuantiteProdVente.Size = new System.Drawing.Size(106, 22);
            this.tQuantiteProdVente.TabIndex = 2;
            // 
            // tNomProdVente
            // 
            this.tNomProdVente.Location = new System.Drawing.Point(448, 19);
            this.tNomProdVente.Name = "tNomProdVente";
            this.tNomProdVente.Size = new System.Drawing.Size(100, 22);
            this.tNomProdVente.TabIndex = 1;
            // 
            // btnAjouterVente
            // 
            this.btnAjouterVente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAjouterVente.Location = new System.Drawing.Point(166, 81);
            this.btnAjouterVente.Name = "btnAjouterVente";
            this.btnAjouterVente.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterVente.TabIndex = 0;
            this.btnAjouterVente.Text = "Ajouter";
            this.btnAjouterVente.UseVisualStyleBackColor = true;
            this.btnAjouterVente.Click += new System.EventHandler(this.btnAjouterVente_Click);
            // 
            // VENTE
            // 
            this.VENTE.AutoSize = true;
            this.VENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VENTE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.VENTE.Location = new System.Drawing.Point(424, 13);
            this.VENTE.Name = "VENTE";
            this.VENTE.Size = new System.Drawing.Size(116, 33);
            this.VENTE.TabIndex = 14;
            this.VENTE.Text = "VENTE";
            // 
            // ucVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VENTE);
            this.Controls.Add(this.btnRechercheVente);
            this.Controls.Add(this.tRechercheVente);
            this.Controls.Add(this.dgvVente);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Label VENTE;
    }
}
