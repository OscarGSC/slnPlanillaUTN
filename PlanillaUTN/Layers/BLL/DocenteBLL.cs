using PlanillaUTN.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanillaUTN.Layers.BLL
{
    class DocenteBLL
    {
        public Entities.Docente DocenteID(string id)
        {
            try
            {
                return DAL.DocenteDAL.SeleccionarDocenteIDSP(id);
            }
            catch (Exception)
            {
                //Log4NET para guardar en bitacora el error

                throw new ApplicationException("Ocurrió un error al eliminar. Póngase en contacto con ... No existe en la BD"); ;
            }
        }
        public void Guardar(Entities.Docente doc)
        {
            try
            {
                DAL.DocenteDAL.InsertarSP(doc);
            }
            catch (Exception)
            {
                //Log4NET para guardar en bitacora el error

                throw new ApplicationException("Ocurrió un error al guardar. Póngase en contacto con ..."); ;
            }
        }
        public static List<Entities.Docente> ObtenerTodos()
        {
            return DAL.DocenteDAL.SeleccionarTodosSP();
        }

        public double CalcularSalario(string idDocente)
        {
            Docente doc = DocenteID(idDocente);
            Categoria cat = CategoriaBLL.ObtenerCatPorID(doc.IdCategoria);
            Nombramiento nom = NombramientoBLL.SeleccionarPorID(doc.Id);
            Jornada jor = JornadaBLL.JornadaID(doc.Id);

            decimal regla1 = cat.SalarioBase * jor.PorcentajeSalario;
        }
    }
}
