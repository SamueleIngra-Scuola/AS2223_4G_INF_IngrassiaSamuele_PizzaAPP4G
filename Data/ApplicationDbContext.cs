using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AS2223_4G_INF_IngrassiaSamuele_PizzaAPP4G.Models;

namespace AS2223_4G_INF_IngrassiaSamuele_PizzaAPP4G.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AS2223_4G_INF_IngrassiaSamuele_PizzaAPP4G.Models.Pizza>? Pizza { get; set; }
        public DbSet<AS2223_4G_INF_IngrassiaSamuele_PizzaAPP4G.Models.Client>? Client { get; set; }
    }
}