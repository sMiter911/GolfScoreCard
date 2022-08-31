using Golfscorecard.DAL.Data;
using Golfscorecard.DAL.Entities;

namespace Golfscorecard.DAL.Interface.Implementation
{
    public class ScorecardRepo : Repository<Scorecard>, IScorecard
    {
        public ScorecardRepo(GolfScoreDBContext dbContext) : base(dbContext)
        {
        }
    }
}
