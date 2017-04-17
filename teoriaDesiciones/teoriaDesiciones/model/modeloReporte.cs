using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using teoriaDesiciones.report;

namespace teoriaDesiciones.model
{
    public class modeloReporte
    {
        public void GetReporte(int periodoInicial,int periodoFinal,bool reporteGeneral)
        {
            try
            {
                reporte_encabezado reporteteEncabezado=new reporte_encabezado();
                List<reporte_encabezado> listaEncabezado=new List<reporte_encabezado>();
                List<parada> listaParada=new List<parada>();
                parada parada=new parada();
                List<produccion> listaProduccion = new List<produccion>();
                produccion produccion = new produccion();
                reporte_detalle_parada reporteDetalle=new reporte_detalle_parada();
                List<reporte_detalle_parada> listaDetalle=new List<reporte_detalle_parada>();
                causa causa=new causa();

                //obteniendo la lista de produccion
                listaProduccion = produccion.getListaProduccion();
                listaProduccion = listaProduccion.FindAll(x => x.periodo == periodoInicial || x.periodo == periodoFinal);

                //lista de parada
                listaParada = parada.getListaParada();
                listaParada = listaParada.FindAll(x => x.Periodo == periodoInicial || x.Periodo == periodoFinal);

                //encabezado
                reporteteEncabezado.fechaReporte = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
                reporteteEncabezado.periodoInicial = periodoInicial;
                reporteteEncabezado.periodoFinal = periodoFinal;
                reporteteEncabezado.cantidadParadas = listaParada.Where(x=> x.id > 0 ).Count();
                reporteteEncabezado.cantidadMaquinasParadas = listaParada.Distinct().Count();
                reporteteEncabezado.produccionPromedioMensual = Math.Round((listaProduccion.Average(x => x.cantidad)),4);
                reporteteEncabezado.cantidadMaquinasParadas = (from p in listaParada
                             where !(from ex in listaParada select ex.idTipoMaquina).Contains(p.idTipoMaquina)
                             select p).ToList().Count;
                listaEncabezado.Add(reporteteEncabezado);
                
                //lista meses
                List<string> listaMes=new List<string>();
                listaMes.Add("ninguno");
                listaMes.Add("enero");
                listaMes.Add("febrero");
                listaMes.Add("marzo");
                listaMes.Add("abril");
                listaMes.Add("mayo");
                listaMes.Add("junio");
                listaMes.Add("julio");
                listaMes.Add("agosto");
                listaMes.Add("septiembre");
                listaMes.Add("octubre");
                listaMes.Add("noviembre");
                listaMes.Add("diciembre");

                //detalle
                foreach (var x in listaProduccion)
                {
                    reporteDetalle=new reporte_detalle_parada();
                    reporteDetalle.periodo = x.periodo;
                    reporteDetalle.mes = x.mes;
                    reporteDetalle.mesNombre = listaMes[x.mes];
                    reporteDetalle.variacionProduccion = Math.Round((x.cantidad/reporteteEncabezado.produccionPromedioMensual),4);
                    reporteDetalle.paradas = listaParada.Where(p => p.Periodo == x.periodo && p.mes == x.mes).Count();
                    reporteDetalle.promedioHoras = Math.Round((listaParada.Where(p => p.Periodo == x.periodo && p.mes == x.mes).Average(v => v.tiempoHoras)),4);
                    reporteDetalle.promedioMinutos = Math.Round(listaParada.Where(p => p.Periodo == x.periodo && p.mes == x.mes).Average(v => v.tiempoMinutos), 4);
                    reporteDetalle.nota = listaProduccion.Where(p => p.periodo == x.periodo && p.mes == x.mes).FirstOrDefault().nota;
                    reporteDetalle.idCausa = listaParada.Where(p => p.Periodo == x.periodo && p.mes == x.mes).FirstOrDefault().idCausa;
                    reporteDetalle.causa = causa.getNombreCaudaById(reporteDetalle.idCausa);
                    reporteDetalle.cantidadProduccion = x.cantidad;
                    listaDetalle.Add(reporteDetalle);
                }






                //llamando el reporte
                String reporte = "";
                if (reporteGeneral == true)
                {
                    reporte = "teoriaDesiciones.report.Report1.rdlc";
                }
                else
                {
                    reporte = "teoriaDesiciones.report.Report2.rdlc";
                    listaParada = listaParada.OrderBy(x => x.id).ToList();
                }
                List<ReportDataSource> listaReportDataSource = new List<ReportDataSource>();

                //encabezado
                ReportDataSource reporteEncabezado = new ReportDataSource("reporte_encabezado", listaEncabezado);
                listaReportDataSource.Add(reporteEncabezado);

                //llenar detalle
                ReportDataSource reporteDetalle1 = new ReportDataSource("reporte_detalle", listaDetalle);
                listaReportDataSource.Add(reporteDetalle1);

                //llenar detalle parada
                ReportDataSource reporteDetalle2 = new ReportDataSource("reporte_detalle_parada", listaParada);
                listaReportDataSource.Add(reporteDetalle2);

                List<ReportParameter> ListaReportParameter = new List<ReportParameter>();
                VisorReporteComun ventana = new VisorReporteComun(reporte, listaReportDataSource, ListaReportParameter);
                ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getListaProduccion.: " + ex.ToString(), "", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
