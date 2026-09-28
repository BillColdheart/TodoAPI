using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
