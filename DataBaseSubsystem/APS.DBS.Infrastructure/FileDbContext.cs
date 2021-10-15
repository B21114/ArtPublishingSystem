using APS.DBS.Domain;
using APS.DBS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.DBS.Infrastructure
{
    /// <summary>
    /// Контекст базы данных файлов.
    /// </summary>
    public class FileDbContext : DbContext, IFileDbContext
    {
        /// <inheritdoc>
        public DbSet<File> Files { get; set; }

        public FileDbContext(DbContextOptions<FileDbContext> options) : base(options)
        {

        }

    }
}

