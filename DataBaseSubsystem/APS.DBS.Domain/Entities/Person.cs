using APS.Dbs.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.DBS.Domain.Entities
{
    /// <summary>
    /// Сущность "Личность".
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Идентификатор пользователя.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Отчество пользователя.
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Фамилия пользователя.
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// Дата рождения пользователя.
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        public DateTime ВirthDate { get; set; }

        /// <summary>
        /// Данные о пользователе
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Список контента пользователя
        /// </summary>
        public List<Content> ContentList {get;set;}
    }
}
