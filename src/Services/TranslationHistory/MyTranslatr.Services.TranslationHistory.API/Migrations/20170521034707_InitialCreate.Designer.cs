using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TranslationHistory.API.Infrastructure;

namespace MyTranslatr.Services.TranslationHistory.API.Migrations
{
    [DbContext(typeof(TranslationHistoryDbContext))]
    [Migration("20170521034707_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TranslationHistory.API.Models.TranslationDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Language");

                    b.Property<bool>("Success");

                    b.Property<string>("Translation");

                    b.Property<string>("Word");

                    b.HasKey("Id");

                    b.ToTable("History");
                });
        }
    }
}
