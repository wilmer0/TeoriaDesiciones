using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using teoriaDesiciones;

namespace teoriaDesicionesWeb
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private readonly Form1 appForm=new Form1();
        public Page1()
        {
            InitializeComponent();
            WindowsFormsHost windowsFormsHost=new WindowsFormsHost();
            stackPanel.MaxWidth = appForm.Width+500;
            stackPanel.MaxHeight = appForm.Height+500;

            windowsFormsHost.Width = appForm.Width;
            windowsFormsHost.Height = appForm.Height;

            appForm.TopLevel = false;
            windowsFormsHost.Child = appForm;
            stackPanel.Children.Add(windowsFormsHost);



        }
    }
}
