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
    public partial class frmRepDocentes : Form
    {
        public frmRepDocentes()
        {
            InitializeComponent();
        }

        private void frmRepDocentes_Load(object sender, EventArgs e)
        {
            DocenteBindingSource.DataSource = BLL.DocenteBLL.ObtenerTodos();
            this.reportViewer1.RefreshReport();
        }
    }
}
