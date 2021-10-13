using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.DBS.Domain.Entities
{
    /// <summary>
    /// Сущность файл.
    /// </summary>
    public class File
    {
        /// <summary>
        /// Идентификатор файла.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя файла.
        /// </summary>
        public string Filename { get; set; }

        /// <summary>
        /// Расширение файла.
        /// </summary>
        public string Fileextension { get; set; }

        /// <summary>
        /// Размер файла.
        /// </summary>
        public long Filesize { get; set; }

        /// <summary>
        /// Содержимое файла.
        /// </summary>
        public byte[] Filecontent { get; set; }

        /// <summary>
        /// Тип содержимого файла.
        /// </summary>
        public string Filetype { get; set; }
    }
}
