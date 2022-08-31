using Golfscorecard.DAL.Entities;
using Golfscorecard.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfScorecard.BL.Interface
{
    public interface IScorecardService
    {
        Tuple<bool, string> Validate(Scorecard scorecard);

        Scorecard AddScorecard(Scorecard scorecard);

        Scorecard GetScoreCard(int id);

        Scorecard DeleteScorecard(int id);

        IEnumerable<Scorecard> GetAllScorecards();

        Scorecard UpdateScoreCard(Scorecard scorecard);
    }
}
