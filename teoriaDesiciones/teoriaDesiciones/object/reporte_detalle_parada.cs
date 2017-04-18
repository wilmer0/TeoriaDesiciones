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
        public decimal promedioHorasParada { get; set; }
        public decimal promedioMinutosParada { get; set; }
        public string nota { get; set; }
        public int idCausa { get; set; }
        public string causa { get; set; }
        public decimal cantidadProduccion { get; set; }
        public decimal tiempoTrabajoMaquina { get; set; }
        public decimal PorcientoTiempoFueraServicio { get; set; }
        public decimal tiempoFueraServicioMinutos { get; set; }
        public decimal tiempoFueraServicioHoras { get; set; }


    }
}
