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



