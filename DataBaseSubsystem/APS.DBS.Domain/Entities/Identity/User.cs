using APS.DBS.Domain.Entities;
using APS.DBS.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace APS.Dbs.Domain.Entities.Identity
{
    /// <summary>
    /// Модель пользователя.
    /// </summary>
    public class User : IdentityUser
    {
        /// <summary>
        /// Личные данные.
        /// </summary>
        public Person Person { get; set; }

        /// <summary>
        ///Id роли пользователя 
        /// </summary>
        public Guid? RoleId { get; set; }

        /// <summary>
        /// Роль пользователя
        /// </summary>
        public Role Role { get; set; } 
    }
}
