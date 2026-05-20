class Musica
{   
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    // get atributo de LEITURA e set atributo de ESCRITA
    public string? Nome {get;}
    public Banda Artista {get; }
    public int Duracao {get; set;}
    public bool Disponivel {get; set;}  

    // => (Lambda) tem a mesma função de LEITURA GET
    public string DescricaoResumida => $"A música {Nome} pertence ao artista {Artista.Nome}, com duração de {Duracao} minutos";
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");

        Console.WriteLine($"Resumo: {DescricaoResumida}");

        if (Disponivel)
        {
            Console.WriteLine("A música está disponível no plano.\n");
        }
        else
        {
            Console.WriteLine("Música indisponível. Adquira o plano PLUS");
        }
        
    }
}