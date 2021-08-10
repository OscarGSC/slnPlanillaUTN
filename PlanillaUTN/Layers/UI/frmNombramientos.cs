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
    public partial class frmNombramientos : Form
    {
        public frmNombramientos()
        {
            InitializeComponent();
        }

        private void frmNombramientos_Load(object sender, EventArgs e)
        {
            try
            {

                PlanillaUTN.Layers.BLL.JornadaBLL logica = new PlanillaUTN.Layers.BLL.JornadaBLL();

                PlanillaUTN.Layers.Entities.Jornada jor = new PlanillaUTN.Layers.Entities.Jornada();
                
                lbDisponibles.DataSource = actualizarOpcionales();
                lbSeleccionadas.DataSource = logica.ObtenerDescrip(frmCalcularSalarios.docente.Id);

            }
            catch (ApplicationException appEx)
            {
                MessageBox.Show(appEx.Message, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no controlado: " + ex.Message, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<string> actualizarOpcionales()
        {
            PlanillaUTN.Layers.BLL.JornadaBLL logica = new PlanillaUTN.Layers.BLL.JornadaBLL();
            List<string> lista = new List<string>(); 
            foreach (string item in logica.ObtenerTodos())
            {
                if (!logica.ObtenerDescrip(frmCalcularSalarios.docente.Id).Contains(item))
                {
                    lista.Add(item);
                }   
            }
            return lista;
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                PlanillaUTN.Layers.BLL.NombramientoBLL logicaNom = new PlanillaUTN.Layers.BLL.NombramientoBLL();
                PlanillaUTN.Layers.Entities.Nombramiento nom = new PlanillaUTN.Layers.Entities.Nombramiento();
                PlanillaUTN.Layers.BLL.JornadaBLL logicaJor = new PlanillaUTN.Layers.BLL.JornadaBLL();
                nom.IdDocente = frmCalcularSalarios.docente.Id;
                foreach (Jornada item in logicaJor.ObtenerJornadas())
                {
                    if (item.Descripcion.Equals(lbDisponibles.SelectedItem.ToString()))
                    {
                        nom.IdJornada = item.Id;
                    }
                }

                logicaNom.Guardar(nom);
                lbSeleccionadas.DataSource = logicaJor.ObtenerDescrip(frmCalcularSalarios.docente.Id);
                lbDisponibles.DataSource = actualizarOpcionales();
                
            }
            catch (ApplicationException appEx)
            {
                MessageBox.Show(appEx.Message, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no controlado: " + ex.Message, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                PlanillaUTN.Layers.BLL.JornadaBLL logica = new PlanillaUTN.Layers.BLL.JornadaBLL();
                PlanillaUTN.Layers.Entities.Nombramiento nom = new PlanillaUTN.Layers.Entities.Nombramiento();
                foreach (Jornada item in logica.ObtenerJornadas())
                {
                    if (item.Descripcion.Equals(lbSeleccionadas.SelectedItem.ToString()))
                    {
                        BLL.NombramientoBLL.Eliminar(frmCalcularSalarios.docente.Id, nom.IdJornada = item.Id);
                    }
                }
                
                
                lbSeleccionadas.DataSource = logica.ObtenerDescrip(frmCalcularSalarios.docente.Id);
                lbDisponibles.DataSource = actualizarOpcionales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no controlado: " + ex.Message, "ProyectoProgramadoPrg3", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
