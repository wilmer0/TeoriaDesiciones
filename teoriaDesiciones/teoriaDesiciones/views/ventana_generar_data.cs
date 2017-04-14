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


        public ventana_generar_data()
        {
            InitializeComponent();
            loadVentana();
        }

        public void loadVentana()
        {
            getPeriodo();
        }

        //get anios periodo
        public void getPeriodo()
        {
            try
            {
                periodo=new periodos();
                listaPeriodos=new List<periodos>();
                listaPeriodos = periodo.getListaPeriodo();
                
                //periodo inicial
                periodoInicialCombo.DataSource = listaPeriodos;
                periodoInicialCombo.DisplayMember = "periodo";
                periodoInicialCombo.ValueMember = "periodo";
                periodoInicialCombo.SelectedIndex = 0;

                //periodo final
                periodoFinalCombo.DataSource = listaPeriodos;
                periodoFinalCombo.DisplayMember = "periodo";
                periodoFinalCombo.ValueMember = "periodo";
                periodoFinalCombo.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getPeriodo.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
