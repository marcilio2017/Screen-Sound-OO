
class Musica
{

    //construtor para obrigar a uma música sempre ter uma banda
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome {get;  }
    public Banda Artista {get; }
    public int Duracao {get; set;}
    public bool Disponivel { get; set; }
    //public string Descricao { get; } //propTab já cria a propriedade//não terá a escrita.

    public string DescricaoResumida => $"A música {Nome} pertence a {Artista}"; //=> lambda


/*public void EscreveDisponivel(bool value)
{
    disponivel = value;
}
public bool LerDisponivel()
{
    return disponivel;
}
*/

public void ExibirFichaTecnica()
{
    Console.WriteLine($"Nome: {Nome}");
    Console.WriteLine($"Artista: {Artista.Nome}");
    Console.WriteLine($"Duração: {Duracao}");

    if (Disponivel)
    {
        Console.WriteLine("Disponível no plano.");
    }
    else
    {
        Console.WriteLine("Adquira o plano Plus+");
    }
}
}