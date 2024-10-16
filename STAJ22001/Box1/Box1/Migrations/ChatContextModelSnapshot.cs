﻿// <auto-generated />
using System;
using Box1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Box1.Migrations
{
    [DbContext(typeof(ChatContext))]
    partial class ChatContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Box1.Models.ChatMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mesaj")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Zamanlayici")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ChatMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
