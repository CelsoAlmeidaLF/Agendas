using Scrum.Application.Interfaces;
using Scrum.Core;
using Scrum.Repository.Interfaces;
using Systekna.Scrum.Repository;

namespace Systekna.Scrum.Application;

public class BbSprint : DbSprint, IBbSprint, IDbSprint
{
    private IDbSprint _db;

    public BbSprint()
        => _db = new DbSprint();

    public BbSprint(List<Sprint> sprints) : base(sprints)
        => _db = new DbSprint();
}
