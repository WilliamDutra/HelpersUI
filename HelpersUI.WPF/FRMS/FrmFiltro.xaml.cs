using HelpersUI.WPF.ViewModels;
using System;
using System.Collections.Generic;
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
        public FrmFiltro()
        {
            InitializeComponent();
            DataContext = new FrmFiltroViewModel();
        }
    }
}
