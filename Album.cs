class Album
{
    public Album (String nome)
    {
        Nome = nome;
    }
    
    private List<Musica> musicas = new List<Musica>();
    public string? Nome {get;}
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    
    public void AdicionarMusica (Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicaAlbum ()
    {
        Console.WriteLine($"Lista de músicas do Álbum: {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.Write($"\nO álbum {Nome} tem duração total de {DuracaoTotal} segundos.");
    }

    public void ExibirDuracaoTotalAlbum()
    {
        
    }
}