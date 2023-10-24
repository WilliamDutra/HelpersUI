using HelpersUI.WPF.FRMS;
using HelpersUI.WPF.MDLS;
using HelpersUI.WPF.VMS;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelpersUI.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var lista = new ObservableCollection<ListaFiltro>();
            lista.Add(new ListaFiltro
            {
                Selecionado = true,
                Nome = "Corinthians"
            });

            lista.Add(new ListaFiltro
            {
                Selecionado = false,
                Nome = "Palmeiras"
            });

            lista.Add(new ListaFiltro
            {
                Selecionado = false,
                Nome = "São Paulo"
            });

            var frm = new FrmFiltro(lista);
            frm.ShowDialog();
            var a = frm.ItensSelecionado;

            MessageBox.Show($"Itens selecionado: {a}");

        }
    }
}
