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
    public partial class JEM_IHM : Form
    {
        public JEM_IHM()
        {
            InitializeComponent();
        }

        private void buttonSortie_Click(object sender, EventArgs e)
        {
            Sortie_IHM frm = new Sortie_IHM();
            frm.Show();
        }

        private void buttonEntree_Click(object sender, EventArgs e)
        {
            Entree_IHM frm = new Entree_IHM();
            frm.Show();

        }
    }
}
