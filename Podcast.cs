using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Podcast
{
    private List<Episodio> lstEpisodios = new List<Episodio>();

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => lstEpisodios.Count();

    public void AdicionaEpisodio(Episodio episodio) => lstEpisodios.Add(episodio);

    public void ExibeDetalhes()
    {
        Console.WriteLine($"Episodios do podcast {Nome}: ");
        foreach (var episodio in lstEpisodios)
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine("\nTotal de episodios: " + TotalEpisodios);
    }
}