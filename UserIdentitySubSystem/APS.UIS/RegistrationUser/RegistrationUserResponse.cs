using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace APS.UIS.RegistrationUser
{
    /// <summary>
    /// Ответ.
    /// </summary>
    public class RegistrationUserResponse
    {
        /// <summary>
        /// Хранит ID нового пользователя.
        /// </summary>
        public Guid IdUser { get; set; }

        /// <summary>
        /// Хранит ссылка на страницу.
        /// </summary>
        public string Url { get; set; }
    }
}
