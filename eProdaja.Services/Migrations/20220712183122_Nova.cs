using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eProdaja.Services.Migrations
{
    public partial class Nova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dobavljaci",
                columns: table => new
                {
                    DobavljacID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KontaktOsoba = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Web = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ZiroRacuni = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Napomena = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dobavljaci", x => x.DobavljacID);
                });

            migrationBuilder.CreateTable(
                name: "JediniceMjere",
                columns: table => new
                {
                    JedinicaMjereID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JediniceMjere", x => x.JedinicaMjereID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikID);
                });

            migrationBuilder.CreateTable(
                name: "Kupci",
                columns: table => new
                {
                    KupacID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DatumRegistracije = table.Column<DateTime>(type: "datetime", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupci", x => x.KupacID);
                });

            migrationBuilder.CreateTable(
                name: "Skladista",
                columns: table => new
                {
                    SkladisteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skladista", x => x.SkladisteID);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaID);
                });

            migrationBuilder.CreateTable(
                name: "VrsteProizvoda",
                columns: table => new
                {
                    VrstaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrsteProizvoda", x => x.VrstaID);
                });

            migrationBuilder.CreateTable(
                name: "Narudzbe",
                columns: table => new
                {
                    NarudzbaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojNarudzbe = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    KupacID = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Otkazano = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzbe", x => x.NarudzbaID);
                    table.ForeignKey(
                        name: "FK_Narudzbe_Kupci",
                        column: x => x.KupacID,
                        principalTable: "Kupci",
                        principalColumn: "KupacID");
                });

            migrationBuilder.CreateTable(
                name: "Ulazi",
                columns: table => new
                {
                    UlazID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojFakture = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    IznosRacuna = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PDV = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SkladisteID = table.Column<int>(type: "int", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    DobavljacID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulazi", x => x.UlazID);
                    table.ForeignKey(
                        name: "FK_Ulazi_Dobavljaci",
                        column: x => x.DobavljacID,
                        principalTable: "Dobavljaci",
                        principalColumn: "DobavljacID");
                    table.ForeignKey(
                        name: "FK_Ulazi_Korisnici",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID");
                    table.ForeignKey(
                        name: "FK_Ulazi_Skladista",
                        column: x => x.SkladisteID,
                        principalTable: "Skladista",
                        principalColumn: "SkladisteID");
                });

            migrationBuilder.CreateTable(
                name: "KorisniciUloge",
                columns: table => new
                {
                    KorisnikUlogaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    UlogaID = table.Column<int>(type: "int", nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciUloge", x => x.KorisnikUlogaID);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Korisnici",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID");
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Uloge",
                        column: x => x.UlogaID,
                        principalTable: "Uloge",
                        principalColumn: "UlogaID");
                });

            migrationBuilder.CreateTable(
                name: "Proizvodi",
                columns: table => new
                {
                    ProizvodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifra = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VrstaID = table.Column<int>(type: "int", nullable: false),
                    JedinicaMjereID = table.Column<int>(type: "int", nullable: false),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SlikaThumb = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    StateMachine = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodi", x => x.ProizvodID);
                    table.ForeignKey(
                        name: "FK_Proizvodi_JediniceMjere",
                        column: x => x.JedinicaMjereID,
                        principalTable: "JediniceMjere",
                        principalColumn: "JedinicaMjereID");
                    table.ForeignKey(
                        name: "FK_Proizvodi_VrsteProizvoda",
                        column: x => x.VrstaID,
                        principalTable: "VrsteProizvoda",
                        principalColumn: "VrstaID");
                });

            migrationBuilder.CreateTable(
                name: "Izlazi",
                columns: table => new
                {
                    IzlazID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojRacuna = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    Zakljucen = table.Column<bool>(type: "bit", nullable: false),
                    IznosBezPDV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IznosSaPDV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NarudzbaID = table.Column<int>(type: "int", nullable: true),
                    SkladisteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izlazi", x => x.IzlazID);
                    table.ForeignKey(
                        name: "FK_Izlazi_Korisnici",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID");
                    table.ForeignKey(
                        name: "FK_Izlazi_Narudzbe",
                        column: x => x.NarudzbaID,
                        principalTable: "Narudzbe",
                        principalColumn: "NarudzbaID");
                    table.ForeignKey(
                        name: "FK_Izlazi_Skladista",
                        column: x => x.SkladisteID,
                        principalTable: "Skladista",
                        principalColumn: "SkladisteID");
                });

            migrationBuilder.CreateTable(
                name: "Ispit30062022",
                columns: table => new
                {
                    Ispit30062022Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodiId = table.Column<int>(type: "int", nullable: false),
                    KupciId = table.Column<int>(type: "int", nullable: false),
                    MinimalniIznosNarudzbe = table.Column<int>(type: "int", nullable: false),
                    BrojNarudzbe = table.Column<int>(type: "int", nullable: false),
                    IznosNarudzbe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ispit30062022", x => x.Ispit30062022Id);
                    table.ForeignKey(
                        name: "FK_Ispit30062022_Kupci_KupciId",
                        column: x => x.KupciId,
                        principalTable: "Kupci",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ispit30062022_Proizvodi_ProizvodiId",
                        column: x => x.ProizvodiId,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NarudzbaStavke",
                columns: table => new
                {
                    NarudzbaStavkaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NarudzbaID = table.Column<int>(type: "int", nullable: false),
                    ProizvodID = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarudzbaStavke", x => x.NarudzbaStavkaID);
                    table.ForeignKey(
                        name: "FK_NarudzbaStavke_Narudzbe",
                        column: x => x.NarudzbaID,
                        principalTable: "Narudzbe",
                        principalColumn: "NarudzbaID");
                    table.ForeignKey(
                        name: "FK_NarudzbaStavke_Proizvodi",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodID");
                });

            migrationBuilder.CreateTable(
                name: "Ocjene",
                columns: table => new
                {
                    OcjenaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodID = table.Column<int>(type: "int", nullable: false),
                    KupacID = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ocjena = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjene", x => x.OcjenaID);
                    table.ForeignKey(
                        name: "FK_Ocjene_Kupci",
                        column: x => x.KupacID,
                        principalTable: "Kupci",
                        principalColumn: "KupacID");
                    table.ForeignKey(
                        name: "FK_Ocjene_Proizvodi",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodID");
                });

            migrationBuilder.CreateTable(
                name: "UlazStavke",
                columns: table => new
                {
                    UlazStavkaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlazID = table.Column<int>(type: "int", nullable: false),
                    ProizvodID = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UlazStavke", x => x.UlazStavkaID);
                    table.ForeignKey(
                        name: "FK_UlazStavke_Proizvodi",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodID");
                    table.ForeignKey(
                        name: "FK_UlazStavke_Ulazi",
                        column: x => x.UlazID,
                        principalTable: "Ulazi",
                        principalColumn: "UlazID");
                });

            migrationBuilder.CreateTable(
                name: "IzlazStavke",
                columns: table => new
                {
                    IzlazStavkaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IzlazID = table.Column<int>(type: "int", nullable: false),
                    ProizvodID = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Popust = table.Column<decimal>(type: "decimal(5,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IzlazStavke", x => x.IzlazStavkaID);
                    table.ForeignKey(
                        name: "FK_IzlazStavke_Izlazi",
                        column: x => x.IzlazID,
                        principalTable: "Izlazi",
                        principalColumn: "IzlazID");
                    table.ForeignKey(
                        name: "FK_IzlazStavke_Proizvodi",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodID");
                });

            migrationBuilder.InsertData(
                table: "JediniceMjere",
                columns: new[] { "JedinicaMjereID", "Naziv" },
                values: new object[,]
                {
                    { 1, "kom" },
                    { 2, "kg" }
                });

            migrationBuilder.InsertData(
                table: "Korisnici",
                columns: new[] { "KorisnikID", "Email", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "Telefon" },
                values: new object[,]
                {
                    { 1, "test@fit.ba", "Test", "test", "7p3l25Cnbg+2QxoQRElFJjIqHgA=", "H4pOSYtdeJgGsU/6HRTxqw==", "Test", null },
                    { 2, "admin@fit.ba", "Administrator", "admin", "JfJzsL3ngGWki+Dn67C+8WLy73I=", "7TUJfmgkkDvcY3PB/M4fhg==", "Administrator", null }
                });

            migrationBuilder.InsertData(
                table: "Kupci",
                columns: new[] { "KupacID", "DatumRegistracije", "Email", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 12, 20, 31, 22, 160, DateTimeKind.Local).AddTicks(5248), "KupacJedan@gmail.com", "KupacJedan", "KupacJedan", "", "", "KupacJedan", true },
                    { 2, new DateTime(2022, 7, 12, 20, 31, 22, 160, DateTimeKind.Local).AddTicks(5262), "KupacDva@gmail.com", "KupacDva", "KupacDva", "", "", "KupacDva", true },
                    { 3, new DateTime(2022, 7, 12, 20, 31, 22, 160, DateTimeKind.Local).AddTicks(5272), "KupacTri@gmail.com", "KupacTri", "KupacTri", "", "", "KupacTri", true },
                    { 4, new DateTime(2022, 7, 12, 20, 31, 22, 160, DateTimeKind.Local).AddTicks(5283), "KupacCetri@gmail.com", "KupacCetri", "KupacCetri", "", "", "KupacCetri", true }
                });

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "UlogaID", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 1, "Administrator", null },
                    { 2, "Menadžer", null }
                });

            migrationBuilder.InsertData(
                table: "VrsteProizvoda",
                columns: new[] { "VrstaID", "Naziv" },
                values: new object[,]
                {
                    { 1, "PC" },
                    { 2, "Laptop" },
                    { 3, "Monitor" }
                });

            migrationBuilder.InsertData(
                table: "KorisniciUloge",
                columns: new[] { "KorisnikUlogaID", "DatumIzmjene", "KorisnikID", "UlogaID" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, 1 },
                    { 2, new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Narudzbe",
                columns: new[] { "NarudzbaID", "BrojNarudzbe", "Datum", "KupacID", "Otkazano", "Status" },
                values: new object[,]
                {
                    { 1, "1", new DateTime(2022, 7, 12, 20, 31, 22, 160, DateTimeKind.Local).AddTicks(5300), 1, false, true },
                    { 2, "2", new DateTime(2022, 7, 12, 20, 31, 22, 160, DateTimeKind.Local).AddTicks(5313), 1, false, true },
                    { 3, "3", new DateTime(2022, 7, 12, 20, 31, 22, 160, DateTimeKind.Local).AddTicks(5324), 2, false, true },
                    { 4, "4", new DateTime(2022, 7, 12, 20, 31, 22, 160, DateTimeKind.Local).AddTicks(5335), 3, false, true }
                });

            migrationBuilder.InsertData(
                table: "Proizvodi",
                columns: new[] { "ProizvodID", "Cijena", "JedinicaMjereID", "Naziv", "Sifra", "Slika", "SlikaThumb", "StateMachine", "Status", "VrstaID" },
                values: new object[,]
                {
                    { 1, 100m, 1, "Dell Inspiron 3477", "P001", null, null, "draft", true, 1 },
                    { 2, 120m, 1, "Dell Inspiron 5475", "P002", null, null, "draft", true, 1 },
                    { 3, 1201m, 1, "HP Pavilion 22-b001ny", "P003", null, null, "draft", true, 2 }
                });

            migrationBuilder.InsertData(
                table: "NarudzbaStavke",
                columns: new[] { "NarudzbaStavkaID", "Kolicina", "NarudzbaID", "ProizvodID" },
                values: new object[,]
                {
                    { 1, 4, 1, 1 },
                    { 2, 12, 3, 1 },
                    { 3, 7, 2, 2 },
                    { 4, 3, 4, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ispit30062022_KupciId",
                table: "Ispit30062022",
                column: "KupciId");

            migrationBuilder.CreateIndex(
                name: "IX_Ispit30062022_ProizvodiId",
                table: "Ispit30062022",
                column: "ProizvodiId");

            migrationBuilder.CreateIndex(
                name: "IX_Izlazi_KorisnikID",
                table: "Izlazi",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Izlazi_NarudzbaID",
                table: "Izlazi",
                column: "NarudzbaID");

            migrationBuilder.CreateIndex(
                name: "IX_Izlazi_SkladisteID",
                table: "Izlazi",
                column: "SkladisteID");

            migrationBuilder.CreateIndex(
                name: "IX_IzlazStavke_IzlazID",
                table: "IzlazStavke",
                column: "IzlazID");

            migrationBuilder.CreateIndex(
                name: "IX_IzlazStavke_ProizvodID",
                table: "IzlazStavke",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "CS_Email",
                table: "Korisnici",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "CS_KorisnickoIme",
                table: "Korisnici",
                column: "KorisnickoIme",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnikID",
                table: "KorisniciUloge",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_UlogaID",
                table: "KorisniciUloge",
                column: "UlogaID");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavke_NarudzbaID",
                table: "NarudzbaStavke",
                column: "NarudzbaID");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavke_ProizvodID",
                table: "NarudzbaStavke",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzbe_KupacID",
                table: "Narudzbe",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_KupacID",
                table: "Ocjene",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_ProizvodID",
                table: "Ocjene",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvodi_JedinicaMjereID",
                table: "Proizvodi",
                column: "JedinicaMjereID");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvodi_VrstaID",
                table: "Proizvodi",
                column: "VrstaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ulazi_DobavljacID",
                table: "Ulazi",
                column: "DobavljacID");

            migrationBuilder.CreateIndex(
                name: "IX_Ulazi_KorisnikID",
                table: "Ulazi",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Ulazi_SkladisteID",
                table: "Ulazi",
                column: "SkladisteID");

            migrationBuilder.CreateIndex(
                name: "IX_UlazStavke_ProizvodID",
                table: "UlazStavke",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_UlazStavke_UlazID",
                table: "UlazStavke",
                column: "UlazID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ispit30062022");

            migrationBuilder.DropTable(
                name: "IzlazStavke");

            migrationBuilder.DropTable(
                name: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "NarudzbaStavke");

            migrationBuilder.DropTable(
                name: "Ocjene");

            migrationBuilder.DropTable(
                name: "UlazStavke");

            migrationBuilder.DropTable(
                name: "Izlazi");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Proizvodi");

            migrationBuilder.DropTable(
                name: "Ulazi");

            migrationBuilder.DropTable(
                name: "Narudzbe");

            migrationBuilder.DropTable(
                name: "JediniceMjere");

            migrationBuilder.DropTable(
                name: "VrsteProizvoda");

            migrationBuilder.DropTable(
                name: "Dobavljaci");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Skladista");

            migrationBuilder.DropTable(
                name: "Kupci");
        }
    }
}
