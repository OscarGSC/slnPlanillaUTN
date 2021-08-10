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
        public Entities.Docente DocenteID(int id)
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

        public double CalcularSalario(int idDocente)
        {
            Docente doc = DocenteID(idDocente);
            Categoria cat = CategoriaBLL.ObtenerCatPorID(doc.IdCategoria);
            Nombramiento nom = NombramientoBLL.SeleccionarPorID(doc.Id);
            List<Jornada> jor = JornadaBLL.JornadaID(doc.Id);

            double neto = 0;

            foreach (Jornada item in jor)
            {
                neto += (item.PorcentajeSalario / 100.0) * Convert.ToDouble(cat.SalarioBase);
            }

            double deducciones = 0;
            if (neto > 799000 && neto < 1199000)
            {
                deducciones += ((neto - 799000) * 0.1);
            }
            if (neto > 1199000)
            {
                deducciones +=  ((neto - 1199000) * 0.15);
            }
            deducciones += (neto * 0.09) + (neto * 0.015) + (neto * 0.11);
            deducciones +=  7000.0;

            int totalTime=0;
            double anualidad = 0;
            if (doc.FechaIngreso.Month >= DateTime.Now.Month && doc.FechaIngreso.Day >= DateTime.Now.Day)
            {
                totalTime = DateTime.Now.Year - doc.FechaIngreso.Year;
            }
            else
            {
                totalTime = (DateTime.Now.Year - doc.FechaIngreso.Year) -1;
            }
            anualidad = Convert.ToDouble(cat.CostoAnualidad) * totalTime;

            return neto - deducciones + anualidad;
        }
    }
}
