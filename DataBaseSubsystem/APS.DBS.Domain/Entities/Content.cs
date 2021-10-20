using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.DBS.Domain.Entities
{
    /// <summary>
    /// Сущность контент.
    /// </summary>
    public class Content
    {
        /// <summary>
        /// Идентификатор контента.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Наименование контента.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Aвтор.
        /// </summary>
        public Person Author { get; set; }

        /// <summary>
        /// Дата загрузки файла.
        /// </summary>
        public DateTime UploadDateTime { get; set; }

        /// <summary>
        /// Признак публичной доступности файла.
        /// </summary>
        public bool IsPublic { get; set; }

        /// <summary>
        /// Файл.
        /// </summary>
        public File File { get; set; }
    }
}
