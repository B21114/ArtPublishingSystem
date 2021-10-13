using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.DBS.Domain
{
    /// <summary>
    /// Сущность файл
    /// </summary>
    class File
    {
        /// <summary>
        /// Идентификатор файла
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя файла
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Расширение файла
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Размер файла
        /// </summary>
        public double Size { get; set; }

        /// <summary>
        /// Содержимое файла
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Тип содержимого файла
        /// </summary>
        public string Type { get; set; }
    }
}
