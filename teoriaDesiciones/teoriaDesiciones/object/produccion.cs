using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teoriaDesiciones
{
    public class produccion
    {
        public int id { get; set; }
        public int periodo { get; set; }
        public int mes { get; set; }
        public string mesNombre { get; set; }
        public decimal cantidad { get; set; }
        public string nota { get; set; }

        utilidades utilidades=new utilidades();
        public List<produccion> getListaProduccion()
        {
            List<produccion> lista=new List<produccion>();
            produccion produccion=new produccion();

            string sql = "select id,periodo,mes,cantidad,nota from produccion;";
            DataSet ds = utilidades.ejecutarcomando_mysql(sql);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                produccion=new produccion();
                produccion.id = Convert.ToInt32(row[0]);
                produccion.periodo = Convert.ToInt32(row[1]);
                produccion.mes = Convert.ToInt32(row[2]);
                produccion.cantidad = Convert.ToDecimal(row[3]);
                produccion.nota = row[4].ToString();
                lista.Add(produccion);
            }



            return lista;
        }

    }
}
