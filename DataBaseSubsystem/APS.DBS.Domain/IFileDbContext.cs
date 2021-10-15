using APS.DBS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        /// <summary>
        /// Асинхронно сохраняет все изменения, внесенные в этом контексте, в основную базу данных.
        /// </summary>
        /// <param name="cancellationToken">Объект для наблюдения за ожиданием завершения задачи.</param>
        /// <returns></returns>
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
