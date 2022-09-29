namespace csharp_biblioteca
{
    internal class Book : Product
    {
        public int NumPage { get; set; }

        public Book(string code, string title, DateOnly releasedate, DateOnly editionDate, int quantity, string sector, int numPage) : base(code, title, releasedate, editionDate, quantity, sector)
        {
            NumPage = numPage;
        }

        public override string? ToString()
        {
            return String.Format("| Codice: {0} \t| Titolo: {1,30} \t| Pagine: {6} \t| Autore: {2,30} \t| Anno: {3} \t| Posizione: {4,10} \t| Quantita: {5}", Code, Title, ReleaseDate, Sector, Quantity, NumPage);
        }


    }
}
