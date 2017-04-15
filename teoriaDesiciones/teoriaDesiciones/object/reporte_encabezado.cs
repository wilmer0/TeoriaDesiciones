using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teoriaDesiciones
{
    public class reporte_encabezado
    {
        public int periodoInicial { get; set; }
        public int periodoFinal { get; set; }
        public string fechaReporte { get; set; }
        public decimal produccionPromedioMensual { get; set; }
        public int cantidadParadas { get; set; }
        public int cantidadMaquinasParadas { get; set; }
        
    }
}
