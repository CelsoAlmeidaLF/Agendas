using Scrum.Core;

namespace Scrum.Repository
{
    public class DbFake
    {
        protected List<Epicos> _epicos { get; set; }
        protected List<Sprint> _sprints { get; set; }

        public int CountEpicos => _epicos.Count;
        public int CountSprint => _sprints.Count;
    }
}
