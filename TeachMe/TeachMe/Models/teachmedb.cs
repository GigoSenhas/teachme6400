namespace TeachMe.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TeachMeDb : DbContext
    {
        public TeachMeDb()
            : base("name=TeachMeDb")
        {
        }

        public virtual DbSet<Aula> Aula { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Disciplina> Disciplina { get; set; }
        public virtual DbSet<Fatura> Fatura { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Opiniao> Opiniao { get; set; }
        public virtual DbSet<Pedido_Aula> Pedido_Aula { get; set; }
        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aula>()
                .HasMany(e => e.Fatura)
                .WithRequired(e => e.Aula)
                .HasForeignKey(e => e.Aula_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Aula>()
                .HasMany(e => e.Material)
                .WithRequired(e => e.Aula)
                .HasForeignKey(e => e.Aula_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Distrito)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Freguesia)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Coordenadas_GPS)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Aula)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.Cliente_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Fatura)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.Cliente_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Pedido_Aula)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.Cliente_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Disciplina>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Disciplina>()
                .HasMany(e => e.Aula)
                .WithRequired(e => e.Disciplina)
                .HasForeignKey(e => e.Disciplina_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Disciplina>()
                .HasMany(e => e.Pedido_Aula)
                .WithRequired(e => e.Disciplina)
                .HasForeignKey(e => e.Disciplina_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Disciplina>()
                .HasMany(e => e.Professor)
                .WithMany(e => e.Disciplina)
                .Map(m => m.ToTable("Disciplina_has_Professor"));

            modelBuilder.Entity<Horario>()
                .HasMany(e => e.Aula)
                .WithRequired(e => e.Horario)
                .HasForeignKey(e => e.Horario_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Horario>()
                .HasMany(e => e.Pedido_Aula)
                .WithOptional(e => e.Horario)
                .HasForeignKey(e => e.Horario_ID);

            modelBuilder.Entity<Material>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Material>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<Opiniao>()
                .Property(e => e.Texto)
                .IsUnicode(false);

            modelBuilder.Entity<Opiniao>()
                .HasMany(e => e.Aula)
                .WithRequired(e => e.Opiniao)
                .HasForeignKey(e => e.Opiniao_ID);

            modelBuilder.Entity<Pedido_Aula>()
                .Property(e => e.Nome_Educando)
                .IsUnicode(false);

            modelBuilder.Entity<Pedido_Aula>()
                .Property(e => e.Observacao)
                .IsUnicode(false);

            modelBuilder.Entity<Professor>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Professor>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Professor>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Professor>()
                .HasMany(e => e.Aula)
                .WithRequired(e => e.Professor)
                .HasForeignKey(e => e.Professor_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Professor>()
                .HasMany(e => e.Opiniao)
                .WithRequired(e => e.Professor)
                .HasForeignKey(e => e.Professor_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Professor>()
                .HasMany(e => e.Horario)
                .WithMany(e => e.Professor)
                .Map(m => m.ToTable("Professor_has_Horario"));
        }
    }
}
