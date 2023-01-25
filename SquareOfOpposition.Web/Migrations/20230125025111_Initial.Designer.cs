﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SquareOfOpposition.Web.Data;

#nullable disable

namespace SquareOfOpposition.Web.Migrations
{
    [DbContext(typeof(SquareOfOppositionDbContext))]
    [Migration("20230125025111_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SquareOfOpposition.Web.Models.Domain.Square", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentStateId")
                        .HasColumnType("int");

                    b.Property<string>("SentenceA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SentenceE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SentenceI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SentenceO")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParentStateId");

                    b.ToTable("Squares");
                });

            modelBuilder.Entity("SquareOfOpposition.Web.Models.Domain.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("SquareId")
                        .HasColumnType("int");

                    b.Property<int>("StateTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SquareId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("SquareOfOpposition.Web.Models.Domain.StateTransition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DestinationStateId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PickupStateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DestinationStateId");

                    b.HasIndex("PickupStateId");

                    b.ToTable("StateTransitions");
                });

            modelBuilder.Entity("SquareOfOpposition.Web.Models.Domain.Square", b =>
                {
                    b.HasOne("SquareOfOpposition.Web.Models.Domain.State", "ParentState")
                        .WithMany("Squares")
                        .HasForeignKey("ParentStateId");

                    b.Navigation("ParentState");
                });

            modelBuilder.Entity("SquareOfOpposition.Web.Models.Domain.State", b =>
                {
                    b.HasOne("SquareOfOpposition.Web.Models.Domain.Square", "Square")
                        .WithMany("States")
                        .HasForeignKey("SquareId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Square");
                });

            modelBuilder.Entity("SquareOfOpposition.Web.Models.Domain.StateTransition", b =>
                {
                    b.HasOne("SquareOfOpposition.Web.Models.Domain.State", "DestinationState")
                        .WithMany("OutTransitions")
                        .HasForeignKey("DestinationStateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SquareOfOpposition.Web.Models.Domain.State", "PickupState")
                        .WithMany("InTransitions")
                        .HasForeignKey("PickupStateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DestinationState");

                    b.Navigation("PickupState");
                });

            modelBuilder.Entity("SquareOfOpposition.Web.Models.Domain.Square", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("SquareOfOpposition.Web.Models.Domain.State", b =>
                {
                    b.Navigation("InTransitions");

                    b.Navigation("OutTransitions");

                    b.Navigation("Squares");
                });
#pragma warning restore 612, 618
        }
    }
}