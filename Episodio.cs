class Episodio
{ 
    private List<string> convidados = new List<string>();
    public Episodio(int ordem, string titulo, int duraca)
    {
        Ordem= ordem;
        Titulo = titulo;
        Duracao = duraca;        
    }

    public int Ordem { get;}
    public string? Titulo { get;}
    public int Duracao { get;}
    public string? Resumo => $"{Ordem} {Titulo}. ({Duracao} min) - {string.Join(", ", convidados)}\n" ;

    public void AddConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}