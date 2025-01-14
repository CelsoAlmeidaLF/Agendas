using Systekna.Scrum.Core;
using Core = Systekna.Scrum.Core;

namespace Scrum.Repository.Interfaces;

public interface IDbSprint
{
    void AddSprint(Sprint sprint);
    void AddTask(int idSprint, Core.Task task);
    void UpdateTask(int idSprint, int idTask, string status);
    void DelTask(int idSprint, Core.Task task);
}