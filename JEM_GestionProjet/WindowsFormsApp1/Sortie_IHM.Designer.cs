namespace WindowsFormsApp1
{
    partial class Sortie_IHM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sortie_IHM));
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonAnnulerSortie = new System.Windows.Forms.Button();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.labelRef = new System.Windows.Forms.Label();
            this.textBoxRefSortie = new System.Windows.Forms.TextBox();
            this.textBoxQuantiteSortie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sortie";
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSupprimer.Location = new System.Drawing.Point(271, 242);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(129, 33);
            this.buttonSupprimer.TabIndex = 18;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonAnnulerSortie
            // 
            this.buttonAnnulerSortie.BackColor = System.Drawing.Color.Firebrick;
            this.buttonAnnulerSortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnulerSortie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAnnulerSortie.Location = new System.Drawing.Point(413, 242);
            this.buttonAnnulerSortie.Name = "buttonAnnulerSortie";
            this.buttonAnnulerSortie.Size = new System.Drawing.Size(123, 33);
            this.buttonAnnulerSortie.TabIndex = 17;
            this.buttonAnnulerSortie.Text = "Annuler";
            this.buttonAnnulerSortie.UseVisualStyleBackColor = false;
            this.buttonAnnulerSortie.Click += new System.EventHandler(this.buttonAnnulerSortie_Click);
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantite.Location = new System.Drawing.Point(49, 171);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(63, 16);
            this.labelQuantite.TabIndex = 16;
            this.labelQuantite.Text = "Quantité :";
            // 
            // labelRef
            // 
            this.labelRef.AutoSize = true;
            this.labelRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRef.Location = new System.Drawing.Point(49, 108);
            this.labelRef.Name = "labelRef";
            this.labelRef.Size = new System.Drawing.Size(77, 16);
            this.labelRef.TabIndex = 15;
            this.labelRef.Text = "Référence :";
            // 
            // textBoxRefSortie
            // 
            this.textBoxRefSortie.Location = new System.Drawing.Point(199, 107);
            this.textBoxRefSortie.Name = "textBoxRefSortie";
            this.textBoxRefSortie.Size = new System.Drawing.Size(339, 20);
            this.textBoxRefSortie.TabIndex = 19;
            // 
            // textBoxQuantiteSortie
            // 
            this.textBoxQuantiteSortie.Location = new System.Drawing.Point(199, 161);
            this.textBoxQuantiteSortie.Name = "textBoxQuantiteSortie";
            this.textBoxQuantiteSortie.Size = new System.Drawing.Size(339, 20);
            this.textBoxQuantiteSortie.TabIndex = 20;
            // 
            // Sortie_IHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 305);
            this.Controls.Add(this.textBoxQuantiteSortie);
            this.Controls.Add(this.textBoxRefSortie);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAnnulerSortie);
            this.Controls.Add(this.labelQuantite);
            this.Controls.Add(this.labelRef);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sortie_IHM";
            this.Text = "JEM Sortie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonAnnulerSortie;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.Label labelRef;
        private System.Windows.Forms.TextBox textBoxRefSortie;
        private System.Windows.Forms.TextBox textBoxQuantiteSortie;
    }
}