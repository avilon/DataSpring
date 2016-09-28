using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader.Model
{
    /// <summary>
    /// Разбивает один большой CSV на несколько файлов меньшего размера.
    /// </summary>
    public class CsvSplitter : IWorkUnit
    {
        /// <summary>
        /// Количество строк в отдельном файле
        /// </summary>
        public int PartSize { get; set; }

        /// <summary>
        /// Реализация интерфейса
        /// </summary>
        public void Perform()
        {

        }
    }
}
