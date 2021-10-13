using System;
using System.Collections.Generic;
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
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество пользователя.
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Фамилия пользователя.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Дата рождения пользователя.
        /// </summary>
        public DateTime ByrthDate { get; set; }
    }
}
