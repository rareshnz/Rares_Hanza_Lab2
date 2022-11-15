using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rares_Hanza_Lab2.Models;

namespace Rares_Hanza_Lab2.Data
{
    public class Rares_Hanza_Lab2Context : DbContext
    {
        public Rares_Hanza_Lab2Context (DbContextOptions<Rares_Hanza_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Rares_Hanza_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Rares_Hanza_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Rares_Hanza_Lab2.Models.Author> Author { get; set; }

        public DbSet<Rares_Hanza_Lab2.Models.Category> Category { get; set; }

        public DbSet<Rares_Hanza_Lab2.Models.Member> Member { get; set; }

        public DbSet<Rares_Hanza_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
