namespace View
{
    partial class ucUser
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
            this.btnRechercheUser = new System.Windows.Forms.Button();
            this.tRechercheUser = new System.Windows.Forms.TextBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.tusername = new System.Windows.Forms.TextBox();
            this.btnModifierUser = new System.Windows.Forms.Button();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.btnAjouterUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSupprimerUser = new System.Windows.Forms.Button();
            this.tidUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRechercheUser
            // 
            this.btnRechercheUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercheUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRechercheUser.Location = new System.Drawing.Point(735, 236);
            this.btnRechercheUser.Name = "btnRechercheUser";
            this.btnRechercheUser.Size = new System.Drawing.Size(93, 23);
            this.btnRechercheUser.TabIndex = 20;
            this.btnRechercheUser.Text = "Recherche";
            this.btnRechercheUser.UseVisualStyleBackColor = true;
            this.btnRechercheUser.Click += new System.EventHandler(this.btnRechercheUser_Click);
            // 
            // tRechercheUser
            // 
            this.tRechercheUser.Location = new System.Drawing.Point(616, 239);
            this.tRechercheUser.Name = "tRechercheUser";
            this.tRechercheUser.Size = new System.Drawing.Size(100, 20);
            this.tRechercheUser.TabIndex = 19;
            // 
            // dgvUser
            // 
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(31, 275);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(797, 258);
            this.dgvUser.TabIndex = 18;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // tusername
            // 
            this.tusername.Location = new System.Drawing.Point(373, 15);
            this.tusername.Name = "tusername";
            this.tusername.Size = new System.Drawing.Size(141, 22);
            this.tusername.TabIndex = 17;
            // 
            // btnModifierUser
            // 
            this.btnModifierUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnModifierUser.Location = new System.Drawing.Point(265, 77);
            this.btnModifierUser.Name = "btnModifierUser";
            this.btnModifierUser.Size = new System.Drawing.Size(91, 23);
            this.btnModifierUser.TabIndex = 16;
            this.btnModifierUser.Text = "Modifier";
            this.btnModifierUser.UseVisualStyleBackColor = true;
            this.btnModifierUser.Click += new System.EventHandler(this.btnModifierUser_Click);
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(644, 18);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(141, 22);
            this.tPassword.TabIndex = 15;
            // 
            // btnAjouterUser
            // 
            this.btnAjouterUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAjouterUser.Location = new System.Drawing.Point(144, 77);
            this.btnAjouterUser.Name = "btnAjouterUser";
            this.btnAjouterUser.Size = new System.Drawing.Size(91, 23);
            this.btnAjouterUser.TabIndex = 14;
            this.btnAjouterUser.Text = "Ajouter";
            this.btnAjouterUser.UseVisualStyleBackColor = true;
            this.btnAjouterUser.Click += new System.EventHandler(this.btnAjouterUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(295, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "UTILISATEUR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Username";
            // 
            // btnSupprimerUser
            // 
            this.btnSupprimerUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSupprimerUser.Location = new System.Drawing.Point(387, 77);
            this.btnSupprimerUser.Name = "btnSupprimerUser";
            this.btnSupprimerUser.Size = new System.Drawing.Size(91, 23);
            this.btnSupprimerUser.TabIndex = 23;
            this.btnSupprimerUser.Text = "Supprimer";
            this.btnSupprimerUser.UseVisualStyleBackColor = true;
            this.btnSupprimerUser.Click += new System.EventHandler(this.btnSupprimerUser_Click);
            // 
            // tidUser
            // 
            this.tidUser.Enabled = false;
            this.tidUser.Location = new System.Drawing.Point(94, 15);
            this.tidUser.Name = "tidUser";
            this.tidUser.Size = new System.Drawing.Size(141, 22);
            this.tidUser.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "id";
            // 
            // btnActualiser
            // 
            this.btnActualiser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnActualiser.Location = new System.Drawing.Point(501, 77);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(89, 23);
            this.btnActualiser.TabIndex = 26;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.tidUser);
            this.panel1.Controls.Add(this.btnActualiser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSupprimerUser);
            this.panel1.Controls.Add(this.tusername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tPassword);
            this.panel1.Controls.Add(this.btnModifierUser);
            this.panel1.Controls.Add(this.btnAjouterUser);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(31, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 112);
            this.panel1.TabIndex = 27;
            // 
            // ucUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRechercheUser);
            this.Controls.Add(this.tRechercheUser);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.label1);
            this.Name = "ucUser";
            this.Size = new System.Drawing.Size(862, 550);
            this.Load += new System.EventHandler(this.ucUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRechercheUser;
        private System.Windows.Forms.TextBox tRechercheUser;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TextBox tusername;
        private System.Windows.Forms.Button btnModifierUser;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button btnAjouterUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSupprimerUser;
        private System.Windows.Forms.TextBox tidUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Panel panel1;

    }
}
