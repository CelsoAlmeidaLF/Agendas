using Systekna.Agenda.One;

namespace Systekna.Agenda.Repository.Interface;

public interface IDbAgenda :
    IRepositoryEvento,
    IRepositoryTarefa,
    IRepositoryLembrete,
    IRepositoryNotas
{
}