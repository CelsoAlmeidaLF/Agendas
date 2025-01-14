namespace Systekna.Agenda.One;

public interface IDbAgenda : 
    IRepositoryEvento, 
    IRepositoryTarefa, 
    IRepositoryLembrete, 
    IRepositoryNotas
{
}