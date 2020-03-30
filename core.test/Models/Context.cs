using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.test.Models
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {}

        public virtual DbSet<SysUser> SysUser { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<SysUser>().ToTable("SysUser");
        }
    }
}
