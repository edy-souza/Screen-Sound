class Musica
{   
    // get atributo de LEITURA e set atributo de ESCRITA
    public string? Nome {get; set;}
    public string? Artista {get; set;}
    public int Duracao {get; set;}
    public bool Disponivel {get; set;}  

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");

        if (Disponivel)
        {
            Console.WriteLine("A música está disponível no plano.");
        }
        else
        {
            Console.WriteLine("Música indisponível. Adquira o plano PLUS");
        }
        
    }
}