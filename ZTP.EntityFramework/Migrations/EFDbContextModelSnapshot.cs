// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZTP.EntityFramework;

#nullable disable

namespace ZTP.EntityFramework.Migrations
{
    [DbContext(typeof(EFDbContext))]
    partial class EFDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ZTP.EntityFramework.Models.Level", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LvlAssets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LvlEnemies")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("ZTP.EntityFramework.Models.ScoreBoard", b =>
                {
                    b.Property<int>("ScoreBoardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScoreBoardId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("ScoreBoardId");

                    b.ToTable("ScoreBoards");
                });
#pragma warning restore 612, 618
        }
    }
}
