using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpersUI.WPF.VMS
{
    public class VMBase : BaseViewModel
    {
        #region [ Propriedades ]
        private string _Titulo;

        public string Titulo 
        { 
            get { return _Titulo; }
            set { SetProperty(ref _Titulo, value); }
        }
        #endregion
    }
}
