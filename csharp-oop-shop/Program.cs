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
            return ran.Next(1, 10000000);
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

        /*-------------------------------------
        Metodo per aggiungere il pad a sinistra
        --------------------------------------*/
        public string CodicePadLeft()
        {
            return Codice.ToString().PadLeft(8, '0' );
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {

            /*------------------------------------
            Istanzio un prodotto e provo i metodi
            -------------------------------------*/
            Prodotto prodotto1 = new Prodotto("Libro Povere Creature", "Romanzo distopico da cui tratto il film", 15, 22);

            Console.WriteLine($"Codice prodotto: {prodotto1.Codice}");
            Console.WriteLine($"Nome prodotto: {prodotto1.Nome}");
            Console.WriteLine($"Descrizione prodotto: {prodotto1.Descrizione}");
            Console.WriteLine($"Il prezzo del prodotto non ivato è {prodotto1.CalcolaPrezzoBase()} euro");
            Console.WriteLine($"L'IVA sul prodotto è {prodotto1.IVA}%");
            Console.WriteLine($"Il prodotto con prezzo ivato è {prodotto1.CalcolaPrezzoConIVA()} euro");
            Console.WriteLine($"Nome esteso: {prodotto1.NomeEsteso()}");
            Console.WriteLine($"Codice con padding: {prodotto1.CodicePadLeft()}");

            prodotto1.Nome = "Novel Poor Things";
            prodotto1.Prezzo = 10;
            prodotto1.Descrizione = "Distopic novel";
            prodotto1.IVA = 20;

            Console.WriteLine($"Codice prodotto: {prodotto1.Codice}");
            Console.WriteLine($"Nome prodotto modificato: {prodotto1.Nome}");
            Console.WriteLine($"Descrizione prodotto modificata: {prodotto1.Descrizione}");
            Console.WriteLine($"Il prezzo modificato del prodotto non ivato è {prodotto1.CalcolaPrezzoBase()} euro");
            Console.WriteLine($"L'IVA modificata sul prodotto è {prodotto1.IVA}%");
            Console.WriteLine($"Il prodotto con prezzo ivato è {prodotto1.CalcolaPrezzoConIVA()} euro");
            Console.WriteLine($"Nome esteso: {prodotto1.NomeEsteso()}");

            /*----------------------------------------
             Creazione di un Array di Oggetti Prodotto
             ----------------------------------------*/

            Prodotto[] amazozz = new Prodotto[4];

            amazozz[0] = new Prodotto("Nokia Lumia 920", "Windows Phone", 599, 22);
            amazozz[1] = new Prodotto("Samsung Galaxy S23", "Android Phone", 599, 22);
            amazozz[2] = new Prodotto("Apple iPhone 15", "Apple Phone", 1400, 22);
            amazozz[3] = new Prodotto("Sony PlayStation 5", "Ultima Console di Sony", 449, 22);

            Console.WriteLine("Elenco dei prodotti in amazozz:");

            foreach (Prodotto prodotto in amazozz)
            {
                Console.WriteLine($"Codice: {prodotto.CodicePadLeft()}, Nome: {prodotto.Nome}, Prezzo senza IVA: {prodotto.CalcolaPrezzoBase()} euro");
                Console.WriteLine($"Descrizione prodotto: {prodotto.Descrizione}");
                Console.WriteLine($"Prezzo con IVA: {prodotto.CalcolaPrezzoConIVA()} euro");
            }
        }
    }
}
