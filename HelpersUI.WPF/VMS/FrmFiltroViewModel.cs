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

        public Command SelecionarTodosCommand { get; set; }
        #endregion

        public FrmFiltroViewModel(ObservableCollection<ListaFiltro> Source)
        {
            ListBoxItemSource = Source;
            TotalItens = ListBoxItemSource.Count();
            FecharCommand = new Command((win) => Fechar(win));
            SelecionarTodosCommand = new Command(SelecionarTodos);
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

        private int _TotalItens;

        public int TotalItens 
        {
            get { return _TotalItens; }
            set { SetProperty(ref _TotalItens, value); }
        }
        #endregion

        /// <summary>
        /// Método que fecha a janela de filtro
        /// </summary>
        /// <param name="win"></param>
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

        /// <summary>
        /// Método que seleciona todas as opções dentro do 
        /// ListBox
        /// </summary>
        private void SelecionarTodos()
        {
            ObservableCollection<ListaFiltro> TodosSelecionados = new ObservableCollection<ListaFiltro>();

            bool IsTodosSelecionados = ListBoxItemSource.All(x => x.Selecionado == true);

            foreach (var item in ListBoxItemSource)
            {
                TodosSelecionados.Add(new ListaFiltro
                {
                    Selecionado = !IsTodosSelecionados ?  true : false,
                    Nome = item.Nome
                });
            }

            ListBoxItemSource = TodosSelecionados;
        }

    }

}
