using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
    }
}
