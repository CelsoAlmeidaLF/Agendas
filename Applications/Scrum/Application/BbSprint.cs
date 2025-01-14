using Scrum.Application.Interfaces;
using Scrum.Repository.Interfaces;
using Systekna.Scrum.Repository;

namespace Systekna.Scrum.Application;

public class BbSprint : DbSprint, IBbSprint, IDbSprint
{
    public BbSprint() : base()
    {
    }

    public static IBbSprint Create() 
        => new BbSprint();

}
