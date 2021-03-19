namespace WindowsFormsApp1
{
    partial class JEM_IHM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JEM_IHM));
            this.ButtonNouveau = new System.Windows.Forms.Button();
            this.buttonEntree = new System.Windows.Forms.Button();
            this.buttonSortie = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonNouveau
            // 
            this.ButtonNouveau.BackColor = System.Drawing.Color.SeaGreen;
            this.ButtonNouveau.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNouveau.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ButtonNouveau.Location = new System.Drawing.Point(377, 397);
            this.ButtonNouveau.Name = "ButtonNouveau";
            this.ButtonNouveau.Size = new System.Drawing.Size(133, 41);
            this.ButtonNouveau.TabIndex = 0;
            this.ButtonNouveau.Text = "Nouveau";
            this.ButtonNouveau.UseVisualStyleBackColor = false;
            // 
            // buttonEntree
            // 
            this.buttonEntree.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonEntree.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntree.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonEntree.Location = new System.Drawing.Point(516, 397);
            this.buttonEntree.Name = "buttonEntree";
            this.buttonEntree.Size = new System.Drawing.Size(133, 41);
            this.buttonEntree.TabIndex = 1;
            this.buttonEntree.Text = "Entrée";
            this.buttonEntree.UseVisualStyleBackColor = false;
            // 
            // buttonSortie
            // 
            this.buttonSortie.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSortie.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortie.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonSortie.Location = new System.Drawing.Point(655, 397);
            this.buttonSortie.Name = "buttonSortie";
            this.buttonSortie.Size = new System.Drawing.Size(133, 41);
            this.buttonSortie.TabIndex = 2;
            this.buttonSortie.Text = "Sortie";
            this.buttonSortie.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 328);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(436, 22);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(303, 20);
            this.textBoxSearch.TabIndex = 4;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(745, 20);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(42, 22);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            // 
            // JEM_IHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSortie);
            this.Controls.Add(this.buttonEntree);
            this.Controls.Add(this.ButtonNouveau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JEM_IHM";
            this.Text = "     JEM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonNouveau;
        private System.Windows.Forms.Button buttonEntree;
        private System.Windows.Forms.Button buttonSortie;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonOK;
    }
}

