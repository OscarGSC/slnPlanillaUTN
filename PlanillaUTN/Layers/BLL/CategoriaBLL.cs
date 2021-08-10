using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanillaUTN.Layers.BLL
{
    class CategoriaBLL
    {
        public static List<Entities.Categoria> ObtenerTodos()
        {
            return DAL.CategoriaDAL.SeleccionarCategoriasSP();
        }
        public static List<string> ObtenerDescrip()
        {
            return DAL.CategoriaDAL.SeleccionarCategoriasdescripSP();
        }
        public static Entities.Categoria ObtenerCatPorID(string id)
        {
            return DAL.CategoriaDAL.SeleccionarCategoriaIDSP(id);
        }
    }
}
