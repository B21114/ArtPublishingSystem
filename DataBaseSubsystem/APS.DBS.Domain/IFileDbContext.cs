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
    /// Интерфейс контекста базы данных файлов.
    /// </summary>
    public interface IFileDbContext
    {
        /// <summary>
        /// Содержимое таблицы файлов.
        /// </summary>
        public DbSet<File> Files { get; set; }
    }
}
