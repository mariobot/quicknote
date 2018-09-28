using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace quicknote.Models
{
    public class quicknoteDatabase : DbContext
    {
        public quicknoteDatabase() : base("name=ConnString") { }

        public DbSet<Note> Notes{ get; set; }
    }
}