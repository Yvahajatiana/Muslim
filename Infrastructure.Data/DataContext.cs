using Microsoft.EntityFrameworkCore;
using Muslim.Core.Domain.Thumbnails;
using System;
using System.Collections.Generic;
using System.Text;

namespace Muslim.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {

        }

        DbSet<Thumbnail> Thumbnails { get; set; }
    }
}
