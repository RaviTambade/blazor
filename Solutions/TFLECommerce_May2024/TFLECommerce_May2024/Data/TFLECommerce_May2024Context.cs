using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TFLECommerce_May2024.Models;

namespace TFLECommerce_May2024.Data
{
    public class TFLECommerce_May2024Context : DbContext
    {
        public TFLECommerce_May2024Context (DbContextOptions<TFLECommerce_May2024Context> options)
            : base(options)
        {
        }

        public DbSet<TFLECommerce_May2024.Models.Customer> Customer { get; set; } = default!;
    }
}
