namespace Systekna.Agenda.One;

public class DbNotas : DataFake, IDbNotas
{
    public void Add(Nota nota)
    {
        notas.Add(nota);
    }

    public void Remove(string titulo)
    {
        notas.RemoveAll(n => n.Titulo == titulo);
    }

    public IEnumerable<Nota> ToList()
    {
        return notas;
    }
}