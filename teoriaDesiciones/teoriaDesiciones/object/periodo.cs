using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teoriaDesiciones
{
    public class periodos
    {
        public int periodo { get; set; }


        utilidades utilidades=new utilidades();


        public List<periodos> getListaPeriodo()
        {
            string sql = "select periodo from periodo;";
            DataSet ds = utilidades.ejecutarcomando_mysql(sql);
            
            List<periodos> lista = new List<periodos>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                periodos periodo=new periodos();
                periodo.periodo = Convert.ToInt32(row[0]);
                lista.Add(periodo);
            }

            return lista;
        }

    }
}
