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
            double total = 0;
            double regla1 = 0;
            double CCSS = 0.09;
            double BancoPopular = 0.015;
            double Pension = 0.11;
            double Seguro = 7000;

            double porcentaSalarioTotal = 0;
            foreach (Jornada item in jor)
            {
                porcentaSalarioTotal = porcentaSalarioTotal + item.PorcentajeSalario;
            }
            regla1 = Convert.ToDouble(Convert.ToDouble(cat.SalarioBase) * (porcentaSalarioTotal/100));
            double regla2 = CCSS + BancoPopular + Pension;
            total = Convert.ToDouble(regla1 - (regla1 * regla2) - Seguro);

            if (total > 799000 && total < 1199000)
            {
                total = total - ((total-799000) * 0.1);
            }
            if (total > 1199000)
            {
                total = total - ((total - 1199000) *0.15);
            }

            int annos = DateTime.Now.Year - doc.FechaIngreso.Year;

            total = total + (annos * Convert.ToDouble(cat.CostoAnualidad));

            return total;
        }
    }
}
