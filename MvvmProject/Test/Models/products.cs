namespace Test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            ingredients = new HashSet<Ingredients>();
        }

        public Products(string v1, int v2, int v3)
        {
            this.name_p = v1;
            this.price = v2;
            this.amount_p = v3;
        }

        [Key]
        public int id_p { get; set; }

        [StringLength(30)]
        public string name_p { get; set; }

        public int? price { get; set; }

        public int? amount_p { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ingredients> ingredients { get; set; }
    }
}
