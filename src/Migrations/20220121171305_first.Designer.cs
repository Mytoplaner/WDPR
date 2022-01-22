﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace src.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220121171305_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Aanmelding", b =>
                {
                    b.Property<int>("AanmeldingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Achternaam")
                        .HasColumnType("TEXT");

                    b.Property<string>("AfspraakDatum")
                        .HasColumnType("TEXT");

                    b.Property<int>("BSN")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailVoogd")
                        .HasColumnType("TEXT");

                    b.Property<int>("HulpverlenerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Leeftijdscategorie")
                        .HasColumnType("TEXT");

                    b.Property<string>("NaamVoogd")
                        .HasColumnType("TEXT");

                    b.Property<string>("Stoornis")
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefoonVoogd")
                        .HasColumnType("TEXT");

                    b.Property<string>("Voornaam")
                        .HasColumnType("TEXT");

                    b.HasKey("AanmeldingId");

                    b.HasIndex("HulpverlenerId");

                    b.ToTable("Aanmeldingen");
                });

            modelBuilder.Entity("Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Achternaam")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Voornaam")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Woonplaats")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Woonplaats")
                        .IsUnique();

                    b.ToTable("Accounts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Account");
                });

            modelBuilder.Entity("ClientGroepsChat", b =>
                {
                    b.Property<int>("DeelnemersId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("groepChatsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DeelnemersId", "groepChatsId");

                    b.HasIndex("groepChatsId");

                    b.ToTable("ClientGroepsChat");
                });

            modelBuilder.Entity("GroepsChat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LeeftijdsCategorie")
                        .HasColumnType("TEXT");

                    b.Property<string>("Onderwerp")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("eindDatum")
                        .HasColumnType("TEXT");

                    b.Property<int?>("hulpverlenerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("hulpverlenerId");

                    b.ToTable("groepsChats");
                });

            modelBuilder.Entity("HulpverlenerMelding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClientId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("HulpverlenerMeldingen");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MisbruikMelding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BerichtId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Melding")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BerichtId");

                    b.ToTable("MisbruikMelding");
                });

            modelBuilder.Entity("Woonplaats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adres")
                        .HasColumnType("TEXT");

                    b.Property<string>("Postcode")
                        .HasColumnType("TEXT");

                    b.Property<string>("plaats")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Woonplaats");
                });

            modelBuilder.Entity("src.Models.Bericht", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Account")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Bericht")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("TEXT");

                    b.Property<int?>("GroepsChatId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("chatId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Account");

                    b.HasIndex("Bericht");

                    b.HasIndex("GroepsChatId");

                    b.ToTable("Berichten");
                });

            modelBuilder.Entity("src.Models.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("clientId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("hulpverlenerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("naam")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("clientId");

                    b.HasIndex("hulpverlenerId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Client", b =>
                {
                    b.HasBaseType("Account");

                    b.Property<string>("ApplicatieGebruiker")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Voogd")
                        .HasColumnType("INTEGER");

                    b.Property<int>("hulpverlenerId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("magChatten")
                        .HasColumnType("INTEGER");

                    b.HasIndex("ApplicatieGebruiker")
                        .IsUnique();

                    b.HasIndex("hulpverlenerId");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("Hulpverlener", b =>
                {
                    b.HasBaseType("Account");

                    b.Property<string>("ApplicatieGebruiker")
                        .HasColumnType("TEXT")
                        .HasColumnName("Hulpverlener_ApplicatieGebruiker");

                    b.Property<string>("Beschrijving")
                        .HasColumnType("TEXT");

                    b.HasIndex("ApplicatieGebruiker")
                        .IsUnique();

                    b.HasDiscriminator().HasValue("Hulpverlener");
                });

            modelBuilder.Entity("Moderator", b =>
                {
                    b.HasBaseType("Account");

                    b.Property<string>("ApplicatieGebruiker")
                        .HasColumnType("TEXT")
                        .HasColumnName("Moderator_ApplicatieGebruiker");

                    b.HasIndex("ApplicatieGebruiker")
                        .IsUnique();

                    b.HasDiscriminator().HasValue("Moderator");
                });

            modelBuilder.Entity("Voogd", b =>
                {
                    b.HasBaseType("Account");

                    b.Property<string>("ApplicatieGebruiker")
                        .HasColumnType("TEXT")
                        .HasColumnName("Voogd_ApplicatieGebruiker");

                    b.Property<int?>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefoon")
                        .HasColumnType("TEXT");

                    b.HasIndex("ApplicatieGebruiker")
                        .IsUnique();

                    b.HasIndex("ClientId");

                    b.HasDiscriminator().HasValue("Voogd");
                });

            modelBuilder.Entity("ApplicatieGebruiker", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("ApplicatieGebruiker");
                });

            modelBuilder.Entity("Aanmelding", b =>
                {
                    b.HasOne("Hulpverlener", "Hulpverlener")
                        .WithMany()
                        .HasForeignKey("HulpverlenerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hulpverlener");
                });

            modelBuilder.Entity("Account", b =>
                {
                    b.HasOne("Woonplaats", "woonplaats")
                        .WithOne("account")
                        .HasForeignKey("Account", "Woonplaats");

                    b.Navigation("woonplaats");
                });

            modelBuilder.Entity("ClientGroepsChat", b =>
                {
                    b.HasOne("Client", null)
                        .WithMany()
                        .HasForeignKey("DeelnemersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroepsChat", null)
                        .WithMany()
                        .HasForeignKey("groepChatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GroepsChat", b =>
                {
                    b.HasOne("Hulpverlener", "hulpverlener")
                        .WithMany()
                        .HasForeignKey("hulpverlenerId");

                    b.Navigation("hulpverlener");
                });

            modelBuilder.Entity("HulpverlenerMelding", b =>
                {
                    b.HasOne("Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MisbruikMelding", b =>
                {
                    b.HasOne("src.Models.Bericht", "Bericht")
                        .WithMany()
                        .HasForeignKey("BerichtId");

                    b.Navigation("Bericht");
                });

            modelBuilder.Entity("src.Models.Bericht", b =>
                {
                    b.HasOne("Account", "Verzender")
                        .WithMany()
                        .HasForeignKey("Account");

                    b.HasOne("src.Models.Chat", "chat")
                        .WithMany("Berichten")
                        .HasForeignKey("Bericht");

                    b.HasOne("GroepsChat", null)
                        .WithMany("Berichten")
                        .HasForeignKey("GroepsChatId");

                    b.Navigation("chat");

                    b.Navigation("Verzender");
                });

            modelBuilder.Entity("src.Models.Chat", b =>
                {
                    b.HasOne("Client", "client")
                        .WithMany()
                        .HasForeignKey("clientId");

                    b.HasOne("Hulpverlener", "hulpverlener")
                        .WithMany()
                        .HasForeignKey("hulpverlenerId");

                    b.Navigation("client");

                    b.Navigation("hulpverlener");
                });

            modelBuilder.Entity("Client", b =>
                {
                    b.HasOne("ApplicatieGebruiker", "User")
                        .WithOne("client")
                        .HasForeignKey("Client", "ApplicatieGebruiker");

                    b.HasOne("Hulpverlener", "hulpverlener")
                        .WithMany()
                        .HasForeignKey("hulpverlenerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hulpverlener");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hulpverlener", b =>
                {
                    b.HasOne("ApplicatieGebruiker", "User")
                        .WithOne("hulpverlener")
                        .HasForeignKey("Hulpverlener", "ApplicatieGebruiker");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Moderator", b =>
                {
                    b.HasOne("ApplicatieGebruiker", "User")
                        .WithOne("moderator")
                        .HasForeignKey("Moderator", "ApplicatieGebruiker");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Voogd", b =>
                {
                    b.HasOne("ApplicatieGebruiker", "User")
                        .WithOne("voogd")
                        .HasForeignKey("Voogd", "ApplicatieGebruiker");

                    b.HasOne("Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.Navigation("Client");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GroepsChat", b =>
                {
                    b.Navigation("Berichten");
                });

            modelBuilder.Entity("Woonplaats", b =>
                {
                    b.Navigation("account");
                });

            modelBuilder.Entity("src.Models.Chat", b =>
                {
                    b.Navigation("Berichten");
                });

            modelBuilder.Entity("ApplicatieGebruiker", b =>
                {
                    b.Navigation("client");

                    b.Navigation("hulpverlener");

                    b.Navigation("moderator");

                    b.Navigation("voogd");
                });
#pragma warning restore 612, 618
        }
    }
}
