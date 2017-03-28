using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;


namespace Zad_3._3.Tests
{
    [TestFixture]
    public class DziennikTests
    {
        [Test]
        public void ZmienObecnosc_BoolValue_Updated()
        {
            var przedmiot = new Przedmiot("Programowanie");
            var obecnosc1 = new Obecnosc(true, przedmiot);
            obecnosc1.ZmienObecnosc(false);
            Assert.AreEqual(false, obecnosc1.obecny);
        }

        [Test]
        public void ZmienOcene_DoubleValueInRange_Updated()
        {
            var przedmiot = new Przedmiot("Programowanie");
            var ocena = new Ocena(5.0, przedmiot);
            ocena.Zmien(2.0);
            Assert.AreEqual(2.0, ocena.wartosc);
        }

        [Test]
        public void ZmienOcene_DoubleValueOutOfRange_NotUpdated()
        {
            var przedmiot = new Przedmiot("Programowanie");
            var ocena = new Ocena(4.0, przedmiot);
            ocena.Zmien(8.0);
            Assert.AreEqual(4.0, ocena.wartosc);
        }

        [Test]
        public void DodajOcene_DoubleValueInRange_Updated()
        {
            var przedmiot = new Przedmiot("Programowanie");
            var ocena = new Ocena(6.0, przedmiot);
            var uczen = new Uczen("Jan", "Kowalski");
            uczen.Dodaj(ocena);
            Assert.IsTrue(uczen.Oceny.Contains(ocena));
        }

        [Test]
        public void DodajOcene_DoubleValueOutOfRange_NotUpdated()
        {
            var przedmiot = new Przedmiot("Programowanie");
            var ocena = new Ocena(9.0, przedmiot);
            var uczen = new Uczen("Jan", "Kowalski");
            uczen.Dodaj(ocena);
            Assert.IsTrue(!uczen.Oceny.Contains(ocena));
        }

        [Test]
        public void ObliczSrednia_CalculateGrades_Calculated()
        {
            var przedmiot = new Przedmiot("Programowanie");
            var ocena1 = new Ocena(1.0, przedmiot);
            przedmiot = new Przedmiot("Bazy danych");
            var ocena2 = new Ocena(2.0, przedmiot);
            przedmiot = new Przedmiot("Systemy rozproszone");
            var ocena3 = new Ocena(4.0, przedmiot);
            przedmiot = new Przedmiot("Prawo pracy");
            var ocena4 = new Ocena(5.0, przedmiot);
            var uczen = new Uczen("Jan", "Kowalski");
            uczen.Dodaj(ocena1);
            uczen.Dodaj(ocena2);
            uczen.Dodaj(ocena3);
            uczen.Dodaj(ocena4);
            Assert.AreEqual(3.0, uczen.Srednia());
        }

        [Test]
        public void EdytujNazwe_ValidString_Updated()
        {
            var przedmiot = new Przedmiot("Programowanie");
            przedmiot.Edytuj("Bazy danych");
            Assert.AreEqual("Bazy danych", przedmiot.name);
        }

        [Test]
        public void EdytujNazwe_EmptyString_NotUpdated()
        {
            var przedmiot = new Przedmiot("Programowanie");
            przedmiot.Edytuj("");
            Assert.AreEqual("Programowanie", przedmiot.name);
        }


    }
}
