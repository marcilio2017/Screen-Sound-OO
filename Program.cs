
/*Musica musica1 = new Musica();
musica1.Nome = "Roxanne";
musica1.Artista = "The Police";
musica1.Duracao = 275;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

musica1.ExibirFichaTecnica();
Console.WriteLine(musica1.DescricaoResumida);*/

//criando um Album novo, ou seja instanciando um objeto da Classe Album:
Banda limaoComMel = new Banda("limaoComMel");
//limaoComMel.Nome = "aguardando"; mudou após o construtor

Album albumDoLimaoComMel = new Album("Só Antigas");
//albumDoLimaoComMel.Nome = "Só Antigas";

Musica musica1 = new Musica(limaoComMel, "Toma Conta de Mim")
{
    Duracao = 213,
    Disponivel = true
};
//musica1.Nome = "Toma Conta de Mim";

Musica musica2 = new Musica(limaoComMel, "Anjo Querubim")
{

    Duracao = 345,
    Disponivel = false
};
//musica2.Nome = "Anjo Querubim";


albumDoLimaoComMel.AdiconarMusica(musica1);
albumDoLimaoComMel.AdiconarMusica(musica2);

albumDoLimaoComMel.ExibirMusicasDoAlbum();
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();


limaoComMel.AdicionarAlbum(albumDoLimaoComMel);
limaoComMel.ExibirDiscografia();



