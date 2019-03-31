﻿// <auto-generated />
using System;
using ConfModel.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConfModel.Migrations
{
    [DbContext(typeof(ConfContext))]
    [Migration("20190322185301_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085");

            modelBuilder.Entity("ConfModel.Model.AdminOfConference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ConferenceId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ConferenceId");

                    b.HasIndex("UserId");

                    b.ToTable("AdminOfConferences");
                });

            modelBuilder.Entity("ConfModel.Model.Conference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTimeFinishConference");

                    b.Property<DateTime>("DateTimeStartConference");

                    b.Property<string>("Info")
                        .HasMaxLength(8000);

                    b.Property<string>("Location")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Conferences");
                });

            modelBuilder.Entity("ConfModel.Model.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LectureId");

                    b.Property<string>("Name")
                        .HasMaxLength(300);

                    b.Property<bool>("Private");

                    b.Property<double>("Size");

                    b.HasKey("Id");

                    b.HasIndex("LectureId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("ConfModel.Model.Lecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTimeCloseChat");

                    b.Property<DateTime>("DateTimeOpenChat");

                    b.Property<DateTime>("DateTimeStart");

                    b.Property<string>("Info")
                        .HasMaxLength(8000);

                    b.Property<int>("SectionId");

                    b.Property<string>("Topic")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("ConfModel.Model.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTimeSent");

                    b.Property<int>("LectureId");

                    b.Property<string>("Text")
                        .HasMaxLength(200);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("LectureId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("ConfModel.Model.RoleInLecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LectureId");

                    b.Property<int>("Role");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("LectureId");

                    b.HasIndex("UserId");

                    b.ToTable("RoleInLectures");
                });

            modelBuilder.Entity("ConfModel.Model.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ConferenceId");

                    b.Property<string>("Info")
                        .HasMaxLength(8000);

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ConferenceId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("ConfModel.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<bool>("IsGlobalAdmin");

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<string>("PassHash")
                        .HasMaxLength(500);

                    b.Property<int>("Sex");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ConfModel.Model.AdminOfConference", b =>
                {
                    b.HasOne("ConfModel.Model.Conference", "Conference")
                        .WithMany("AdminOfConferences")
                        .HasForeignKey("ConferenceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConfModel.Model.User")
                        .WithMany("AdminOfConferences")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConfModel.Model.File", b =>
                {
                    b.HasOne("ConfModel.Model.Lecture", "Lecture")
                        .WithMany("Files")
                        .HasForeignKey("LectureId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConfModel.Model.Lecture", b =>
                {
                    b.HasOne("ConfModel.Model.Section", "Section")
                        .WithMany("Lectures")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConfModel.Model.Message", b =>
                {
                    b.HasOne("ConfModel.Model.Lecture", "Lecture")
                        .WithMany("Messages")
                        .HasForeignKey("LectureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConfModel.Model.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConfModel.Model.RoleInLecture", b =>
                {
                    b.HasOne("ConfModel.Model.Lecture", "Lecture")
                        .WithMany("RoleInLectures")
                        .HasForeignKey("LectureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConfModel.Model.User", "User")
                        .WithMany("RoleInLectures")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConfModel.Model.Section", b =>
                {
                    b.HasOne("ConfModel.Model.Conference", "Conference")
                        .WithMany("Sections")
                        .HasForeignKey("ConferenceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}