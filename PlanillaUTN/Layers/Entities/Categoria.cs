using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanillaUTN.Layers.Entities
{
    class Categoria
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal CostoAnualidad { get; set; }
    }
}
