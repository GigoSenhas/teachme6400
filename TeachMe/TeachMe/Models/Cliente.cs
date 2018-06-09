namespace TeachMe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            Aula = new HashSet<Aula>();
            Fatura = new HashSet<Fatura>();
            Pedido_Aula = new HashSet<Pedido_Aula>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(45)]
        public string Nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data_Nascimento { get; set; }

        [Required]
        [StringLength(45)]
        public string Email { get; set; }

        public int Numero_Telemovel { get; set; }

        public int NIF { get; set; }

        [Required]
        [StringLength(45)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(45)]
        public string Distrito { get; set; }

        [Required]
        [StringLength(45)]
        public string Freguesia { get; set; }

        public int Porta { get; set; }

        [Required]
        [StringLength(45)]
        public string Coordenadas_GPS { get; set; }

        [Required]
        [StringLength(45)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aula> Aula { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fatura> Fatura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_Aula> Pedido_Aula { get; set; }
    }
}
