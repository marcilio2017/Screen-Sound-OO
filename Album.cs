class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);// fazendo a soma da duração das músicas pelo lambda mas poderia ser por uma função normal.

    public void AdiconarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine("Musicas do álbum:");
        foreach (var musica in musicas)
        {
           Console.WriteLine(musica.Nome);
        }
        Console.WriteLine($"O álbum tem um tempo de {DuracaoTotal} segundos.");
    }
}