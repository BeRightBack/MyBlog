using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using MyBlog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data
{
    public class MyBlogDbContext : ApiAuthorizationDbContext<AppUser>
    {
        public MyBlogDbContext(DbContextOptions options) : base(options, new OperationalStoreOptionsMigrations())
        { }        
        
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }

    public class MyBlogDbContextFactory : IDesignTimeDbContextFactory<MyBlogDbContext>
    {
        public MyBlogDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyBlogDbContext>();
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb; database=MyBlog_db; integrated security=true");

            return new MyBlogDbContext(optionsBuilder.Options);
        }
    }

    //<OperationalStoreOptionsMigrations>
    public class OperationalStoreOptionsMigrations : IOptions<OperationalStoreOptions>
    {
        public OperationalStoreOptions Value => new OperationalStoreOptions()
        {
            DeviceFlowCodes = new TableConfiguration("DeviceCodes"),
            EnableTokenCleanup = false,
            PersistedGrants = new TableConfiguration("PersistedGrants"),
            TokenCleanupBatchSize = 100,
            TokenCleanupInterval = 3600,
        };
    }
    //</OperationalStoreOptionsMigrations>
}
