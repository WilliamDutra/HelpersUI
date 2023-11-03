using System;
using System.IO;
using System.Collections.Generic;

namespace HelpersUI.Interfaces
{
    public interface IExcel
    {
        IEnumerable<T> Ler<T>(string arquivo) where T : class, new();

        IEnumerable<T> Ler<T>(Stream arquivo);

    }
}
