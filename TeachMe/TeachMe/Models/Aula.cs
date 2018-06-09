namespace TeachMe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aula")]
    public partial class Aula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aula()
        {
            Fatura = new HashSet<Fatura>();
            Material = new HashSet<Material>();
        }

        public int ID { get; set; }

        public int Custo { get; set; }

        public int Horario_ID { get; set; }

        public int Professor_ID { get; set; }

        public int Opiniao_ID { get; set; }

        public int Disciplina_ID { get; set; }

        public int Cliente_ID { get; set; }

        public virtual Horario Horario { get; set; }

        public virtual Professor Professor { get; set; }

        public virtual Opiniao Opiniao { get; set; }

        public virtual Disciplina Disciplina { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fatura> Fatura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material> Material { get; set; }
    }
}
