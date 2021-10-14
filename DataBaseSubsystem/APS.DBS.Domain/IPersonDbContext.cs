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
    /// Интерфейс контекста базы данных личности.
    /// </summary>
    public interface IPersonDbContext
    {
        /// <summary>
        /// Содержимое таблицы личности.
        /// </summary>
        public DbSet<Person> People { get; set; }
    }
}
