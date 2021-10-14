using APS.DBS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.DBS.Domain
{
    /// <summary>
    /// Интерфейс контекста базы данных контента.
    /// </summary>
    public interface IContentDbContext
    {

        /// <summary>
        /// Содержимое таблицы контент.
        /// </summary>
        public DbSet<Content> Contents { get; set; }
    }
}
