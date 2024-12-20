﻿// <auto-generated />
using System;
using HydraulicFix.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HydraulicFix.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("HydraulicFix.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .HasColumnType("longtext");

                    b.Property<string>("Cedula")
                        .HasColumnType("longtext");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NickName")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Shared.Models.Abonos", b =>
                {
                    b.Property<int>("AbonoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AbonoId"));

                    b.Property<string>("ClienteId")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("Monto")
                        .HasColumnType("float");

                    b.Property<string>("Nota")
                        .HasColumnType("longtext");

                    b.Property<bool>("Pago")
                        .HasColumnType("tinyint(1)");

                    b.Property<float>("Restante")
                        .HasColumnType("float");

                    b.Property<int>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("AbonoId");

                    b.ToTable("Abonos");
                });

            modelBuilder.Entity("Shared.Models.AbonosDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DetalleId"));

                    b.Property<int>("AbonoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MetodoPagoId")
                        .HasColumnType("int");

                    b.Property<float>("Monto")
                        .HasColumnType("float");

                    b.HasKey("DetalleId");

                    b.HasIndex("AbonoId");

                    b.ToTable("AbonosDetalle");
                });

            modelBuilder.Entity("Shared.Models.CategoriaProductos", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CategoriaId");

                    b.ToTable("CategoriaProductos");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            Nombre = "Sello mecánico"
                        },
                        new
                        {
                            CategoriaId = 2,
                            Nombre = "Limpiador"
                        },
                        new
                        {
                            CategoriaId = 3,
                            Nombre = "Sello de pistón"
                        },
                        new
                        {
                            CategoriaId = 4,
                            Nombre = "Collarín de fijación"
                        },
                        new
                        {
                            CategoriaId = 5,
                            Nombre = "Retén de eje"
                        },
                        new
                        {
                            CategoriaId = 6,
                            Nombre = "Lubricante"
                        },
                        new
                        {
                            CategoriaId = 7,
                            Nombre = "Filtro"
                        },
                        new
                        {
                            CategoriaId = 8,
                            Nombre = "Retén de doble labio"
                        },
                        new
                        {
                            CategoriaId = 9,
                            Nombre = "Sello de vástago"
                        },
                        new
                        {
                            CategoriaId = 10,
                            Nombre = "Sello de fibra"
                        },
                        new
                        {
                            CategoriaId = 11,
                            Nombre = "Sello de válvula"
                        });
                });

            modelBuilder.Entity("Shared.Models.Condiciones", b =>
                {
                    b.Property<int>("CondicionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CondicionId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CondicionId");

                    b.ToTable("Condiciones");

                    b.HasData(
                        new
                        {
                            CondicionId = 1,
                            Nombre = "Contado"
                        },
                        new
                        {
                            CondicionId = 2,
                            Nombre = "Credito"
                        });
                });

            modelBuilder.Entity("Shared.Models.Configuraciones", b =>
                {
                    b.Property<int>("ConfiguracionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ConfiguracionId"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("longblob");

                    b.Property<string>("ImagenUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("NFC")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("NombreEmpresa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nota")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ConfiguracionId");

                    b.ToTable("Configuraciones");
                });

            modelBuilder.Entity("Shared.Models.Estados", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("EstadoId"));

                    b.Property<string>("NombreEstado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("EstadoId");

                    b.ToTable("Estados");

                    b.HasData(
                        new
                        {
                            EstadoId = 1,
                            NombreEstado = "Pendiente"
                        },
                        new
                        {
                            EstadoId = 2,
                            NombreEstado = "En Proceso"
                        },
                        new
                        {
                            EstadoId = 3,
                            NombreEstado = "Completado"
                        },
                        new
                        {
                            EstadoId = 4,
                            NombreEstado = "Cancelado"
                        });
                });

            modelBuilder.Entity("Shared.Models.Gastos", b =>
                {
                    b.Property<int>("GastoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("GastoId"));

                    b.Property<string>("Asunto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Monto")
                        .HasColumnType("double");

                    b.HasKey("GastoId");

                    b.ToTable("Gastos");
                });

            modelBuilder.Entity("Shared.Models.MetodoPagos", b =>
                {
                    b.Property<int>("MetodoPagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MetodoPagoId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MetodoPagoId");

                    b.ToTable("MetodoPagos");

                    b.HasData(
                        new
                        {
                            MetodoPagoId = 1,
                            Nombre = "Efectivo"
                        },
                        new
                        {
                            MetodoPagoId = 2,
                            Nombre = "Tarjeta"
                        });
                });

            modelBuilder.Entity("Shared.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ProductoId"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Descuento")
                        .HasColumnType("int");

                    b.Property<bool>("EsDisponible")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ITBIS")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Precio")
                        .HasColumnType("float");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Cantidad = 4,
                            CategoriaId = 1,
                            Codigo = "1",
                            Descuento = 6,
                            EsDisponible = true,
                            ITBIS = 4,
                            Nombre = "Sello mecánico de cartucho",
                            Precio = 500f,
                            ProveedorId = 1
                        },
                        new
                        {
                            ProductoId = 2,
                            Cantidad = 6,
                            CategoriaId = 2,
                            Codigo = "2",
                            Descuento = 6,
                            EsDisponible = true,
                            ITBIS = 4,
                            Nombre = "Limpiador hidráulio",
                            Precio = 200f,
                            ProveedorId = 2
                        },
                        new
                        {
                            ProductoId = 3,
                            Cantidad = 3,
                            CategoriaId = 3,
                            Codigo = "3",
                            Descuento = 6,
                            EsDisponible = true,
                            ITBIS = 4,
                            Nombre = "Sello de pistón",
                            Precio = 240f,
                            ProveedorId = 3
                        },
                        new
                        {
                            ProductoId = 4,
                            Cantidad = 5,
                            CategoriaId = 4,
                            Codigo = "4",
                            Descuento = 6,
                            EsDisponible = true,
                            ITBIS = 4,
                            Nombre = "Collarín de fijación para ejes",
                            Precio = 450f,
                            ProveedorId = 4
                        },
                        new
                        {
                            ProductoId = 5,
                            Cantidad = 6,
                            CategoriaId = 5,
                            Codigo = "5",
                            Descuento = 6,
                            EsDisponible = true,
                            ITBIS = 4,
                            Nombre = "Retén de eje de goma",
                            Precio = 200f,
                            ProveedorId = 5
                        },
                        new
                        {
                            ProductoId = 6,
                            Cantidad = 3,
                            CategoriaId = 6,
                            Codigo = "6",
                            Descuento = 6,
                            EsDisponible = true,
                            ITBIS = 4,
                            Nombre = "Lubricante para rodamientos",
                            Precio = 240f,
                            ProveedorId = 6
                        },
                        new
                        {
                            ProductoId = 7,
                            Cantidad = 5,
                            CategoriaId = 7,
                            Codigo = "7",
                            Descuento = 6,
                            EsDisponible = true,
                            ITBIS = 4,
                            Nombre = "Filtro de aire",
                            Precio = 450f,
                            ProveedorId = 7
                        },
                        new
                        {
                            ProductoId = 8,
                            Cantidad = 6,
                            CategoriaId = 8,
                            Codigo = "8",
                            Descuento = 6,
                            EsDisponible = true,
                            ITBIS = 4,
                            Nombre = "Retén de doble labio",
                            Precio = 200f,
                            ProveedorId = 8
                        },
                        new
                        {
                            ProductoId = 9,
                            Cantidad = 3,
                            CategoriaId = 9,
                            Codigo = "9",
                            Descuento = 6,
                            EsDisponible = true,
                            ITBIS = 4,
                            Nombre = "Sello de vástago para cilindros neumáticos",
                            Precio = 240f,
                            ProveedorId = 9
                        },
                        new
                        {
                            ProductoId = 10,
                            Cantidad = 5,
                            CategoriaId = 10,
                            Codigo = "10",
                            Descuento = 6,
                            EsDisponible = true,
                            ITBIS = 4,
                            Nombre = "Sello de fibra de cerámica.",
                            Precio = 450f,
                            ProveedorId = 10
                        },
                        new
                        {
                            ProductoId = 11,
                            Cantidad = 2,
                            CategoriaId = 11,
                            Codigo = "11",
                            Descuento = 6,
                            EsDisponible = true,
                            ITBIS = 4,
                            Nombre = "Sello de válvula de globo",
                            Precio = 100f,
                            ProveedorId = 11
                        });
                });

            modelBuilder.Entity("Shared.Models.Proveedores", b =>
                {
                    b.Property<int>("ProveedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ProveedorId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ProveedorId");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("Shared.Models.Reparaciones", b =>
                {
                    b.Property<int>("ReparacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ReparacionId"));

                    b.Property<string>("ApellidoCliente")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ClienteId")
                        .HasColumnType("longtext");

                    b.Property<float>("Costo")
                        .HasColumnType("float");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Tecnico")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ReparacionId");

                    b.ToTable("Reparaciones");
                });

            modelBuilder.Entity("Shared.Models.ReparacionesDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DetalleId"));

                    b.Property<int>("CantidadUsada")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("ReparacionId")
                        .HasColumnType("int");

                    b.HasKey("DetalleId");

                    b.HasIndex("ReparacionId");

                    b.ToTable("ReparacionesDetalle");
                });

            modelBuilder.Entity("Shared.Models.Ventas", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("VentaId"));

                    b.Property<string>("ClienteId")
                        .HasColumnType("longtext");

                    b.Property<int>("CondicionId")
                        .HasColumnType("int");

                    b.Property<int>("ConfiguracionId")
                        .HasColumnType("int");

                    b.Property<float>("Devuelta")
                        .HasColumnType("float");

                    b.Property<bool>("Eliminada")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("ITBS")
                        .HasColumnType("float");

                    b.Property<int>("MetodoPagoId")
                        .HasColumnType("int");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Recibido")
                        .HasColumnType("float");

                    b.Property<int>("ReparacionId")
                        .HasColumnType("int");

                    b.Property<float>("SubTotal")
                        .HasColumnType("float");

                    b.Property<float>("Total")
                        .HasColumnType("float");

                    b.HasKey("VentaId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Shared.Models.VentasDetalle", b =>
                {
                    b.Property<int>("DetalleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DetalleID"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("DetalleID");

                    b.HasIndex("VentaId");

                    b.ToTable("VentasDetalle");
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
                    b.HasOne("HydraulicFix.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HydraulicFix.Data.ApplicationUser", null)
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

                    b.HasOne("HydraulicFix.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HydraulicFix.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.AbonosDetalle", b =>
                {
                    b.HasOne("Shared.Models.Abonos", null)
                        .WithMany("AbonoDetalle")
                        .HasForeignKey("AbonoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.ReparacionesDetalle", b =>
                {
                    b.HasOne("Shared.Models.Reparaciones", null)
                        .WithMany("ReparacionDetalle")
                        .HasForeignKey("ReparacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.VentasDetalle", b =>
                {
                    b.HasOne("Shared.Models.Ventas", null)
                        .WithMany("VentasDetalle")
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.Abonos", b =>
                {
                    b.Navigation("AbonoDetalle");
                });

            modelBuilder.Entity("Shared.Models.Reparaciones", b =>
                {
                    b.Navigation("ReparacionDetalle");
                });

            modelBuilder.Entity("Shared.Models.Ventas", b =>
                {
                    b.Navigation("VentasDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
