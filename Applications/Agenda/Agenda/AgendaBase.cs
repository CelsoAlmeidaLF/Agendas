namespace Systekna.Agenda.One;

public class AgendaBase
{
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public Dictionary<string, string> Local { get; set; } = new Dictionary<string, string>() 
    {
        { "Trabalho", "R. Conde de Assumar, 339, 07, Vila Nivi, São Paulo - SP, 02255-020" },
        { "Local", "R. Conde de Assumar, 339, 07, Vila Nivi, São Paulo - SP, 02255-020" }
    };

}
