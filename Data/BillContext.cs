using Microsoft.EntityFrameworkCore;
using RazorPagesBill.Models;

namespace RazorPagesBill.Data;

public class BillContext : DbContext
{
    public BillContext (DbContextOptions<BillContext> options): base(options)
    {

    }

    public DbSet<Bill> Bills=> Set<Bill>();
}
