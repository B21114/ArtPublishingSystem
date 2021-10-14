using System.ComponentModel.DataAnnotations;

namespace APS.Web.MVC.Models
{
    /// <summary>
    /// Модель авторизации.
    /// </summary>
    public class LoginModel
    {
        /// <summary>
        /// Почта пользоавтеля.
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
        /// Свойство для запоминания состояния пользователя.
        /// </summary>
        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }

        /// <summary>
        /// Свойство для возвращения URL.
        /// </summary>
        public string ReturnUrl { get; set; }
    }
}
