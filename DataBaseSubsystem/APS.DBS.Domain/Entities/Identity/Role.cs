using APS.Dbs.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.DBS.Domain.Entities.Identity
{
    /// <summary>
    /// Ролевая модель
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Id роли
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название роли пользователя
        /// </summary>
        public string NameRole { get; set; }

        /// <summary>
        /// Список пользователей
        /// </summary>
        public List<User> Users { get; set; }

        /// <summary>
        /// Конструктор ролей
        /// </summary>
        public Role()
        {
            Users = new List<User>();
        }
    }
}
