namespace TeachMe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Fatura")]
    public partial class Fatura
    {
        public int ID { get; set; }

        public int Cliente_ID { get; set; }

        public int Aula_ID { get; set; }

        public virtual Aula Aula { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
