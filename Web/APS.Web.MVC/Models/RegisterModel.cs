
using APS.DBS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APS.Web.MVC.Models
{
    /// <summary>
    /// Модель регистрации.
    /// </summary>
    public class RegisterModel
    {
        /// <summary>
        /// Почта пользователя.
        /// </summary>
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// Пароль пользователя.
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        /// <summary>
        /// Свойство подтверждния пароля.
        /// </summary>
        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string ConfirmedPassword { get; set; }

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
        /// 
        [Required]
        [DataType(DataType.Date)]
        public DateTime ВirthDate { get; set; }

    }
}
