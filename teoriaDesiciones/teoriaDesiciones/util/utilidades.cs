using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace teoriaDesiciones
{
    public class utilidades
    {
        public DataSet ejecutarcomando_mysql(string query)
        {
            try
            {
                if (query == "")
                {
                    return null;
                }
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=wilmerlomas1;database=teoria_desicions;");
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo conectando al server.:" + ex.ToString());
                return null;
            }
        }

        public Int32 getNumeroRandom(Int32 inicio, Int32 final)
        {
            try
            {
                //geera un numero random entre un rango de numero inicial y numero final
                Random random = new Random();
                //Thread.Sleep(5);
                return random.Next(inicio, final + 1);
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
