using PlanillaUTN.Layers.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanillaUTN
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Utilitarios.Sistema.CultureInfo();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmRegistroDocentes();
            frm.ShowDialog();
        }

        private void salarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmCalcularSalarios();
            frm.ShowDialog();
        }

        private void docentesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmRepDocentes();
            frm.ShowDialog();
        }
    }
}
