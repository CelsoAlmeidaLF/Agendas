using Scrum.Application.Interfaces;
using Systekna.Scrum.Application;
using Systekna.Scrum.Core;
using Core = Systekna.Scrum.Core;

namespace UTestScrum;

public class Tests
{
    public IBbSprint sprint;

    [SetUp]
    public void Setup() => sprint = BbSprint.Create();

    [Test]
    public void TestSprint()
    {
        sprint.AddSprint(new Sprint(1, "Workflow de Garantias", "Projeto Bradesco", DateTime.Now, 10));

        var r = new Core.Task(2, "Cria��o Fila de Inclus�o", "... sem descri��o ...", DateTime.Now.AddDays(2), 2);

        sprint.AddTask(1, new Core.Task(1, "Cria��o Manuten��o de Baixa", "Envio de Baixa/Cancelamento", DateTime.Now, 2));
        sprint.AddTask(1, r);
        sprint.AddTask(1, new Core.Task(3, "Cria��o Fila de Pendencias", "... sem descri��o ...", DateTime.Now.AddDays(4), 2));

        sprint.UpdateTask(1, 1, "InProgress");
        sprint.UpdateTask(1, 3, "Done");

        sprint.DelTask(1, r);

        sprint.AddSprint(new Sprint(2, "Sprint 2", "Cria��o do projeto Bradesco", DateTime.Now.AddDays(11), 10));

        Assert.IsNotNull(sprint);
    }
}