using APS.DBS.Domain.Entities;
using Microsoft.AspNetCore.Identity;
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
    }
}
