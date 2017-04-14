using System;
using System.Collections.Generic;
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
            string sql = "insert into maquina_tipo(id,tipo,cantidad) values('1','cutters','2');";
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
            sql = "insert into causa(id,causa) values('1','maquina fuera de servicio');";
            utilidades.ejecutarcomando_mysql(sql);
            sql = "insert into causa(id,causa) values('2','falla energia electrica');";
            utilidades.ejecutarcomando_mysql(sql);
            sql = "insert into causa(id,causa) values('3','falta de materia prima');";
            utilidades.ejecutarcomando_mysql(sql);
            sql = "insert into causa(id,causa) values('4','operadores no disponibles');";
            utilidades.ejecutarcomando_mysql(sql);
            sql = "insert into causa(id,causa) values('5','falla pieza de maquina');";
            utilidades.ejecutarcomando_mysql(sql);
            sql = "insert into causa(id,causa) values('6','incapacitacion de empleado accidente maquina');";
            utilidades.ejecutarcomando_mysql(sql);
            

        }
    }
}
