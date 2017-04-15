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
        public decimal tiempoHoras { get; set; }
        public decimal tiempoMinutos { get; set; }
        public int idTipoMaquina { get; set; }
        public int Periodo { get; set; }
        public int mes { get; set; }


        utilidades utilidades=new utilidades();
        public List<parada> getListaParada()
        {
            List<parada> lista = new List<parada>();
            parada parada = new parada();

            string sql = "select id,id_causa,tiempo_horas,tiempo_minutos,id_maquina,id_periodo,mes from parada;";
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

                lista.Add(parada);
            }



            return lista;
        }

    }
}
