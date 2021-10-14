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
    /// Контекст базы данных контента.
    /// </summary>
    public class ContentDbContext : DbContext, IContentDbContext
    {
        /// <inheritdoc>
        public DbSet<Content> Contents { get; set; }

        public ContentDbContext(DbContextOptions<ContentDbContext> options) : base(options)
        {

        }
    }
}
