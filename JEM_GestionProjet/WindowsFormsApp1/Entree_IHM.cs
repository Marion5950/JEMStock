using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Entree_IHM : Form
    {
        
        public Entree_IHM()
        {
            InitializeComponent();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string Reference = textBoxReference.Text;
            string Famille = textBoxFamille.Text;
            string Designation = textBoxDesignation.Text;
            string Fournisseur = textBoxFournisseur.Text;
            string Quantite = textBoxQuantite.Text;
            string QuantiteMin = textBoxQuantiteMin.Text;
        }
    }
}
