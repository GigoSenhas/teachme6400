namespace TeachMe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Material")]
    public partial class Material
    {
        public int ID { get; set; }

        [Required]
        [StringLength(45)]
        public string Nome { get; set; }

        [Required]
        [StringLength(45)]
        public string URL { get; set; }

        public int Aula_ID { get; set; }

        public virtual Aula Aula { get; set; }
    }
}
