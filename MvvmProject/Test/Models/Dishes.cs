namespace Test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dishes
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dishes()
        {
            ingredients = new HashSet<Ingredients>();
        }

        public Dishes(string v1, string v2)
        {
            this.name_d = v1;
            this.recipe = v2;
        }

        [Key]
        public int id_d { get; set; }

        [StringLength(40)]
        public string name_d { get; set; }

        public string recipe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ingredients> ingredients { get; set; }
    }
}
