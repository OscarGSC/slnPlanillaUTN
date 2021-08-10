using PlanillaUTN.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanillaUTN.Layers.BLL
{
    class JornadaBLL
    {
        public List<string> ObtenerTodos()
        {
            return DAL.JornadaDAL.SeleccionarTodosDesc();
        }
        public List<string> ObtenerDescrip(int id)
        {
            return DAL.JornadaDAL.SeleccionarJornadasPorIdDoc(id);
        }
        public List<Jornada> ObtenerJornadas()
        {
            return DAL.JornadaDAL.SeleccionarTodosSP();
        }
        public static List<Jornada> JornadaID(int idDocente)
        {
            try
            {
                return DAL.JornadaDAL.SeleccionarJornadaPorId(idDocente);
            }
            catch (Exception)
            {
                //Log4NET para guardar en bitacora el error

                throw new ApplicationException("Ocurrió un error al eliminar. Póngase en contacto con ... No existe en la BD"); ;
            }
        }
    }
}
