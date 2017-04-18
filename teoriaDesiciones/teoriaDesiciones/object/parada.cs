using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teoriaDesiciones
{
    public class parada
    {
        public int id { get; set; }
        public int idCausa { get; set; }
        public string causa { get; set; }
        public decimal tiempoHoras { get; set; }
        public decimal tiempoMinutos { get; set; }
        public int idTipoMaquina { get; set; }
        public string maquina { get; set; }
        public int Periodo { get; set; }
        public int mes { get; set; }
        public decimal tiempoTrabajado { get; set; }
        public decimal tiempoFueraServicio { get; set; }
        public decimal PorcientoTiempoFueraServicioMinutos { get; set; }
        public decimal PorcientoTiempoFueraServicioHoras { get; set; }

        utilidades utilidades=new utilidades();

        public List<parada> getListaParada()
        {
            List<parada> lista = new List<parada>();
            parada parada = new parada();

            string sql = "select p.id,p.id_causa,p.tiempo_horas,p.tiempo_minutos,p.id_maquina,p.id_periodo,p.mes,mt.tipo,c.causa,p.tiempo_trabajado from parada p, maquina_tipo mt,causa c where p.id_maquina=mt.id  and c.id=p.id_causa order by p.id_periodo;";
            DataSet ds = utilidades.ejecutarcomando_mysql(sql);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                parada = new parada();
                parada.id = Convert.ToInt32(row[0]);
                parada.idCausa = Convert.ToInt32(row[1]);
                parada.tiempoHoras = Convert.ToDecimal(row[2]);
                parada.tiempoMinutos = Convert.ToDecimal(row[3]);
                parada.idTipoMaquina= Convert.ToInt32(row[4]);
                parada.Periodo = Convert.ToInt32(row[5]);
                parada.mes = Convert.ToInt32(row[6]);
                parada.maquina= row[7].ToString();
                parada.causa = row[8].ToString();
                parada.tiempoTrabajado = Convert.ToDecimal(row[9]);
                parada.tiempoFueraServicio = parada.tiempoMinutos ;
                //parada.PorcientoTiempoFueraServicioMinutos = Math.Round((parada.tiempoFueraServicio / tiempoFueraServicioMinutosTotal)*100,2);
                parada.PorcientoTiempoFueraServicioHoras = Math.Round((parada.PorcientoTiempoFueraServicioMinutos/60),2);
                
                lista.Add(parada);
            }

            decimal tiempoFueraServicioMinutosTotal = Math.Round(lista.Sum(s => s.tiempoFueraServicio), 2);
            foreach (var x in lista)
            {
                x.PorcientoTiempoFueraServicioMinutos = Math.Round((parada.tiempoFueraServicio / tiempoFueraServicioMinutosTotal) * 100, 2);
            }

            return lista;
        }

    }
}
