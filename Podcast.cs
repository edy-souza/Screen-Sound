class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AddEpisodios(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhesPodcast()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");

        foreach (Episodio episodio in episodios)
        {
            Console.WriteLine($"Episodio: {episodio.Resumo}");
        }

        Console.WriteLine($"\nO podcast {Nome} tem {TotalEpisodios} episodios.");
    }
}