using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlackjackAttack.Models;

namespace BlackjackAttack.DataLayer
{
    public class BlackjackAttackContext : DbContext
    {
        public BlackjackAttackContext(DbContextOptions<BlackjackAttackContext> options)
            : base(options)
        {
        }

        public DbSet<Table> Tables { get; set; }
        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<Card> Cards { get; set; }

    }
}