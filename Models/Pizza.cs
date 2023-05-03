using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace AS2223_4G_INF_IngrassiaSamuele_PizzaAPP4G.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double ? Price { get; set; }
        public string Size { get; set; }
        public int ? Quantity { get; set; }

    }
}
