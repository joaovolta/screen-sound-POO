class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibeFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duracao: {duracao}");
        if(disponivel)
        {
            Console.WriteLine("Essa musica esta disponivel");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+ para disponibilizar essa musica");
        }
    }
}