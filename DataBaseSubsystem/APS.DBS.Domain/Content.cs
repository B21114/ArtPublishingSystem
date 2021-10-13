using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.DBS.Domain
{
    /// <summary>
    /// Сущность контент
    /// </summary>
    class Content
    {
        //Добавить сущность "Контент": Идентификатор, Автор (Личность), Дата загрузки, Признак публичной доступности.
        /// <summary>
        /// Идентификатор контента
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Aвтор
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Дата загрузки файла
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Признак публичной доступности файла
        /// </summary>
        public bool PublicPrivate { get; set; }

    }
}
