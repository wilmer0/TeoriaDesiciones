using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teoriaDesiciones
{
    class causa
    {
        public int id { get; set; }
        public string causaS { get; set; }


        utilidades utilidades=new utilidades();

        public string getNombreCaudaById(int id)
        {
            string sql = "select causa from causa where id ='"+id+"'";
            DataSet ds = utilidades.ejecutarcomando_mysql(sql);

            return ds.Tables[0].Rows[0][0].ToString();
        }
    }
}
