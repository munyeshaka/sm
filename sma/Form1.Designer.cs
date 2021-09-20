namespace sma
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.HomePanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donneesDeBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.Location = new System.Drawing.Point(0, 27);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1023, 549);
            this.HomePanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donneesDeBaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donneesDeBaseToolStripMenuItem
            // 
            this.donneesDeBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produitToolStripMenuItem,
            this.venteToolStripMenuItem});
            this.donneesDeBaseToolStripMenuItem.Name = "donneesDeBaseToolStripMenuItem";
            this.donneesDeBaseToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.donneesDeBaseToolStripMenuItem.Text = "Utilisateur";
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.produitToolStripMenuItem.Text = "Caissier";
            this.produitToolStripMenuItem.Click += new System.EventHandler(this.produitToolStripMenuItem_Click);
            // 
            // venteToolStripMenuItem
            // 
            this.venteToolStripMenuItem.Name = "venteToolStripMenuItem";
            this.venteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.venteToolStripMenuItem.Text = "Admin";
            this.venteToolStripMenuItem.Click += new System.EventHandler(this.venteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 579);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donneesDeBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venteToolStripMenuItem;
    }
}

