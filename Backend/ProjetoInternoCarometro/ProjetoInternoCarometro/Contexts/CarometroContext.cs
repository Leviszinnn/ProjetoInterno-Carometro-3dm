using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProjetoInternoCarometro.Domains;

#nullable disable

namespace ProjetoInternoCarometro.Contexts
{
    public partial class CarometroContext : DbContext
    {
        public CarometroContext()
        {
        }

        public CarometroContext(DbContextOptions<CarometroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aluno> Alunos { get; set; }
        public virtual DbSet<Escola> Escolas { get; set; }
        public virtual DbSet<GrauEscolar> GrauEscolars { get; set; }
        public virtual DbSet<Professor> Professors { get; set; }
        public virtual DbSet<Serie> Series { get; set; }
        public virtual DbSet<Turma> Turmas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
<<<<<<< HEAD
                optionsBuilder.UseSqlServer("Data Source=NOTE0113E4\\SQLEXPRESS; initial catalog=DM_CAROMETRO; user Id=sa; pwd=Senai@132;");
=======
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-9K54HD5\\SQLEXPRESS; initial catalog=DM_CAROMETRO; user Id=sa; pwd=senai@132;");
>>>>>>> 4af303513d2fb7b2d40482239ed1d23adb38c454

            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.HasKey(e => e.IdAluno)
                    .HasName("PK__aluno__0C5BC84955E7D479");

                entity.ToTable("aluno");

                entity.HasIndex(e => e.IdFace, "UQ__aluno__7165D8B0F995140E")
                    .IsUnique();

                entity.HasIndex(e => e.Cpf, "UQ__aluno__D836E71F2FA6B9CC")
                    .IsUnique();

                entity.Property(e => e.IdAluno).HasColumnName("idAluno");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("cpf");

                entity.Property(e => e.DataNascimento)
                    .HasColumnType("datetime")
                    .HasColumnName("dataNascimento");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.IdEscola).HasColumnName("idEscola");

                entity.Property(e => e.IdFace)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idFace");

                entity.Property(e => e.IdSerie).HasColumnName("idSerie");

                entity.Property(e => e.IdTurma).HasColumnName("idTurma");

                entity.Property(e => e.NomeAluno)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomeAluno");

                entity.Property(e => e.Rm)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("rm");

                entity.HasOne(d => d.IdEscolaNavigation)
                    .WithMany(p => p.Alunos)
                    .HasForeignKey(d => d.IdEscola)
                    .HasConstraintName("FK__aluno__idEscola__46E78A0C");

                entity.HasOne(d => d.IdSerieNavigation)
                    .WithMany(p => p.Alunos)
                    .HasForeignKey(d => d.IdSerie)
                    .HasConstraintName("FK__aluno__idSerie__47DBAE45");

                entity.HasOne(d => d.IdTurmaNavigation)
                    .WithMany(p => p.Alunos)
                    .HasForeignKey(d => d.IdTurma)
                    .HasConstraintName("FK__aluno__idTurma__48CFD27E");
            });

            modelBuilder.Entity<Escola>(entity =>
            {
                entity.HasKey(e => e.IdEscola)
                    .HasName("PK__escola__034B40EDCD237A8E");

                entity.ToTable("escola");

                entity.HasIndex(e => e.Endereco, "UQ__escola__9456D406D2C5B329")
                    .IsUnique();

                entity.HasIndex(e => e.Numero, "UQ__escola__FC77F2117A5F0D99")
                    .IsUnique();

                entity.Property(e => e.IdEscola).HasColumnName("idEscola");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

                entity.Property(e => e.NomeEscola)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomeEscola");

                entity.Property(e => e.Numero).HasColumnName("numero");
            });

            modelBuilder.Entity<GrauEscolar>(entity =>
            {
                entity.HasKey(e => e.IdGrau)
                    .HasName("PK__grauEsco__A75912D6F7078297");

                entity.ToTable("grauEscolar");

                entity.Property(e => e.IdGrau).HasColumnName("idGrau");

                entity.Property(e => e.NomeGrau)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomeGrau");
            });

            modelBuilder.Entity<Professor>(entity =>
            {
                entity.HasKey(e => e.IdProfessor)
                    .HasName("PK__professo__4E7C3C6D5B4D6224");

                entity.ToTable("professor");

                entity.HasIndex(e => e.Email, "UQ__professo__AB6E6164E97EB9DB")
                    .IsUnique();

                entity.Property(e => e.IdProfessor).HasColumnName("idProfessor");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdEscola).HasColumnName("idEscola");

                entity.Property(e => e.NomeProfessor)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nomeProfessor");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.HasOne(d => d.IdEscolaNavigation)
                    .WithMany(p => p.Professors)
                    .HasForeignKey(d => d.IdEscola)
                    .HasConstraintName("FK__professor__idEsc__4222D4EF");
            });

            modelBuilder.Entity<Serie>(entity =>
            {
                entity.HasKey(e => e.IdSerie)
                    .HasName("PK__serie__9E10C73D85EA9F23");

                entity.ToTable("serie");

                entity.Property(e => e.IdSerie).HasColumnName("idSerie");

                entity.Property(e => e.IdGrau).HasColumnName("idGrau");

                entity.Property(e => e.NumeroSerie)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("numeroSerie");

                entity.HasOne(d => d.IdGrauNavigation)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.IdGrau)
                    .HasConstraintName("FK__serie__idGrau__3E52440B");
            });

            modelBuilder.Entity<Turma>(entity =>
            {
                entity.HasKey(e => e.IdTurma)
                    .HasName("PK__turma__AA068310C4E0728C");

                entity.ToTable("turma");

                entity.Property(e => e.IdTurma).HasColumnName("idTurma");

                entity.Property(e => e.LetraTurma)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("letraTurma");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
