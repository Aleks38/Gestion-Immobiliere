﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WPF_TP.Data.DAL;

#nullable disable

namespace WPF_Exo.Migrations
{
    [DbContext(typeof(ImoContext))]
    [Migration("20230401131157_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WPF_TP.Data.Models.Biens", b =>
                {
                    b.Property<int>("BiensId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BiensId"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PretId")
                        .HasColumnType("integer");

                    b.Property<int>("Surface")
                        .HasColumnType("integer");

                    b.Property<int>("Valeur")
                        .HasColumnType("integer");

                    b.HasKey("BiensId");

                    b.HasIndex("PretId");

                    b.ToTable("Biens");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("WPF_TP.Data.Models.Contrat", b =>
                {
                    b.Property<int>("ContratId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ContratId"));

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateFin")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Loyer")
                        .HasColumnType("integer");

                    b.Property<int>("UnBienBiensId")
                        .HasColumnType("integer");

                    b.HasKey("ContratId");

                    b.HasIndex("UnBienBiensId");

                    b.ToTable("Contrats");
                });

            modelBuilder.Entity("WPF_TP.Data.Models.Intervention", b =>
                {
                    b.Property<int>("InterventionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("InterventionId"));

                    b.Property<int>("BienId")
                        .HasColumnType("integer");

                    b.Property<int?>("BiensId")
                        .HasColumnType("integer");

                    b.Property<string>("DateIntervention")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Information")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<List<int>>("ListPrestaId")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<int>("MontantTTC")
                        .HasColumnType("integer");

                    b.Property<int?>("PrestataireId")
                        .HasColumnType("integer");

                    b.HasKey("InterventionId");

                    b.HasIndex("BiensId");

                    b.HasIndex("PrestataireId");

                    b.ToTable("Intervention");
                });

            modelBuilder.Entity("WPF_TP.Data.Models.Locataire", b =>
                {
                    b.Property<int>("LocataireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LocataireId"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LocataireId");

                    b.ToTable("Locataires");
                });

            modelBuilder.Entity("WPF_TP.Data.Models.Prestataire", b =>
                {
                    b.Property<int>("PrestataireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PrestataireId"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RaisonSociale")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PrestataireId");

                    b.ToTable("Prestataires");
                });

            modelBuilder.Entity("WPF_TP.Data.Models.Pret", b =>
                {
                    b.Property<int>("PretId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PretId"));

                    b.Property<int>("Apport")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Duree")
                        .HasColumnType("integer");

                    b.Property<int>("Mensualite")
                        .HasColumnType("integer");

                    b.HasKey("PretId");

                    b.ToTable("Pret");
                });

            modelBuilder.Entity("WPF_TP.Data.Models.Box", b =>
                {
                    b.HasBaseType("WPF_TP.Data.Models.Biens");

                    b.Property<int>("BoxId")
                        .HasColumnType("integer");

                    b.ToTable("Box", (string)null);
                });

            modelBuilder.Entity("WPF_TP.Data.Models.Habitations", b =>
                {
                    b.HasBaseType("WPF_TP.Data.Models.Biens");

                    b.Property<int>("Cave")
                        .HasColumnType("integer");

                    b.Property<int>("HabitationsId")
                        .HasColumnType("integer");

                    b.Property<int>("NbChambre")
                        .HasColumnType("integer");

                    b.Property<int>("NbPiece")
                        .HasColumnType("integer");

                    b.Property<int>("Parking")
                        .HasColumnType("integer");

                    b.ToTable("Habitations", (string)null);
                });

            modelBuilder.Entity("WPF_Exo.Data.Models.Appartement", b =>
                {
                    b.HasBaseType("WPF_TP.Data.Models.Habitations");

                    b.Property<int>("AppartmentId")
                        .HasColumnType("integer");

                    b.Property<bool>("Ascenseur")
                        .HasColumnType("boolean");

                    b.Property<bool>("Chauffage")
                        .HasColumnType("boolean");

                    b.Property<int>("Etage")
                        .HasColumnType("integer");

                    b.ToTable("Appartement", (string)null);
                });

            modelBuilder.Entity("WPF_TP.Data.Models.Maison", b =>
                {
                    b.HasBaseType("WPF_TP.Data.Models.Habitations");

                    b.Property<int>("MaisonId")
                        .HasColumnType("integer");

                    b.ToTable("Maison", (string)null);
                });

            modelBuilder.Entity("WPF_TP.Data.Models.Biens", b =>
                {
                    b.HasOne("WPF_TP.Data.Models.Pret", "Pret")
                        .WithMany()
                        .HasForeignKey("PretId");

                    b.Navigation("Pret");
                });

            modelBuilder.Entity("WPF_TP.Data.Models.Contrat", b =>
                {
                    b.HasOne("WPF_TP.Data.Models.Biens", "UnBien")
                        .WithMany("ListContrat")
                        .HasForeignKey("UnBienBiensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UnBien");
                });

            modelBuilder.Entity("WPF_TP.Data.Models.Intervention", b =>
                {
                    b.HasOne("WPF_TP.Data.Models.Biens", null)
                        .WithMany("ListIntervention")
                        .HasForeignKey("BiensId");

                    b.HasOne("WPF_TP.Data.Models.Prestataire", null)
                        .WithMany("ListIntervention")
                        .HasForeignKey("PrestataireId");
                });

            modelBuilder.Entity("WPF_TP.Data.Models.Box", b =>
                {
                    b.HasOne("WPF_TP.Data.Models.Biens", null)
                        .WithOne()
                        .HasForeignKey("WPF_TP.Data.Models.Box", "BiensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WPF_TP.Data.Models.Habitations", b =>
                {
                    b.HasOne("WPF_TP.Data.Models.Biens", null)
                        .WithOne()
                        .HasForeignKey("WPF_TP.Data.Models.Habitations", "BiensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WPF_Exo.Data.Models.Appartement", b =>
                {
                    b.HasOne("WPF_TP.Data.Models.Habitations", null)
                        .WithOne()
                        .HasForeignKey("WPF_Exo.Data.Models.Appartement", "BiensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WPF_TP.Data.Models.Maison", b =>
                {
                    b.HasOne("WPF_TP.Data.Models.Habitations", null)
                        .WithOne()
                        .HasForeignKey("WPF_TP.Data.Models.Maison", "BiensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WPF_TP.Data.Models.Biens", b =>
                {
                    b.Navigation("ListContrat");

                    b.Navigation("ListIntervention");
                });

            modelBuilder.Entity("WPF_TP.Data.Models.Prestataire", b =>
                {
                    b.Navigation("ListIntervention");
                });
#pragma warning restore 612, 618
        }
    }
}
