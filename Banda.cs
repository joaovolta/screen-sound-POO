class Banda 
{
    public string Nome { get; }
    private List<Album> Albuns = new List<Album> ();

    // Construtor
    public Banda(string nome) 
    {
        Nome = nome;
    }

    public void AdicionaAlbum(Album album) => Albuns.Add(album);

    public void ExibeDiscografia() 
    {
        Console.WriteLine("Discografia da banda " + Nome + ":");
        foreach(var album in Albuns) 
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal}s)");
        }

        Console.Write("\n");
    } 
}