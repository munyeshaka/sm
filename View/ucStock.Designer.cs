namespace View
{
    partial class ucStock
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tidProd = new System.Windows.Forms.TextBox();
            this.idProdll = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.tPrixProd = new System.Windows.Forms.TextBox();
            this.tQuantiteProd = new System.Windows.Forms.TextBox();
            this.tNomProd = new System.Windows.Forms.TextBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.tRecherche = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(242, 112);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "STOCK";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tidProd);
            this.groupBox1.Controls.Add(this.idProdll);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Controls.Add(this.tPrixProd);
            this.groupBox1.Controls.Add(this.tQuantiteProd);
            this.groupBox1.Controls.Add(this.tNomProd);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Location = new System.Drawing.Point(17, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUIT";
            // 
            // tidProd
            // 
            this.tidProd.Enabled = false;
            this.tidProd.Location = new System.Drawing.Point(242, 19);
            this.tidProd.Name = "tidProd";
            this.tidProd.Size = new System.Drawing.Size(100, 20);
            this.tidProd.TabIndex = 8;
            // 
            // idProdll
            // 
            this.idProdll.AutoSize = true;
            this.idProdll.Location = new System.Drawing.Point(167, 22);
            this.idProdll.Name = "idProdll";
            this.idProdll.Size = new System.Drawing.Size(14, 13);
            this.idProdll.TabIndex = 7;
            this.idProdll.Text = "#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantitée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(484, 112);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(361, 112);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // tPrixProd
            // 
            this.tPrixProd.Location = new System.Drawing.Point(459, 19);
            this.tPrixProd.Name = "tPrixProd";
            this.tPrixProd.Size = new System.Drawing.Size(100, 20);
            this.tPrixProd.TabIndex = 3;
            // 
            // tQuantiteProd
            // 
            this.tQuantiteProd.Location = new System.Drawing.Point(459, 52);
            this.tQuantiteProd.Name = "tQuantiteProd";
            this.tQuantiteProd.Size = new System.Drawing.Size(100, 20);
            this.tQuantiteProd.TabIndex = 2;
            // 
            // tNomProd
            // 
            this.tNomProd.Location = new System.Drawing.Point(242, 52);
            this.tNomProd.Name = "tNomProd";
            this.tNomProd.Size = new System.Drawing.Size(100, 20);
            this.tNomProd.TabIndex = 1;
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(180, 262);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(438, 320);
            this.dgvStock.TabIndex = 4;
            // 
            // tRecherche
            // 
            this.tRecherche.Location = new System.Drawing.Point(422, 236);
            this.tRecherche.Name = "tRecherche";
            this.tRecherche.Size = new System.Drawing.Size(100, 20);
            this.tRecherche.TabIndex = 7;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(543, 233);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(75, 23);
            this.btnRecherche.TabIndex = 9;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            // 
            // ucStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.tRecherche);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ucStock";
            this.Size = new System.Drawing.Size(911, 602);
            this.Load += new System.EventHandler(this.ucStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox tPrixProd;
        private System.Windows.Forms.TextBox tQuantiteProd;
        private System.Windows.Forms.TextBox tNomProd;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.TextBox tRecherche;
        private System.Windows.Forms.TextBox tidProd;
        private System.Windows.Forms.Label idProdll;
        private System.Windows.Forms.Button btnRecherche;
    }
}
