﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Rech.Barbeiro.Shop.Database.Base;

#nullable disable

namespace Rech.Barbeiro.Shop.Database.Migrations
{
    [DbContext(typeof(ContextoDatabase))]
    [Migration("20240507124432_AlteradoParaOUsuarioReferenciarABarbearia")]
    partial class AlteradoParaOUsuarioReferenciarABarbearia
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.Agendamento.AgendamentoEntidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BarberioId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ServicoId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("BarberioId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ServicoId");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.AgendamentoFolga.AgendamentoFolgaEntidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BarbeiroId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("HorarioFim")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("HorarioInicio")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("BarbeiroId");

                    b.ToTable("FolgasBarbearia");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.Barbearia.BarbeariaEntidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Descricao")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("character varying(120)");

                    b.HasKey("Id");

                    b.ToTable("Barbearias");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.Barbeiro.BarbeiroEntidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BarbeariaId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)");

                    b.HasKey("Id");

                    b.HasIndex("BarbeariaId");

                    b.ToTable("BarbeirosBarbearia");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.Cliente.ClienteEntidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)");

                    b.Property<int>("Idade")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.ClienteEndereco.ClienteEnderecoEntidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("EnderecoClientes");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.DiasTrabalhoBarbeiro.DiasTrabalhoBarbeiroEntidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BarbeiroId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DiaDaSemana")
                        .HasColumnType("integer");

                    b.Property<TimeOnly>("HorarioFim")
                        .HasColumnType("time without time zone");

                    b.Property<TimeOnly?>("HorarioFimAlmoco")
                        .HasColumnType("time without time zone");

                    b.Property<TimeOnly>("HorarioInicio")
                        .HasColumnType("time without time zone");

                    b.Property<TimeOnly?>("HorarioInicioAlmoco")
                        .HasColumnType("time without time zone");

                    b.Property<bool>("RealizaAlmoco")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("BarbeiroId");

                    b.ToTable("DiasTrabalhoBarberio");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.ServicoBarbearia.ServicoBarbeariaEntidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BarbeariaId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<double>("TempoExecucao")
                        .HasColumnType("double precision");

                    b.Property<double>("Valor")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("BarbeariaId");

                    b.ToTable("ServicosBarbearias");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.ServicoBarbeiro.ServicoBarbeiroEntidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BarbeiroId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ServicoId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("BarbeiroId");

                    b.HasIndex("ServicoId");

                    b.ToTable("ServicosBarbeiro");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.Usuario.UsuarioEntidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<Guid>("BarbeariaId")
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("BarbeariaId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Rech.Barbeiro.Shop.Domain.Usuario.UsuarioEntidade", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Rech.Barbeiro.Shop.Domain.Usuario.UsuarioEntidade", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rech.Barbeiro.Shop.Domain.Usuario.UsuarioEntidade", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Rech.Barbeiro.Shop.Domain.Usuario.UsuarioEntidade", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.Agendamento.AgendamentoEntidade", b =>
                {
                    b.HasOne("Rech.Barbeiro.Shop.Domain.Barbeiro.BarbeiroEntidade", "Barbeiro")
                        .WithMany("Agendamentos")
                        .HasForeignKey("BarberioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rech.Barbeiro.Shop.Domain.Cliente.ClienteEntidade", "Cliente")
                        .WithMany("Agendamentos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rech.Barbeiro.Shop.Domain.ServicoBarbearia.ServicoBarbeariaEntidade", "Servico")
                        .WithMany("Agendamentos")
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barbeiro");

                    b.Navigation("Cliente");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.AgendamentoFolga.AgendamentoFolgaEntidade", b =>
                {
                    b.HasOne("Rech.Barbeiro.Shop.Domain.Barbeiro.BarbeiroEntidade", "Barbeiro")
                        .WithMany("Folgas")
                        .HasForeignKey("BarbeiroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barbeiro");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.Barbeiro.BarbeiroEntidade", b =>
                {
                    b.HasOne("Rech.Barbeiro.Shop.Domain.Barbearia.BarbeariaEntidade", "Barbearia")
                        .WithMany("Barbeiros")
                        .HasForeignKey("BarbeariaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barbearia");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.ClienteEndereco.ClienteEnderecoEntidade", b =>
                {
                    b.HasOne("Rech.Barbeiro.Shop.Domain.Cliente.ClienteEntidade", "Cliente")
                        .WithOne("Endereco")
                        .HasForeignKey("Rech.Barbeiro.Shop.Domain.ClienteEndereco.ClienteEnderecoEntidade", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.DiasTrabalhoBarbeiro.DiasTrabalhoBarbeiroEntidade", b =>
                {
                    b.HasOne("Rech.Barbeiro.Shop.Domain.Barbeiro.BarbeiroEntidade", "Barbeiro")
                        .WithMany("DiasTrabalho")
                        .HasForeignKey("BarbeiroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barbeiro");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.ServicoBarbearia.ServicoBarbeariaEntidade", b =>
                {
                    b.HasOne("Rech.Barbeiro.Shop.Domain.Barbearia.BarbeariaEntidade", "Barbearia")
                        .WithMany("Servicos")
                        .HasForeignKey("BarbeariaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barbearia");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.ServicoBarbeiro.ServicoBarbeiroEntidade", b =>
                {
                    b.HasOne("Rech.Barbeiro.Shop.Domain.Barbeiro.BarbeiroEntidade", "Barbeiro")
                        .WithMany("Servicos")
                        .HasForeignKey("BarbeiroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rech.Barbeiro.Shop.Domain.ServicoBarbearia.ServicoBarbeariaEntidade", "Servico")
                        .WithMany("ServicosBarbeiros")
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barbeiro");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.Usuario.UsuarioEntidade", b =>
                {
                    b.HasOne("Rech.Barbeiro.Shop.Domain.Barbearia.BarbeariaEntidade", "Barbearia")
                        .WithMany()
                        .HasForeignKey("BarbeariaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barbearia");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.Barbearia.BarbeariaEntidade", b =>
                {
                    b.Navigation("Barbeiros");

                    b.Navigation("Servicos");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.Barbeiro.BarbeiroEntidade", b =>
                {
                    b.Navigation("Agendamentos");

                    b.Navigation("DiasTrabalho");

                    b.Navigation("Folgas");

                    b.Navigation("Servicos");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.Cliente.ClienteEntidade", b =>
                {
                    b.Navigation("Agendamentos");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Rech.Barbeiro.Shop.Domain.ServicoBarbearia.ServicoBarbeariaEntidade", b =>
                {
                    b.Navigation("Agendamentos");

                    b.Navigation("ServicosBarbeiros");
                });
#pragma warning restore 612, 618
        }
    }
}
