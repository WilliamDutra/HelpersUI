using HelpersUI.WPF.MDLS;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace HelpersUI.WPF.VMS
{
    public class FrmFiltroViewModel : VMBase
    {
        #region [ Eventos ]
        public Command FecharCommand { get; set; }
        #endregion

        public FrmFiltroViewModel(ObservableCollection<ListaFiltro> Source)
        {
            ListBoxItemSource = Source;
            FecharCommand = new Command((win) => Fechar(win));
        }

        public FrmFiltroViewModel()
        {
            FecharCommand = new Command((win) => Fechar(win));
        }

        #region [ Propriedades ]
        private ObservableCollection<ListaFiltro> _ListBoxItemSource;

        public ObservableCollection<ListaFiltro> ListBoxItemSource
        {
            get { return _ListBoxItemSource; }
            set { SetProperty(ref _ListBoxItemSource, value); }
        }

        private string _ItensSelecionados;

        public string ItensSelecionados 
        { 
            get { return _ItensSelecionados; }
            set { SetProperty(ref _ItensSelecionados, value); }
        }

        #endregion


        private void Fechar(object win)
        {
            var selecionados = ListBoxItemSource.Where(x => x.Selecionado);
            ItensSelecionados = string.Empty;

            foreach (var item in selecionados)
            {
                ItensSelecionados += $"{item.Nome},";
            }

            ItensSelecionados = ItensSelecionados.Remove(ItensSelecionados.LastIndexOf(","), 1);

            Window window = win as Window;
            window.Close();
            
        }

    }

    public class ListBoxItemSource
    {
        public string Nome { get; set; }

        public bool IsChecked { get; set; } = false;

    }
}
