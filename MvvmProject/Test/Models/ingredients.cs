namespace Test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ingredients
    {
        public Ingredients(int v1, int v2, int v3)
        {
            this.id_i = v1;
            this.product_id = v2;
            this.amount_i = v3;
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_i { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int product_id { get; set; }

        public int? amount_i { get; set; }

        public virtual Dishes dishes { get; set; }

        public virtual Products products { get; set; }
    }
}
