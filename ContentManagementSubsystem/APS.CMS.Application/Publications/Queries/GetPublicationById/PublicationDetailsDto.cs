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
        /// Идентификатор контента Dto.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// ФИО автора Dto.
        /// </summary>
        public string AuthorFullName { get; set; }

        /// <summary>
        /// Дата загрузки файла Dto.
        /// </summary>
        public DateTime UpLoadDatetime { get; set; }

        /// <summary>
        /// Признак публичной доступности файла Dto.
        /// </summary>
        public bool Ispublic { get; set; }
    }
}
