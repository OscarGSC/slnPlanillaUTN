using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanillaUTN.Layers.BLL
{
    class NombramientoBLL
    {
        public void Guardar(Entities.Nombramiento nom)
        {
            try
            {
                DAL.NombramientoDALL.InsertarSP(nom);
            }
            catch (Exception)
            {
                //Log4NET para guardar en bitacora el error

                throw new ApplicationException("Ocurrió un error al guardar. Póngase en contacto con ..."); ;
            }
        }
        public static void Eliminar(int IdDocente, int IdJornada)
        {
            try
            {
                DAL.NombramientoDALL.EliminarNombramientoSP(IdDocente, IdJornada);
            }
            catch (Exception)
            {
                //Log4NET para guardar en bitacora el error

                throw new ApplicationException("Ocurrió un error al eliminar. Póngase en contacto con ..."); ;
            }
        }
        public List<string> ObtenerDescrip(int id)
        {
            if (DAL.JornadaDAL.SeleccionarJornadasPorIdDoc(id).Count == 0)
            {
                throw new ApplicationException("El docente no posee jornadas laborales");
            }

            return DAL.JornadaDAL.SeleccionarJornadasPorIdDoc(id);
        }
        public static Entities.Nombramiento SeleccionarPorID(int IdDocente)
        {
            try
            {
                return DAL.NombramientoDALL.SeleccionarNombramientoIDSP(IdDocente);
            }
            catch (Exception)
            {
                //Log4NET para guardar en bitacora el error

                throw new ApplicationException("Ocurrió un error al eliminar. Póngase en contacto con ..."); ;
            }
        }
    }
}
