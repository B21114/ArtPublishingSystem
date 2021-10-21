using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string FileName { get; set; }

        /// <summary>
        /// Расширение файла.
        /// </summary>
        public string FileExtension { get; set; }

        /// <summary>
        /// Размер файла.
        /// </summary>
        public long FileSize { get; set; }

        /// <summary>
        /// Содержимое файла.
        /// </summary>
        public byte[] FileContent { get; set; }

        /// <summary>
        /// Тип содержимого файла.
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// Данные контента
        /// </summary>
        [ForeignKey("ContentId")]
        public Content Content { get; set; }
    }
}
