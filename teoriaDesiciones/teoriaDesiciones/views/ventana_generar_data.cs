using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teoriaDesiciones.model;

namespace teoriaDesiciones.views
{
    public partial class ventana_generar_data : Form
    {
        //objetos
        utilidades utilidades=new utilidades();
        private periodos periodo;


        //listas
        private List<periodos> listaPeriodos; 


        //modelos
        modeloPrimerosDatos modeloPrimerosDatos=new modeloPrimerosDatos();
        modeloReporte modeloReporte=new modeloReporte();

        //variables
        private int periodoInicial = 0;
        private int periodoFinal = 0;
        private bool reporteGeneral = false;



        public ventana_generar_data()
        {
            InitializeComponent();
            loadVentana();
        }

        public void loadVentana()
        {
            modeloPrimerosDatos.entradaDatos();
            getPeriodo();
        }

        //get anios periodo
        public void getPeriodo()
        {
            try
            {
                //periodo=new periodos();
                //listaPeriodos=new List<periodos>();
                //listaPeriodos = periodo.getListaPeriodo();
                
                ////periodo inicial
                //periodoInicialCombo.DataSource = listaPeriodos;
                //periodoInicialCombo.DisplayMember = "periodo";
                //periodoInicialCombo.ValueMember = "periodo";
                periodoInicialCombo.SelectedIndex = 0;

                ////periodo final
                //periodoFinalCombo.DataSource = listaPeriodos;
                //periodoFinalCombo.DisplayMember = "periodo";
                //periodoFinalCombo.ValueMember = "periodo";
                periodoFinalCombo.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getPeriodo.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generarData();
        }

        public void generarData()
        {
            try
            {
                //insertando las paradas
                #region

                periodoInicial = Convert.ToInt32(periodoInicialCombo.Text);
                periodoFinal = Convert.ToInt32(periodoFinalCombo.Text);


                string sql = "truncate table parada;";
                utilidades.ejecutarcomando_mysql(sql);
                //recorriendo los periodos
                for (int s = 0; s < 50; s++)
                {
                    for (int p = periodoInicial; p <= periodoFinal; p++)
                    {
                        for (int m = 1; m <= 12; m++)
                        {
                            //recorriendo los meses
                            sql = "select id,causa,probabilidad from causa;";
                            DataSet dsCausa = utilidades.ejecutarcomando_mysql(sql);
                            //recorriendo cada tipo de maquina
                            sql = "select id,tipo,cantidad from maquina_tipo;";
                            DataSet dsMaquina = utilidades.ejecutarcomando_mysql(sql);
                            foreach (DataRow rowMaquina in dsMaquina.Tables[0].Rows)
                            {
                                //recorriendo la cantidad de este tipo de maquinas
                                for (int c = 0; c < Convert.ToInt32(rowMaquina[2]); c++)
                                {
                                    //analizando si ocurrio un problema en la maquina actual
                                    foreach (DataRow row in dsCausa.Tables[0].Rows)
                                    {
                                        if (utilidades.getNumeroRandom(1, 100) <= Convert.ToInt32(row[2]))
                                        {
                                            double tiempoHoras = 0;
                                            double tiempoMinutos = 0;
                                            tiempoMinutos = utilidades.getNumeroRandom(5, 60);
                                            tiempoHoras = Math.Round((tiempoMinutos/60), 2);
                                            sql ="insert into parada(id_problema,tiempo_horas,tiempo_minutos,id_maquina,id_periodo,mes) values('1','" +tiempoHoras + "','" + tiempoMinutos + "','" + rowMaquina[0].ToString() + "','" + p + "','" + m + "');";
                                            utilidades.ejecutarcomando_mysql(sql);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generando la data.: " + ex.ToString(), "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void periodoFinalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ventana_generar_data_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            periodoInicial = Convert.ToInt32(periodoInicialCombo.Text);
            periodoFinal = Convert.ToInt32(periodoFinalCombo.Text);
            if (radioButtonGeneral.Checked == true)
            {
                reporteGeneral = true;
            }

            modeloReporte.GetReporte(periodoInicial,periodoFinal,reporteGeneral);
        }
    }
}
