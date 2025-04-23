using System.Collections.Generic;
using System.Globalization;

class Episodio
{
    List<string> lstConvidados = new List<string>();
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $"{Ordem} - {Titulo} ({Duracao}s) - {string.Join(", ", lstConvidados)}";
    public string Titulo { get; }

    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    public void AdicionaConvidado(string convidado) => lstConvidados.Add(convidado);
}