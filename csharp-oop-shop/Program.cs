namespace csharp_oop_shop
{
    public class Prodotto
    {
        public int Codice { get; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public double IVA { get; set; }

        public Prodotto(string nome, string descrizione, double prezzo, double iva)
        {
            Codice = GeneraCodice();
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            IVA = iva;
        }

        private static int GeneraCodice()
        {
            Random ran = new Random();
            return ran.Next(1000, 10000);
        }
        public double CalcolaPrezzoBase()
        {
            return Prezzo;
        }

        public double CalcolaPrezzoConIVA()
        {
            return Prezzo + (Prezzo * (IVA / 100));
        }

        public string NomeEsteso()
        {
            return $"{Codice} {Nome}";
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto prodotto1 = new Prodotto("Libro Povere Creature", "Romanzo distopico da cui tratto il film", 15, 22);

            Console.WriteLine($"Codice prodotto: {prodotto1.Codice}");
            Console.WriteLine($"Nome prodotto: {prodotto1.Nome}");
            Console.WriteLine($"Descrizione prodotto: {prodotto1.Descrizione}");
            Console.WriteLine($"Il prezzo del prodotto non ivato è {prodotto1.Prezzo} euro");
            Console.WriteLine($"L'IVA sul prodotto è {prodotto1.IVA}%");
            Console.WriteLine($"Il prodotto con prezzo ivato è {prodotto1.CalcolaPrezzoConIVA()} euro");
            Console.WriteLine($"Nome esteso: {prodotto1.NomeEsteso()}");

            prodotto1.Nome = "Novel Poor Things";
            prodotto1.Prezzo = 10;
            prodotto1.Descrizione = "Distopic novel";
            prodotto1.IVA = 20;

            Console.WriteLine($"Codice prodotto: {prodotto1.Codice}");
            Console.WriteLine($"Nome prodotto modificato: {prodotto1.Nome}");
            Console.WriteLine($"Descrizione prodotto modificata: {prodotto1.Descrizione}");
            Console.WriteLine($"Il prezzo modificato del prodotto non ivato è {prodotto1.Prezzo} euro");
            Console.WriteLine($"L'IVA modificata sul prodotto è {prodotto1.IVA}%");
            Console.WriteLine($"Il prodotto con prezzo ivato è {prodotto1.CalcolaPrezzoConIVA()} euro");
            Console.WriteLine($"Nome esteso: {prodotto1.NomeEsteso()}");

        }
    }
}
