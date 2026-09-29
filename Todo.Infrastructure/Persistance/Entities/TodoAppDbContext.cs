using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.Infrastructure.Persistence.Entities;

namespace Todo.Infrastructure.Persistance.Entities
{
    public  class TodoAppDbContext : DbContext
    {
        //Create a constructor 
        public TodoAppDbContext(DbContextOptions<TodoAppDbContext> options) : base(options)
        {

        }
        //Create the User Tables
        public DbSet<User> Users { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TodoItemTag> TodoItemTags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}
