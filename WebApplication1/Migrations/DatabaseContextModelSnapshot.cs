﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChatHistory");

                    b.Property<int?>("FriendwithsId");

                    b.Property<bool>("IsOnline");

                    b.Property<int?>("PeopleIDId");

                    b.HasKey("Id");

                    b.HasIndex("FriendwithsId");

                    b.HasIndex("PeopleIDId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("WebApplication1.Models.Comments", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Commentsparentidid");

                    b.Property<DateTime>("DatePosted");

                    b.Property<int>("PostetbypersonId");

                    b.Property<int>("Postidid");

                    b.HasKey("id");

                    b.HasIndex("Commentsparentidid");

                    b.HasIndex("PostetbypersonId");

                    b.HasIndex("Postidid");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("WebApplication1.Models.DeletedMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ChatIdId");

                    b.Property<DateTime>("Datatime");

                    b.HasKey("Id");

                    b.HasIndex("ChatIdId");

                    b.ToTable("DeletedMessage");
                });

            modelBuilder.Entity("WebApplication1.Models.Friendwith", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FriendAversary");

                    b.Property<int>("SecondPersonId");

                    b.HasKey("Id");

                    b.HasIndex("SecondPersonId");

                    b.ToTable("Friendwiths");
                });

            modelBuilder.Entity("WebApplication1.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime");

                    b.Property<int?>("PersonIDId");

                    b.HasKey("Id");

                    b.HasIndex("PersonIDId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("WebApplication1.Models.Person", b =>
                {
                    b.Property<int>("Id")
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

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("WebApplication1.Models.Post", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("NotificationIdId");

                    b.Property<int?>("PersonIdId");

                    b.Property<string>("PostContent")
                        .IsRequired();

                    b.Property<DateTime>("PostedDate");

                    b.HasKey("id");

                    b.HasIndex("NotificationIdId");

                    b.HasIndex("PersonIdId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("WebApplication1.Models.PostImages", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .IsRequired();

                    b.Property<int>("Postidid");

                    b.Property<bool>("isPrimary");

                    b.HasKey("id");

                    b.HasIndex("Postidid");

                    b.ToTable("PostImages");
                });

            modelBuilder.Entity("WebApplication1.Models.Reaction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CommentIdid");

                    b.Property<int?>("ImageIdid");

                    b.Property<int?>("NotioficationIdId");

                    b.Property<int?>("PostIdid");

                    b.Property<DateTime>("ReactionDate");

                    b.Property<int?>("Reactiontypeeid");

                    b.HasKey("ID");

                    b.HasIndex("CommentIdid");

                    b.HasIndex("ImageIdid");

                    b.HasIndex("NotioficationIdId");

                    b.HasIndex("PostIdid");

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

            modelBuilder.Entity("WebApplication1.Models.Chat", b =>
                {
                    b.HasOne("WebApplication1.Models.Friendwith", "Friendwiths")
                        .WithMany("ChatID")
                        .HasForeignKey("FriendwithsId");

                    b.HasOne("WebApplication1.Models.Person", "PeopleID")
                        .WithMany("ChatID")
                        .HasForeignKey("PeopleIDId");
                });

            modelBuilder.Entity("WebApplication1.Models.Comments", b =>
                {
                    b.HasOne("WebApplication1.Models.Comments", "Commentsparentid")
                        .WithMany("ParentCommentidd")
                        .HasForeignKey("Commentsparentidid");

                    b.HasOne("WebApplication1.Models.Person", "Postetbyperson")
                        .WithMany("Comments")
                        .HasForeignKey("PostetbypersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.Post", "Postid")
                        .WithMany("Comments")
                        .HasForeignKey("Postidid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.DeletedMessage", b =>
                {
                    b.HasOne("WebApplication1.Models.Chat", "ChatId")
                        .WithMany("deletedMessages")
                        .HasForeignKey("ChatIdId");
                });

            modelBuilder.Entity("WebApplication1.Models.Friendwith", b =>
                {
                    b.HasOne("WebApplication1.Models.Person", "SecondPerson")
                        .WithMany("FrirstPersonn")
                        .HasForeignKey("SecondPersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.Notification", b =>
                {
                    b.HasOne("WebApplication1.Models.Person", "PersonID")
                        .WithMany("NotificationID")
                        .HasForeignKey("PersonIDId");
                });

            modelBuilder.Entity("WebApplication1.Models.Post", b =>
                {
                    b.HasOne("WebApplication1.Models.Notification", "NotificationId")
                        .WithMany("Post")
                        .HasForeignKey("NotificationIdId");

                    b.HasOne("WebApplication1.Models.Person", "PersonId")
                        .WithMany("Posts")
                        .HasForeignKey("PersonIdId");
                });

            modelBuilder.Entity("WebApplication1.Models.PostImages", b =>
                {
                    b.HasOne("WebApplication1.Models.Post", "Postid")
                        .WithMany("PostImages")
                        .HasForeignKey("Postidid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.Reaction", b =>
                {
                    b.HasOne("WebApplication1.Models.Comments", "CommentId")
                        .WithMany("Reactions")
                        .HasForeignKey("CommentIdid");

                    b.HasOne("WebApplication1.Models.PostImages", "ImageId")
                        .WithMany("Reactions")
                        .HasForeignKey("ImageIdid");

                    b.HasOne("WebApplication1.Models.Notification", "NotioficationId")
                        .WithMany("Reactions")
                        .HasForeignKey("NotioficationIdId");

                    b.HasOne("WebApplication1.Models.Post", "PostId")
                        .WithMany("Reactions")
                        .HasForeignKey("PostIdid");

                    b.HasOne("WebApplication1.Models.ReactionType", "Reactiontypee")
                        .WithMany("Reactions")
                        .HasForeignKey("Reactiontypeeid");
                });
#pragma warning restore 612, 618
        }
    }
}
