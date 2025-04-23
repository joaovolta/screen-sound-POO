Banda queen = new Banda("Queen");
Album albumDoQueen = new Album("A night at the opera");
Musica musica1 = new Musica(queen, "Love of my life", 213, new Genero("Rock")) 
{
    Disponivel = true,
};
Musica musica2 = new Musica(queen, "Another one bites the dust", 312, new Genero("Rock")) 
{
    Disponivel = false,
};

queen.AdicionaAlbum(albumDoQueen);
albumDoQueen.AdicionaMusica(musica1);
albumDoQueen.AdicionaMusica(musica2);

queen.ExibeDiscografia();

albumDoQueen.ExibeMusicasDoAlbum();

musica1.ExibeFichaTecnica();
musica2.ExibeFichaTecnica();

///////////////////////////////////////////////////////////////// 

Podcast podpah = new Podcast("Twitch", "Podpah");
Episodio ep1 = new Episodio(1022, 1, "Entrevista com MC IG");
Episodio ep2 = new Episodio(3000, 2, "Entrevista com Max Verstappen");
ep1.AdicionaConvidado("MC IG");
ep2.AdicionaConvidado("MAX VERSTAPPEN");
ep2.AdicionaConvidado("RUSSEL");

podpah.AdicionaEpisodio(ep1);
podpah.AdicionaEpisodio(ep2);
podpah.ExibeDetalhes();
Thread.Sleep(100000);