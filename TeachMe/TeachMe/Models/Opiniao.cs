namespace TeachMe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Opiniao")]
    public partial class Opiniao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Opiniao()
        {
            Aula = new HashSet<Aula>();
        }

        public int ID { get; set; }

        public int Avaliacao { get; set; }

        [Required]
        [StringLength(200)]
        public string Texto { get; set; }

        public int Professor_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aula> Aula { get; set; }

        public virtual Professor Professor { get; set; }
    }
}
