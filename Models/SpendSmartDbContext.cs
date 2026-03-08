using System;
using Microsoft.EntityFrameworkCore;

namespace SpendApp.Models;

public class SpendSmartDbContext : DbContext
{
    public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options)
        : base(options)
    {
        
    }
    public DbSet<Expense> Expenses { get; set; }
}
