
/*Musica musica1 = new Musica();
musica1.Nome = "Roxanne";
musica1.Artista = "The Police";
musica1.Duracao = 275;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

musica1.ExibirFichaTecnica();
Console.WriteLine(musica1.DescricaoResumida);*/

//criando um Album novo, ou seja instanciando um objeto da Classe Album:
Album albumDoLimaoComMel = new Album();
albumDoLimaoComMel.Nome = "Só Antigas";

Musica musica1 = new Musica();
musica1.Nome = "Toma Conta de Mim";
musica1.Duracao = 213;
Musica musica2 = new Musica();
musica2.Nome = "Anjo Querubim";
musica2.Duracao = 345;

albumDoLimaoComMel.AdiconarMusica(musica1);
albumDoLimaoComMel.AdiconarMusica(musica2);

albumDoLimaoComMel.ExibirMusicasDoAlbum();

