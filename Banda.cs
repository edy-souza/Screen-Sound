class Banda
{
    public Banda (string nome)
    {
        Nome = nome;
    }

    private List<Album> albuns = new List<Album>();
    public string? Nome { get;}

    public void AdicionarAlbum (Album album)
    {
        albuns.Add(album);
    }

    public void ExibirAlbum()
    {
        Console.WriteLine($"\nLista de Bandas: {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Album: {album.Nome} -> {album.DuracaoTotal} segundos de duração");
        }

    }
}