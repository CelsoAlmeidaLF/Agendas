using Scrum.Repository.Interfaces;
using Systekna.Scrum.Repository;

namespace Systekna.Scrum.Code;

public class BbScrum : DbScrum
{
    #region ...
    private readonly IDbScrum _db;
    public BbScrum() => _db = new DbScrum();
    #endregion
}
