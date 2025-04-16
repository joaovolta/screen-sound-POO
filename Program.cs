Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";

Musica musica2 = new Musica();
musica2.Nome = "Another one bites the dust";

albumDoQueen.AdicionaMusica(musica1);
albumDoQueen.AdicionaMusica(musica2);

albumDoQueen.ExibeMusicasDoAlbum();