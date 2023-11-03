using System;
using System.IO;
using MiniExcelLibs;
using HelpersUI.Interfaces;
using System.Collections.Generic;

namespace HelpersUI
{
    public class Excel : IExcel
    {
        public IEnumerable<T> Ler<T>(string arquivo) where T : class, new()
        {
            var stream = new FileStream(path: arquivo, mode: FileMode.Open);
            return stream.Query<T>();
        }

        public IEnumerable<T> Ler<T>(Stream arquivo)
        {
            throw new NotImplementedException();
        }
    }
}
