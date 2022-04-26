using HelpersUI.WPF.MDLS;
using HelpersUI.WPF.VMS;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HelpersUI.WPF.FRMS
{
    /// <summary>
    /// Lógica interna para FrmFiltro.xaml
    /// </summary>
    public partial class FrmFiltro : Window
    {
        public string ItensSelecionado { get; set; }

        private FrmFiltroViewModel vm;

        public FrmFiltro()
        {
            InitializeComponent();
            vm = new FrmFiltroViewModel();
            DataContext = vm;
        }

      
        public FrmFiltro(ObservableCollection<ListaFiltro> Source)
        {
            InitializeComponent();
            vm = new FrmFiltroViewModel(Source);
            DataContext = vm;
        }

        private void OnClosed(object sender, EventArgs e)
        {
            ItensSelecionado = vm.ItensSelecionados;
        }
    }
}
