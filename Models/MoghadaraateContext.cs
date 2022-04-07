using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MoghadaraApi.Models
{
    public partial class MoghadaraateContext : DbContext
    {
        public MoghadaraateContext()
        {
        }

        public MoghadaraateContext(DbContextOptions<MoghadaraateContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Demande> Demandes { get; set; }
        public virtual DbSet<Etablissement> Etablissements { get; set; }
        public virtual DbSet<Fonctionnaire> Fonctionnaires { get; set; }
        public virtual DbSet<Pay> Pays { get; set; }
        public virtual DbSet<SourceEtab> SourceEtabs { get; set; }
        public virtual DbSet<SourceExcel> SourceExcels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Moghadaraate;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Demande>(entity =>
            {
                entity.HasKey(e => e.IdDemd)
                    .HasName("PK__Demandes__DFA1BCC4672C18E7");

                entity.Property(e => e.IdDemd).HasColumnName("idDemd");

                entity.Property(e => e.AdressPay)
                    .HasMaxLength(255)
                    .HasColumnName("adressPay");

                entity.Property(e => e.Cause)
                    .HasMaxLength(255)
                    .HasColumnName("cause");

                entity.Property(e => e.DateAutorisation)
                    .HasMaxLength(255)
                    .HasColumnName("dateAutorisation");

                entity.Property(e => e.DateDebut)
                    .HasMaxLength(255)
                    .HasColumnName("dateDebut");

                entity.Property(e => e.DateSaisie)
                    .HasMaxLength(255)
                    .HasColumnName("dateSaisie");

                entity.Property(e => e.DateValideTab)
                    .HasMaxLength(255)
                    .HasColumnName("dateValideTab");

                entity.Property(e => e.Dure)
                    .HasMaxLength(255)
                    .HasColumnName("dure");

                entity.Property(e => e.FlagSupp).HasColumnName("flagSupp");

                entity.Property(e => e.IdEtab).HasColumnName("idEtab");

                entity.Property(e => e.IdFonct).HasColumnName("idFonct");

                entity.Property(e => e.IdPay).HasColumnName("idPay");

                entity.Property(e => e.IdQuitterTerritoir)
                    .HasMaxLength(255)
                    .HasColumnName("idQuitterTerritoir");

                entity.Property(e => e.InfoSuppTab)
                    .HasMaxLength(255)
                    .HasColumnName("infoSuppTab");

                entity.Property(e => e.NumDemande)
                    .HasMaxLength(255)
                    .HasColumnName("numDemande");

                entity.Property(e => e.TelPay)
                    .HasMaxLength(255)
                    .HasColumnName("telPay");

                entity.Property(e => e.UserSaisie)
                    .HasMaxLength(255)
                    .HasColumnName("userSaisie");

                entity.Property(e => e.Valide)
                    .HasMaxLength(255)
                    .HasColumnName("valide");

                entity.HasOne(d => d.IdEtabNavigation)
                    .WithMany(p => p.Demandes)
                    .HasForeignKey(d => d.IdEtab)
                    .HasConstraintName("FK__Demandes__idEtab__534D60F1");

                entity.HasOne(d => d.IdFonctNavigation)
                    .WithMany(p => p.Demandes)
                    .HasForeignKey(d => d.IdFonct)
                    .HasConstraintName("FK__Demandes__idFonc__5165187F");

                entity.HasOne(d => d.IdPayNavigation)
                    .WithMany(p => p.Demandes)
                    .HasForeignKey(d => d.IdPay)
                    .HasConstraintName("FK__Demandes__idPay__52593CB8");
            });

            modelBuilder.Entity<Etablissement>(entity =>
            {
                entity.HasKey(e => e.IdEtab)
                    .HasName("PK__Etabliss__95AE9D4DA8EF79C0");

                entity.Property(e => e.IdEtab).HasColumnName("idEtab");

                entity.Property(e => e.EtabCodeRh)
                    .HasMaxLength(255)
                    .HasColumnName("ETAB_CODE_RH");

                entity.Property(e => e.EtabParentId)
                    .HasMaxLength(255)
                    .HasColumnName("ETAB_PARENT_ID");

                entity.Property(e => e.LibelleEtab)
                    .HasMaxLength(255)
                    .HasColumnName("libelleEtab");

                entity.Property(e => e.LibelleEtabFr)
                    .HasMaxLength(255)
                    .HasColumnName("libelleEtab_FR");
            });

            modelBuilder.Entity<Fonctionnaire>(entity =>
            {
                entity.HasKey(e => e.IdFonct)
                    .HasName("PK__Fonction__776DD92EFA92BA71");

                entity.Property(e => e.IdFonct).HasColumnName("idFonct");

                entity.Property(e => e.Cin)
                    .HasMaxLength(255)
                    .HasColumnName("CIN");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FlaFonctionnaire).HasColumnName("flaFonctionnaire");

                entity.Property(e => e.IdEtab).HasColumnName("idEtab");

                entity.Property(e => e.Matricule).HasColumnName("matricule");

                entity.Property(e => e.Nom)
                    .HasMaxLength(255)
                    .HasColumnName("nom");

                entity.Property(e => e.NumSomme).HasColumnName("numSomme");

                entity.Property(e => e.Prenom)
                    .HasMaxLength(255)
                    .HasColumnName("prenom");

                entity.Property(e => e.Tel)
                    .HasMaxLength(255)
                    .HasColumnName("tel");

                entity.HasOne(d => d.IdEtabNavigation)
                    .WithMany(p => p.Fonctionnaires)
                    .HasForeignKey(d => d.IdEtab)
                    .HasConstraintName("FK__Fonctionn__idEta__267ABA7A");
            });

            modelBuilder.Entity<Pay>(entity =>
            {
                entity.HasKey(e => e.IdPay)
                    .HasName("PK__Pays__3D783EEA91634958");

                entity.Property(e => e.IdPay).HasColumnName("idPay");

                entity.Property(e => e.NomPay)
                    .HasMaxLength(255)
                    .HasColumnName("nomPay");
            });

            modelBuilder.Entity<SourceEtab>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Source_Etab");

                entity.Property(e => e.EtabCodeRh)
                    .HasMaxLength(255)
                    .HasColumnName("ETAB_CODE_RH");

                entity.Property(e => e.EtabId).HasColumnName("ETAB_ID");

                entity.Property(e => e.EtabLibelle)
                    .HasMaxLength(255)
                    .HasColumnName("ETAB_LIBELLE");

                entity.Property(e => e.EtabLibelleFr)
                    .HasMaxLength(255)
                    .HasColumnName("ETAB_LIBELLE_FR");

                entity.Property(e => e.EtabParentId).HasColumnName("ETAB_PARENT_ID");
            });

            modelBuilder.Entity<SourceExcel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Source_Excel");

                entity.Property(e => e.AdressPays)
                    .HasMaxLength(255)
                    .HasColumnName("adress-pays");

                entity.Property(e => e.Cause)
                    .HasMaxLength(255)
                    .HasColumnName("cause");

                entity.Property(e => e.Cin)
                    .HasMaxLength(255)
                    .HasColumnName("CIN");

                entity.Property(e => e.CodeOrg)
                    .HasMaxLength(255)
                    .HasColumnName("code_org");

                entity.Property(e => e.DateAutorisation)
                    .HasMaxLength(255)
                    .HasColumnName("date-autorisation");

                entity.Property(e => e.DateDebut)
                    .HasMaxLength(255)
                    .HasColumnName("date-debut");

                entity.Property(e => e.DateSaisie)
                    .HasMaxLength(255)
                    .HasColumnName("date-saisie");

                entity.Property(e => e.Datvalidetab)
                    .HasMaxLength(255)
                    .HasColumnName("datvalidetab");

                entity.Property(e => e.Dure)
                    .HasMaxLength(255)
                    .HasColumnName("dure");

                entity.Property(e => e.Emails)
                    .HasMaxLength(255)
                    .HasColumnName("emails");

                entity.Property(e => e.FlagSupp).HasColumnName("flag-supp");

                entity.Property(e => e.IdQuitterTerritoire)
                    .HasMaxLength(255)
                    .HasColumnName("id-quitter-territoire");

                entity.Property(e => e.Infosuppetab)
                    .HasMaxLength(255)
                    .HasColumnName("infosuppetab");

                entity.Property(e => e.LibelleEtablissement)
                    .HasMaxLength(255)
                    .HasColumnName("Libelle-Etablissement");

                entity.Property(e => e.Matricule).HasColumnName("matricule");

                entity.Property(e => e.Nom).HasMaxLength(255);

                entity.Property(e => e.NumDemande)
                    .HasMaxLength(255)
                    .HasColumnName("num_demande");

                entity.Property(e => e.NumSomme).HasColumnName("num-somme");

                entity.Property(e => e.Pays)
                    .HasMaxLength(255)
                    .HasColumnName("pays");

                entity.Property(e => e.Prenom).HasMaxLength(255);

                entity.Property(e => e.Tel)
                    .HasMaxLength(255)
                    .HasColumnName("tel");

                entity.Property(e => e.TelPays)
                    .HasMaxLength(255)
                    .HasColumnName("tel-pays");

                entity.Property(e => e.UserSaisie)
                    .HasMaxLength(255)
                    .HasColumnName("user-saisie");

                entity.Property(e => e.Valide)
                    .HasMaxLength(255)
                    .HasColumnName("valide");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
