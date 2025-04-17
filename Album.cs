class Album
{
    // Criando uma lista de musicas e inicializando ela como vazia
    private List<Musica> lstMusicas = new List<Musica>();
    public string Nome { get; }
    public int DuracaoTotal => lstMusicas.Sum(m => m.Duracao);
    // public int DuracaoTotal 
    // {
    //     get 
    //     {
    //         int total = 0;
    //         foreach (var musica in lstMusicas)
    //             total += musica.Duracao;
    //         return total;
    //     }
    // }

    // Construtor
    public Album(string nome) 
    {
        Nome = nome;
    }
    
    public void AdicionaMusica(Musica musica)
    {
        lstMusicas.Add(musica);
    }

    public void ExibeMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de musicas do album: {Nome}\n");
        foreach(Musica musica in lstMusicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir esse album inteiro e preciso de {DuracaoTotal} segundos\n");
    }
}