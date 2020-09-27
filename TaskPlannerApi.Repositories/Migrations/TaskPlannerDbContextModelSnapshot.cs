﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskPlannerApi.Repositories;

namespace TaskPlannerApi.Repositories.Migrations
{
    [DbContext(typeof(TaskPlannerDbContext))]
    partial class TaskPlannerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskPlannerApi.Repositories.Entities.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("TaskItemId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("TaskItemId");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("TaskPlannerApi.Repositories.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("TaskPlannerApi.Repositories.Entities.TaskItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("StatusId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("TaskItem");
                });

            modelBuilder.Entity("TaskPlannerApi.Repositories.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("TaskPlannerApi.Repositories.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("LastName")
                        .HasMaxLength(128);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("TaskPlannerApi.Repositories.Entities.UserTeam", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("TeamId");

                    b.HasKey("UserId", "TeamId");

                    b.HasIndex("TeamId");

                    b.ToTable("UserTeam");
                });

            modelBuilder.Entity("TaskPlannerApi.Repositories.Entities.Note", b =>
                {
                    b.HasOne("TaskPlannerApi.Repositories.Entities.TaskItem", "TaskItem")
                        .WithMany("Notes")
                        .HasForeignKey("TaskItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TaskPlannerApi.Repositories.Entities.TaskItem", b =>
                {
                    b.HasOne("TaskPlannerApi.Repositories.Entities.Status", "Status")
                        .WithMany("TaskItems")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TaskPlannerApi.Repositories.Entities.User", "User")
                        .WithMany("TaskItems")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TaskPlannerApi.Repositories.Entities.UserTeam", b =>
                {
                    b.HasOne("TaskPlannerApi.Repositories.Entities.Team", "Team")
                        .WithMany("UserTeams")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TaskPlannerApi.Repositories.Entities.User", "User")
                        .WithMany("UserTeams")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}