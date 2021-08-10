using PlanillaUTN.Layers.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanillaUTN.Layers.UI
{
    public partial class frmCalcularSalarios : Form
    {
        internal static Docente docente;
        public frmCalcularSalarios()
        {
            InitializeComponent();
        }

        private void frmCalcularSalarios_Load(object sender, EventArgs e)
        {
            try
            {
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no controlado: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNombramientos_Click(object sender, EventArgs e)
        {
            docente = (Entities.Docente)dgvDocentes.SelectedRows[0].DataBoundItem;
            frmNombramientos frm = new frmNombramientos();
            frm.ShowDialog();
        }
        private void Refrescar()
        {
            dgvDocentes.DataSource = BLL.DocenteBLL.ObtenerTodos();
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            try
            {
                docente = (Entities.Docente)dgvDocentes.SelectedRows[0].DataBoundItem;
                PlanillaUTN.Layers.BLL.NombramientoBLL logica = new PlanillaUTN.Layers.BLL.NombramientoBLL();
                logica.ObtenerDescrip(docente.Id);
                PlanillaUTN.Layers.BLL.DocenteBLL doc = new PlanillaUTN.Layers.BLL.DocenteBLL();
                MessageBox.Show("Salario: " + doc.CalcularSalario(docente.Id).ToString("c"));
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
