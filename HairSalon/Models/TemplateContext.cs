using Microsoft.EntityFrameworkCore;

namespace Template.Models
{
  public class TemplateContext : DbContext
  {
    public DbSet<Placeholder> Items { get; set; }

    public TemplateContext(DbContextOptions options) : base(options) { }
  }
}