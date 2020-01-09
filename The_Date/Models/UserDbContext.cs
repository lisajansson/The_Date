using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace The_Date.Models
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Friend> Friend { get; set; }
        public DbSet<ProfileImage> ProfileImage { get; set; }


        public UserDbContext() : base("TheDateDatabase") { }
    }
}