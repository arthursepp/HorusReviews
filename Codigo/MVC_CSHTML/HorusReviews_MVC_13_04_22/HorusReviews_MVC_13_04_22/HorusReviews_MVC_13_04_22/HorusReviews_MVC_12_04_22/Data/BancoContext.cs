using HorusReviews_MVC_12_04_22.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorusReviews_MVC_12_04_22.Data
{
    public class BancoContext : DbContext
    {

       public BancoContext(DbContextOptions<BancoContext>options) : base(options)
        {
        }

        public DbSet<DataModel> Usuario { get; set; }

    }
}
