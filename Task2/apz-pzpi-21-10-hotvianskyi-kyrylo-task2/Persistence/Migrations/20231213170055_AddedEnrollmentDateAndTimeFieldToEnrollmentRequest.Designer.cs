﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence.DatabaseContext;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231213170055_AddedEnrollmentDateAndTimeFieldToEnrollmentRequest")]
    partial class AddedEnrollmentDateAndTimeFieldToEnrollmentRequest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Gym", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Gyms");
                });

            modelBuilder.Entity("Domain.GymEnrollmentRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EnrollmentDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("GymId")
                        .HasColumnType("integer");

                    b.Property<int>("MemberId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("GymEnrollmentRequests");
                });

            modelBuilder.Entity("Domain.Measurement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("BodyMassIndex")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("FatPercentage")
                        .HasColumnType("double precision");

                    b.Property<double>("Height")
                        .HasColumnType("double precision");

                    b.Property<double>("LevelOfStress")
                        .HasColumnType("double precision");

                    b.Property<int>("LowerPressure")
                        .HasColumnType("integer");

                    b.Property<int>("MemberId")
                        .HasColumnType("integer");

                    b.Property<double>("MusclePercentage")
                        .HasColumnType("double precision");

                    b.Property<int>("UpperPressure")
                        .HasColumnType("integer");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Measurements");
                });

            modelBuilder.Entity("Domain.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("GymId")
                        .HasColumnType("integer");

                    b.Property<string>("IdentityId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GymId");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateOnly(2004, 1, 9),
                            FirstName = "User",
                            IdentityId = "9e224968-33e4-4652-b7b7-8574d048cdb9",
                            LastName = "Userovich",
                            Sex = "Male"
                        });
                });

            modelBuilder.Entity("Domain.Recommendation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Recommendations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Key = "LowFat"
                        },
                        new
                        {
                            Id = 2,
                            Key = "NormalFat"
                        },
                        new
                        {
                            Id = 3,
                            Key = "HighFat"
                        },
                        new
                        {
                            Id = 4,
                            Key = "LowMuscle"
                        },
                        new
                        {
                            Id = 5,
                            Key = "NormalMuscle"
                        },
                        new
                        {
                            Id = 6,
                            Key = "HighMuscle"
                        },
                        new
                        {
                            Id = 7,
                            Key = "ExtremelyLowBMI"
                        },
                        new
                        {
                            Id = 8,
                            Key = "LowBMI"
                        },
                        new
                        {
                            Id = 9,
                            Key = "NormalBMI"
                        },
                        new
                        {
                            Id = 10,
                            Key = "HighBMI"
                        },
                        new
                        {
                            Id = 11,
                            Key = "ExtremelyHighBMI"
                        },
                        new
                        {
                            Id = 12,
                            Key = "NormalStress"
                        },
                        new
                        {
                            Id = 13,
                            Key = "HighStress"
                        },
                        new
                        {
                            Id = 14,
                            Key = "LowPressure"
                        },
                        new
                        {
                            Id = 15,
                            Key = "NormalPressure"
                        },
                        new
                        {
                            Id = 16,
                            Key = "HighPressure"
                        });
                });

            modelBuilder.Entity("Domain.Measurement", b =>
                {
                    b.HasOne("Domain.Member", "Member")
                        .WithMany("Measurements")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Domain.Member", b =>
                {
                    b.HasOne("Domain.Gym", "Gym")
                        .WithMany("Members")
                        .HasForeignKey("GymId");

                    b.Navigation("Gym");
                });

            modelBuilder.Entity("Domain.Gym", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("Domain.Member", b =>
                {
                    b.Navigation("Measurements");
                });
#pragma warning restore 612, 618
        }
    }
}
