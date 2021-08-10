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
    public partial class frmRegistroDocentes : Form
    {
        public frmRegistroDocentes()
        {
            InitializeComponent();
        }

        private void frmRegistroDocentes_Load(object sender, EventArgs e)
        {
            cmbCategorias.DataSource = BLL.CategoriaBLL.ObtenerDescrip();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            try
            {
                PlanillaUTN.Layers.BLL.DocenteBLL logica = new PlanillaUTN.Layers.BLL.DocenteBLL();
                PlanillaUTN.Layers.Entities.Docente doc = logica.DocenteID(Convert.ToInt32(mtxId.Text));
                if (doc.Nombre == null)
                {
                    try
                    {
                
                        Entities.Docente docR = new Entities.Docente();
                        docR.Id = int.Parse(mtxId.Text);
                        docR.Nombre = txtNombre.Text;
                        docR.Apellido = txtApellido.Text;
                        docR.FechaIngreso = dtpFechaIngreso.Value.Date;
                        docR.Email = txtEmail.Text;
                        docR.IdCategoria = Convert.ToString(cmbCategorias.SelectedIndex + 1);


                        logica.Guardar(docR);

                        MessageBox.Show("Docente registrado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        frmPrincipal frm = new frmPrincipal();
                        frm.Show();
                    }
                    catch (ApplicationException appEx)
                    {
                        MessageBox.Show(appEx.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error no controlado: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtNombre.Text = doc.Nombre;
                    txtApellido.Text = doc.Apellido;
                    dtpFechaIngreso.Value = doc.FechaIngreso;
                    txtEmail.Text = doc.Email;
                    switch (doc.IdCategoria)
                    {
                        case "1":
                            cmbCategorias.SelectedIndex = 0;
                            break;
                        case "2":
                            cmbCategorias.SelectedIndex = 1;
                            break;
                        case "3":
                            cmbCategorias.SelectedIndex = 2;
                            break;
                        case "4":
                            cmbCategorias.SelectedIndex = 3;
                            break;
                        case "5":
                            cmbCategorias.SelectedIndex = 4;
                            break;
                    }
                }
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
    }
}
