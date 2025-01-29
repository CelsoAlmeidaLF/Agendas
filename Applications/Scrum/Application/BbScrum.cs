using Scrum.Application.Interfaces;
using Scrum.Core;
using Scrum.Repository.Interfaces;
using Systekna.Scrum.Repository;

namespace Systekna.Scrum.Code;

public class BbScrum : DbScrum, IBbScrum, IDbScrum
{
    #region ...
    private readonly IDbScrum _db;

    public BbScrum() 
        => _db = new DbScrum();

    public BbScrum(List<Epicos> tasks) : base(tasks) 
        => _db = new DbScrum();

    #endregion
}
