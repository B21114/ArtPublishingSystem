using APS.DBS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Queries.GetPublicationById
{
    /// <summary>
    /// DTO для сущности контент
    /// </summary>
    public class PublicationDetailsDto
    {
        /// <summary>
        /// Идентификатор контента.
        /// </summary>
        public Guid Id { get; set; }

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
