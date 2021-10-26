using APS.DBS.Domain.Entities;
using APS.DBS.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APS.Dbs.Domain.Entities.Identity
{
    /// <summary>
    /// Модель пользователя.
    /// </summary>
    public class User : IdentityUser<Guid>
    {
        /// <summary>
        /// Личные данные.
        /// </summary>
        [ForeignKey("PersonId")]
        public Person Person { get; set; }
    }
}
