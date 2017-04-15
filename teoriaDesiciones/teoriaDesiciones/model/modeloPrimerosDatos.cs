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
            ////tipos maquinas
            string sql = "";
            //sql = "truncate table maquina_tipo";
            //utilidades.ejecutarcomando_mysql(sql);
            //sql = "insert into maquina_tipo(id,tipo,cantidad) values('1','cutters','2');";
            //utilidades.ejecutarcomando_mysql(sql);
            //sql="insert into maquina_tipo(id,tipo,cantidad) values('2','molinos','1');";
            //utilidades.ejecutarcomando_mysql(sql);
            //sql="insert into maquina_tipo(id,tipo,cantidad) values('3','embutidoras','3');";
            //utilidades.ejecutarcomando_mysql(sql);
            //sql="insert into maquina_tipo(id,tipo,cantidad) values('4','clipeadoras','3');";
            //utilidades.ejecutarcomando_mysql(sql);
            //sql="insert into maquina_tipo(id,tipo,cantidad) values('5','tambores','3');";
            //utilidades.ejecutarcomando_mysql(sql);
            //sql="insert into maquina_tipo(id,tipo,cantidad) values('6','inyectadoras','1');";
            //utilidades.ejecutarcomando_mysql(sql);
            //sql="insert into maquina_tipo(id,tipo,cantidad) values('7','empacadoras','3');";
            //utilidades.ejecutarcomando_mysql(sql);
            //sql="insert into maquina_tipo(id,tipo,cantidad) values('8','termoformadoras','1');";
            //utilidades.ejecutarcomando_mysql(sql);

            ////causas
            //sql = "truncate table causa";
            //utilidades.ejecutarcomando_mysql(sql);
            //sql = "insert into causa(id,causa,probabilidad) values('1','falla energia electrica','10');";
            //utilidades.ejecutarcomando_mysql(sql);
            //sql = "insert into causa(id,causa,probabilidad) values('2','falta de materia prima','25');";
            //utilidades.ejecutarcomando_mysql(sql);
            //sql = "insert into causa(id,causa,probabilidad) values('3','operadores no disponibles','30');";
            //utilidades.ejecutarcomando_mysql(sql);
            //sql = "insert into causa(id,causa,probabilidad) values('4','falla pieza de maquina','20');";
            //utilidades.ejecutarcomando_mysql(sql);
            //sql = "insert into causa(id,causa,probabilidad) values('5','incapacitacion de empleado accidente maquina','15');";
            //utilidades.ejecutarcomando_mysql(sql);
            

            ////meses
            //sql = "truncate table mes";
            //utilidades.ejecutarcomando_mysql(sql);
            //for (int f = 1; f <= 12; f++)
            //{
            //    sql = "insert into mes(mes) values('"+f+"');";
            //    utilidades.ejecutarcomando_mysql(sql);
            //}

            ////periodo
            //sql = "truncate table periodo";
            //utilidades.ejecutarcomando_mysql(sql);
            //for (int f = 2015; f <= 2020; f++)
            //{
            //    sql = "insert into periodo(periodo) values('"+f+"');";
            //    utilidades.ejecutarcomando_mysql(sql);
            //}

            ////problemas
            //sql = "truncate table problema";
            //utilidades.ejecutarcomando_mysql(sql);
            //sql = "insert into problema(id,problema) values('1','maquina se detiene');";
            //utilidades.ejecutarcomando_mysql(sql);

            //problema vs causa
            //sql = "truncate table problema_vs_causa";
            //utilidades.ejecutarcomando_mysql(sql);
            //sql = "select id,causa,probabilidad from causa;";
            //DataSet ds = utilidades.ejecutarcomando_mysql(sql);
            //int contadorProblemas = 0;
            //do
            //{
            //    foreach (DataRow row in ds.Tables[0].Rows)
            //    {
            //        if (utilidades.getNumeroRandom(1,100) <= Convert.ToInt32(row[2]))
            //        {
            //            //se inserta la causa del problema
            //            sql = "insert into problema_vs_causa(id_problema,id_causa) values('1','" + row[0].ToString() +"');";
            //            utilidades.ejecutarcomando_mysql(sql);
            //            contadorProblemas++;
            //        }
            //    }
            //} while (contadorProblemas < utilidades.getNumeroRandom(1,100));


            
            //insertando las paradas
            #region

            //sql = "truncate table parada;";
            //utilidades.ejecutarcomando_mysql(sql);
            ////recorriendo los periodos
            //for(int s=0;s<50;s++)
            //for (int p = 2015; p <= 2016; p++)
            //{
            //    for (int m = 1; m <= 12; m++)
            //    {
            //        //recorriendo los meses
            //        sql = "select id,causa,probabilidad from causa;";
            //        DataSet dsCausa = utilidades.ejecutarcomando_mysql(sql);
            //        //recorriendo cada tipo de maquina
            //        sql = "select id,tipo,cantidad from maquina_tipo;";
            //        DataSet dsMaquina = utilidades.ejecutarcomando_mysql(sql);
            //        foreach (DataRow rowMaquina in dsMaquina.Tables[0].Rows)
            //        {
            //            //recorriendo la cantidad de este tipo de maquinas
            //            for (int c = 0; c < Convert.ToInt32(rowMaquina[2]);c++)
            //            {
            //                //analizando si ocurrio un problema en la maquina actual
            //                foreach (DataRow row in dsCausa.Tables[0].Rows)
            //                {
            //                    if (utilidades.getNumeroRandom(1, 100) <= Convert.ToInt32(row[2]))
            //                    {
            //                        double tiempoHoras = 0;
            //                        double tiempoMinutos = 0;
            //                        tiempoMinutos = utilidades.getNumeroRandom(5, 60);
            //                        tiempoHoras = Math.Round((tiempoMinutos / 60), 2);
            //                        sql = "insert into parada(id_problema,tiempo_horas,tiempo_minutos,id_maquina,id_periodo,mes) values('1','" + tiempoHoras + "','" + tiempoMinutos + "','"+rowMaquina[0].ToString()+"','" + p + "','" + m + "');";
            //                        utilidades.ejecutarcomando_mysql(sql);
            //                    }
            //                }
            //            }
            //        }
                    
            //    }
            //}
            #endregion



        }
    }
}
