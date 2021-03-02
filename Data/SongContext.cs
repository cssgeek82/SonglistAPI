using Microsoft.EntityFrameworkCore;
using SonglistAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonglistAPI.Data
{
    public class SongContext : DbContext
    {
        public SongContext(DbContextOptions<SongContext> options) : base(options)
        {

        }

        public DbSet<SongModel> Songs { get; set; }
    }
}
