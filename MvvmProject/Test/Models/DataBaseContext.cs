namespace Test.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public class DataBaseInitializer : DropCreateDatabaseAlways<DataBaseContext>
    {
        protected override void Seed(DataBaseContext context)
        {
            var products = new List<Products>
            {
                new Products("Potato", 2, 100),
                new Products("Carrot", 1, 100),
                new Products("Bow", 1, 100),
                new Products("Chicken", 100, 3),
                new Products("Pasta", 4, 20),
                new Products("Tomato", 1, 100),
                new Products("Cabbage", 2, 30),
                new Products("Eggplant", 3, 20),
            };

            products.ForEach(x => context.products.Add(x));
            context.SaveChanges();

            var dishes = new List<Dishes>
            {
                new Dishes("Chicken soup", "Cook the chicken, season with salt. Add the potatoes, diced. After 7 minutes, add the pasta, stir. Add the onions, sliced rings. After 5 minutes, remove from heat."),
                new Dishes("Cabbage salad", "Chop cabbage. Skip through the grater carrots. Add onion, chopped very finely. Oil and salt to taste."),
                new Dishes("Fried potatoes", "Cut the potatoes into cubes. Season with salt to taste. Fry in a pan."),
                new Dishes("Steamed vegetables", "Slice the cabbage, eggplant, carrot, onion coarsely. Hold for a couple of 15 minutes.Salt - to taste."),
            };

            dishes.ForEach(x => context.dishes.Add(x));
            context.SaveChanges();


            var ingredients = new List<Ingredients>
            {
                new Ingredients(1, 4, 1),
                new Ingredients(1, 1, 5),
                new Ingredients(1, 5, 1),
                new Ingredients(1, 3, 2),
                new Ingredients(2, 7, 1),
                new Ingredients(2, 2, 1),
                new Ingredients(2, 3, 1),
                new Ingredients(3, 1, 5),
                new Ingredients(4, 2, 8),
                new Ingredients(4, 8, 3),
                new Ingredients(4, 7, 1),
                new Ingredients(4, 3, 1),
            };

            ingredients.ForEach(x => context.ingredients.Add(x));

            context.SaveChanges();
        }
    }

    public partial class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("name=DataBaseContext")
        {
            Database.SetInitializer(new DataBaseInitializer());
        }

        public virtual DbSet<Dishes> dishes { get; set; }
        public virtual DbSet<Ingredients> ingredients { get; set; }
        public virtual DbSet<Products> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dishes>()
                .Property(e => e.name_d)
                .IsUnicode(false);

            modelBuilder.Entity<Dishes>()
                .Property(e => e.recipe)
                .IsUnicode(false);

            modelBuilder.Entity<Dishes>()
                .HasMany(e => e.ingredients)
                .WithRequired(e => e.dishes)
                .HasForeignKey(e => e.id_i);

            modelBuilder.Entity<Products>()
                .Property(e => e.name_p)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.ingredients)
                .WithRequired(e => e.products)
                .HasForeignKey(e => e.product_id);
        }
    }
}
