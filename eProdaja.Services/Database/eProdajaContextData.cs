using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.Database
{
    partial class eProdajaContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Uloge>().HasData(new Uloge{ UlogaId = 1, Naziv = "Administrator", });
            modelBuilder.Entity<Uloge>().HasData(new Uloge { UlogaId = 2, Naziv = "Menadžer", });


            modelBuilder.Entity<Korisnici>().HasData(new Korisnici
            {
                KorisnikId = 1,
                Ime = "Test",
                Prezime = "Test",
                Email = "test@fit.ba",
                KorisnickoIme = "test",
                LozinkaHash = "7p3l25Cnbg+2QxoQRElFJjIqHgA=",
                LozinkaSalt = "H4pOSYtdeJgGsU/6HRTxqw==",
            });



            //u:admin p:admin
            modelBuilder.Entity<Korisnici>().HasData(new Korisnici
            {
                KorisnikId = 2,
                Ime = "Administrator",
                Prezime = "Administrator",
                Email = "admin@fit.ba",
                KorisnickoIme = "admin",
                LozinkaHash = "JfJzsL3ngGWki+Dn67C+8WLy73I=",
                LozinkaSalt = "7TUJfmgkkDvcY3PB/M4fhg==",
            });

            modelBuilder.Entity<KorisniciUloge>().HasData(new KorisniciUloge() { KorisnikUlogaId = 1, KorisnikId = 1, UlogaId = 1, DatumIzmjene = DateTime.Today });
            modelBuilder.Entity<KorisniciUloge>().HasData(new KorisniciUloge() { KorisnikUlogaId = 2, KorisnikId = 2, UlogaId = 1, DatumIzmjene = DateTime.Today });


            modelBuilder.Entity<VrsteProizvodum>().HasData(new VrsteProizvodum {  VrstaId = 1, Naziv = "PC" });
            modelBuilder.Entity<VrsteProizvodum>().HasData(new VrsteProizvodum { VrstaId = 2, Naziv = "Laptop" });
            modelBuilder.Entity<VrsteProizvodum>().HasData(new VrsteProizvodum { VrstaId = 3, Naziv = "Monitor" });

            modelBuilder.Entity<JediniceMjere>().HasData(new JediniceMjere { JedinicaMjereId = 1, Naziv = "kom" });
            modelBuilder.Entity<JediniceMjere>().HasData(new JediniceMjere { JedinicaMjereId = 2, Naziv = "kg" });

            modelBuilder.Entity<Proizvodi>().HasData(new Proizvodi { ProizvodId = 1, Naziv = "Dell Inspiron 3477", Sifra = "P001", Cijena = 100, VrstaId = 1, JedinicaMjereId = 1, Status = true, StateMachine = "draft"});

            modelBuilder.Entity<Proizvodi>().HasData(new Proizvodi { ProizvodId = 2, Naziv = "Dell Inspiron 5475", Sifra = "P002", Cijena = 120, VrstaId = 1, JedinicaMjereId = 1, Status = true, StateMachine = "draft" });

            modelBuilder.Entity<Proizvodi>().HasData(new Proizvodi { ProizvodId = 3, Naziv = "HP Pavilion 22-b001ny", Sifra = "P003", Cijena = 1201, VrstaId = 2, JedinicaMjereId = 1, Status = true, StateMachine = "draft" });


            modelBuilder.Entity<Kupci>().HasData(new Kupci { KupacId = 1, Ime = "KupacJedan", Prezime = "KupacJedan", DatumRegistracije = DateTime.Now, Email = "KupacJedan@gmail.com", Status = true, KorisnickoIme = "KupacJedan", LozinkaHash = "", LozinkaSalt = "" });
            modelBuilder.Entity<Kupci>().HasData(new Kupci { KupacId = 2, Ime = "KupacDva", Prezime = "KupacDva", DatumRegistracije = DateTime.Now, Email = "KupacDva@gmail.com", Status = true, KorisnickoIme = "KupacDva", LozinkaHash = "", LozinkaSalt = "" });
            modelBuilder.Entity<Kupci>().HasData(new Kupci { KupacId = 3, Ime = "KupacTri", Prezime = "KupacTri", DatumRegistracije = DateTime.Now, Email = "KupacTri@gmail.com", Status = true, KorisnickoIme = "KupacTri", LozinkaHash = "", LozinkaSalt = "" });
            modelBuilder.Entity<Kupci>().HasData(new Kupci { KupacId = 4, Ime = "KupacCetri", Prezime = "KupacCetri", DatumRegistracije = DateTime.Now, Email = "KupacCetri@gmail.com", Status = true, KorisnickoIme = "KupacCetri", LozinkaHash = "", LozinkaSalt = "" });

            modelBuilder.Entity<Narudzbe>().HasData(new Narudzbe { NarudzbaId=1, KupacId = 1, Datum = DateTime.Now, BrojNarudzbe= "1",Otkazano=false,Status=true});
            modelBuilder.Entity<Narudzbe>().HasData(new Narudzbe { NarudzbaId = 2, KupacId = 1, Datum = DateTime.Now, BrojNarudzbe = "2", Otkazano = false, Status = true });
            modelBuilder.Entity<Narudzbe>().HasData(new Narudzbe { NarudzbaId = 3, KupacId = 2, Datum = DateTime.Now, BrojNarudzbe = "3", Otkazano = false, Status = true });
            modelBuilder.Entity<Narudzbe>().HasData(new Narudzbe { NarudzbaId = 4, KupacId = 3, Datum = DateTime.Now, BrojNarudzbe = "4", Otkazano = false, Status = true });

            modelBuilder.Entity<NarudzbaStavke>().HasData(new NarudzbaStavke { NarudzbaStavkaId = 1, ProizvodId = 1, NarudzbaId = 1, Kolicina = 4 });
            modelBuilder.Entity<NarudzbaStavke>().HasData(new NarudzbaStavke { NarudzbaStavkaId = 2, ProizvodId = 1, NarudzbaId = 3, Kolicina = 12 });
            modelBuilder.Entity<NarudzbaStavke>().HasData(new NarudzbaStavke { NarudzbaStavkaId = 3, ProizvodId = 2, NarudzbaId = 2, Kolicina = 7 });
            modelBuilder.Entity<NarudzbaStavke>().HasData(new NarudzbaStavke { NarudzbaStavkaId = 4, ProizvodId = 3, NarudzbaId = 4, Kolicina = 3 });


        }
    }
}
