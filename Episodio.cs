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
    public string? Resumo => $"{Ordem} {Titulo}. ({Resumo} min) - {string.Join(", ", convidados)}" ;

    public void AddConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}