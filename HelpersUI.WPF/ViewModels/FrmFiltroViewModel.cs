using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HelpersUI.WPF.ViewModels
{
    public class FrmFiltroViewModel : VMBase
    {
        public FrmFiltroViewModel()
        {
            ListBoxItemSource = new ObservableCollection<ListBoxItemSource>();
            ListBoxItemSource.Add(new ViewModels.ListBoxItemSource
            {
                Nome = "Corinthians",
                IsChecked = false
            });
            ListBoxItemSource.Add(new ViewModels.ListBoxItemSource
            {
                Nome = "São Paulo",
                IsChecked = false
            });
            ListBoxItemSource.Add(new ViewModels.ListBoxItemSource
            {
                Nome = "Palmeiras",
                IsChecked = false
            });
        }

        private ObservableCollection<ListBoxItemSource> _ListBoxItemSource;

        public ObservableCollection<ListBoxItemSource> ListBoxItemSource
        {
            get { return _ListBoxItemSource; }
            set { SetProperty(ref _ListBoxItemSource, value); }
        }

    }

    public class ListBoxItemSource
    {
        public string Nome { get; set; }

        public bool IsChecked { get; set; } = false;

    }
}
