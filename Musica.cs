class Musica
{
    public string Nome { get; } 
    public Banda Artista { get; }
    public int Duracao { get; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; }
    // A variavel utiliza =>, oque indica que a variavel esta somente para leitura (get)
    public string DescricaoResumida => $"A musica {Nome} pertence a banda/artista {Artista}";

    // Construtor
    public Musica(Banda artista, string nome, int duracao, Genero genero)
    {
        Artista = artista;
        Nome = nome;
        Duracao = duracao;
        Genero = genero;
    }

    public void ExibeFichaTecnica()
    {
        Console.WriteLine("Ficha tecnica da musica: ");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duracao: {Duracao}");
        Console.WriteLine($"Genero: {Genero.Nome}");

        if(Disponivel)
        {
            Console.WriteLine("Essa musica esta disponivel");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+ para disponibilizar essa musica");
        }

        Console.Write("\n");
    }
}