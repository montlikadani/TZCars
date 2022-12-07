using System;

namespace TZCars {
    public sealed class Car {

        public int Id { get; private set; }
        public string Rendszam { get; private set; }
        public bool Forgalomba { get; private set; }
        public string Tulajdonos { get; private set; }
        public DateTime UtolsoMuszaki { get; private set; }
        public DateTime Evjarat { get; private set; }
        public string Marka { get; private set; }

        public Car(int id, string rendszam, bool forgalomba, string tulajdonos, DateTime utolsoMuszaki, DateTime evjarat, string marka) {
            Id = id;
            Rendszam = rendszam;
            Forgalomba = forgalomba;
            Tulajdonos = tulajdonos;
            UtolsoMuszaki = utolsoMuszaki;
            Evjarat = evjarat;
            Marka = marka;
        }
    }
}
