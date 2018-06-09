namespace TeachMe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pedido_Aula
    {
        public int ID { get; set; }

        public int Cliente_ID { get; set; }

        public int Disciplina_ID { get; set; }

        [Required]
        [StringLength(45)]
        public string Nome_Educando { get; set; }

        public int Resultados { get; set; }

        [Required]
        [StringLength(100)]
        public string Observacao { get; set; }

        public int? Horario_ID { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Disciplina Disciplina { get; set; }

        public virtual Horario Horario { get; set; }
    }
}
