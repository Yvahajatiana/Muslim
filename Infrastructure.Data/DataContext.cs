using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Muslim.Core.Domain.Thumbnails;
using Muslim.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Muslim.Infrastructure.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {

        }

        DbSet<Thumbnail> Thumbnails { get; set; }
    }
}
