
class Musica
{
    public string Nome {get; set; }
    public string Artista {get; set;}
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
    Console.WriteLine($"Artista: {Artista}");
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