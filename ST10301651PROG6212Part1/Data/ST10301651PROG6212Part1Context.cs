using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ST10301651PROG6212Part1.Models;

namespace ST10301651PROG6212Part1.Data
{
    public class ST10301651PROG6212Part1Context : DbContext
    {
        public ST10301651PROG6212Part1Context (DbContextOptions<ST10301651PROG6212Part1Context> options)
            : base(options)
        {
        }

        public DbSet<ST10301651PROG6212Part1.Models.Claim> Claim { get; set; } = default!;
    }
}
