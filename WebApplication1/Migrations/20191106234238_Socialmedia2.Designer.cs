﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20191106234238_Socialmedia2")]
    partial class Socialmedia2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Comments", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Commentsparentidid");

                    b.Property<DateTime>("DatePosted");

                    b.Property<int?>("Postetbypersonid");

                    b.Property<int?>("Postidid");

                    b.HasKey("id");

                    b.HasIndex("Commentsparentidid");

                    b.HasIndex("Postetbypersonid");

                    b.HasIndex("Postidid");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("WebApplication1.Models.Friendwith", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Friendaversary");

                    b.Property<int?>("SecondPersonid");

                    b.HasKey("Id");

                    b.HasIndex("SecondPersonid");

                    b.ToTable("Friendwiths");
                });

            modelBuilder.Entity("WebApplication1.Models.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("PhoneNumber")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("WebApplication1.Models.Post", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Personidid");

                    b.Property<string>("PostContent");

                    b.Property<DateTime>("PostedDate");

                    b.HasKey("id");

                    b.HasIndex("Personidid");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("WebApplication1.Models.PostImages", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName");

                    b.Property<int?>("Postidid");

                    b.Property<bool>("isPrimary");

                    b.HasKey("id");

                    b.HasIndex("Postidid");

                    b.ToTable("PostImages");
                });

            modelBuilder.Entity("WebApplication1.Models.Reaction", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Commentidid");

                    b.Property<int?>("Imageidid");

                    b.Property<int?>("Postidid");

                    b.Property<DateTime>("ReactionDate");

                    b.Property<int?>("Reactiontypeeid");

                    b.HasKey("id");

                    b.HasIndex("Commentidid");

                    b.HasIndex("Imageidid");

                    b.HasIndex("Postidid");

                    b.HasIndex("Reactiontypeeid");

                    b.ToTable("Reactions");
                });

            modelBuilder.Entity("WebApplication1.Models.ReactionType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IconURL");

                    b.Property<string>("TypeName")
                        .HasMaxLength(20);

                    b.HasKey("id");

                    b.ToTable("ReactionTypes");
                });

            modelBuilder.Entity("WebApplication1.Models.Comments", b =>
                {
                    b.HasOne("WebApplication1.Models.Comments", "Commentsparentid")
                        .WithMany("ParentCommentidd")
                        .HasForeignKey("Commentsparentidid");

                    b.HasOne("WebApplication1.Models.Person", "Postetbyperson")
                        .WithMany("Comments")
                        .HasForeignKey("Postetbypersonid");

                    b.HasOne("WebApplication1.Models.Post", "Postid")
                        .WithMany("Comments")
                        .HasForeignKey("Postidid");
                });

            modelBuilder.Entity("WebApplication1.Models.Friendwith", b =>
                {
                    b.HasOne("WebApplication1.Models.Person", "SecondPerson")
                        .WithMany("FrirstPersonn")
                        .HasForeignKey("SecondPersonid");
                });

            modelBuilder.Entity("WebApplication1.Models.Post", b =>
                {
                    b.HasOne("WebApplication1.Models.Person", "Personid")
                        .WithMany("Posts")
                        .HasForeignKey("Personidid");
                });

            modelBuilder.Entity("WebApplication1.Models.PostImages", b =>
                {
                    b.HasOne("WebApplication1.Models.Post", "Postid")
                        .WithMany("PostImages")
                        .HasForeignKey("Postidid");
                });

            modelBuilder.Entity("WebApplication1.Models.Reaction", b =>
                {
                    b.HasOne("WebApplication1.Models.Comments", "Commentid")
                        .WithMany("Reactions")
                        .HasForeignKey("Commentidid");

                    b.HasOne("WebApplication1.Models.PostImages", "Imageid")
                        .WithMany("Reactions")
                        .HasForeignKey("Imageidid");

                    b.HasOne("WebApplication1.Models.Post", "Postid")
                        .WithMany("Reactions")
                        .HasForeignKey("Postidid");

                    b.HasOne("WebApplication1.Models.ReactionType", "Reactiontypee")
                        .WithMany("Reactions")
                        .HasForeignKey("Reactiontypeeid");
                });
#pragma warning restore 612, 618
        }
    }
}
