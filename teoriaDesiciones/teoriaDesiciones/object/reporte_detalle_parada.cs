using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teoriaDesiciones
{
    public class reporte_detalle_parada
    {
        public int periodo { get; set; }
        public int mes { get; set; }
        public string mesNombre { get; set; }
        public decimal variacionProduccion { get; set; }
        public int paradas { get; set; }
        public decimal promedioHoras { get; set; }
        public decimal promedioMinutos { get; set; }
        public string nota { get; set; }
        public string causa { get; set; }
        public decimal cantidadProduccion { get; set; }
    }
}
