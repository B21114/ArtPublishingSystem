using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Queries.GetPublicationList
{
    /// <summary>
    /// DTO для сущности списка контента.
    /// </summary>
    public class PublicationListItemDto
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
        /// ФИО автора Dto.
        /// </summary>
        public string AuthorFullName { get; set; }

        /// <summary>
        /// Дата загрузки файла.
        /// </summary>
        public DateTime UploadDateTime { get; set; }

        /// <summary>
        /// Признак публичной доступности файла.
        /// </summary>
        public bool IsPublic { get; set; }
    }
}
