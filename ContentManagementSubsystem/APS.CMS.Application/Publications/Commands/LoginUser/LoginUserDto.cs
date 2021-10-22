using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Queries.LoginUser
{
    class LoginUserDto
    {
        /// <summary>
        /// Логин для входа в систему.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль для входа в систему.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Признак запоминающий пользователя.
        /// </summary>
        public bool RememberMe { get; set; }
    }
}
