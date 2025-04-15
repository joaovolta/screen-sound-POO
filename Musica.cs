class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    // A variavel utiliza =>, oque indica que a variavel esta somente para leitura (get)
    public string DescricaoResumida => $"A musica {Nome} pertence a banda/artista {Artista}";

    public void ExibeFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duracao: {Duracao}");
        if(Disponivel)
        {
            Console.WriteLine("Essa musica esta disponivel");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+ para disponibilizar essa musica");
        }
    }
}