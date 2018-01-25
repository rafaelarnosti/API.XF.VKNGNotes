using API.XF.VKNGNotes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API.XF.VKNGNotes.Context
{
    public class DBContext : DbContext
    {
         public DBContext()
            :base("name=Context")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().ToTable("Note");
            modelBuilder.Entity<User>().ToTable("usuario");
        }
    }
}