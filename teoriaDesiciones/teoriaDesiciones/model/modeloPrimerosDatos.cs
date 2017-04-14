using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace teoriaDesiciones.model
{

    public class modeloPrimerosDatos
    {
        utilidades utilidades = new utilidades();



        public void entradaDatos()
        {
            //tipos maquinas
            string sql = "";
            sql = "truncate table maquina_tipo";
            utilidades.ejecutarcomando_mysql(sql);
            sql = "insert into maquina_tipo(id,tipo,cantidad) values('1','cutters','2');";
            utilidades.ejecutarcomando_mysql(sql);
            sql="insert into maquina_tipo(id,tipo,cantidad) values('2','molinos','1');";
            utilidades.ejecutarcomando_mysql(sql);
            sql="insert into maquina_tipo(id,tipo,cantidad) values('3','embutidoras','3');";
            utilidades.ejecutarcomando_mysql(sql);
            sql="insert into maquina_tipo(id,tipo,cantidad) values('4','clipeadoras','3');";
            utilidades.ejecutarcomando_mysql(sql);
            sql="insert into maquina_tipo(id,tipo,cantidad) values('5','tambores','3');";
            utilidades.ejecutarcomando_mysql(sql);
            sql="insert into maquina_tipo(id,tipo,cantidad) values('6','inyectadoras','1');";
            utilidades.ejecutarcomando_mysql(sql);
            sql="insert into maquina_tipo(id,tipo,cantidad) values('7','empacadoras','3');";
            utilidades.ejecutarcomando_mysql(sql);
            sql="insert into maquina_tipo(id,tipo,cantidad) values('8','termoformadoras','1');";
            utilidades.ejecutarcomando_mysql(sql);

            //causas
            sql = "truncate table causa";
            utilidades.ejecutarcomando_mysql(sql);
            sql = "insert into causa(id,causa,probabilidad) values('1','falla energia electrica','10');";
            utilidades.ejecutarcomando_mysql(sql);
            sql = "insert into causa(id,causa,probabilidad) values('2','falta de materia prima','25');";
            utilidades.ejecutarcomando_mysql(sql);
            sql = "insert into causa(id,causa,probabilidad) values('3','operadores no disponibles','30');";
            utilidades.ejecutarcomando_mysql(sql);
            sql = "insert into causa(id,causa,probabilidad) values('4','falla pieza de maquina','20');";
            utilidades.ejecutarcomando_mysql(sql);
            sql = "insert into causa(id,causa,probabilidad) values('5','incapacitacion de empleado accidente maquina','15');";
            utilidades.ejecutarcomando_mysql(sql);
            

            //meses
            sql = "truncate table mes";
            utilidades.ejecutarcomando_mysql(sql);
            for (int f = 1; f <= 12; f++)
            {
                sql = "insert into mes(mes) values('"+f+"');";
                utilidades.ejecutarcomando_mysql(sql);
            }

            //periodo
            sql = "truncate table periodo";
            utilidades.ejecutarcomando_mysql(sql);
            for (int f = 2015; f <= 2020; f++)
            {
                sql = "insert into periodo(periodo) values('"+f+"');";
                utilidades.ejecutarcomando_mysql(sql);
            }

            //problemas
            sql = "truncate table problema";
            utilidades.ejecutarcomando_mysql(sql);
            sql = "insert into problema(id,problema) values('1','maquina se detiene');";
            utilidades.ejecutarcomando_mysql(sql);

            //problema vs causa
            sql = "truncate table problema_vs_causa";
            utilidades.ejecutarcomando_mysql(sql);
            sql = "select id,causa,probabilidad from causa;";
            DataSet ds = utilidades.ejecutarcomando_mysql(sql);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (utilidades.getNumeroRandom(1, 100) <= Convert.ToInt32(row[2]))
                {
                    //se inserta la causa del problema
                    sql = "insert into problema_vs_causa(id_problema,id_causa) values('1','"+row[0].ToString()+"');";
                    utilidades.ejecutarcomando_mysql(sql);
                }
            }
        }
    }
}
