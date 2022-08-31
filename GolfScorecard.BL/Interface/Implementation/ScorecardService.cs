using Golfscorecard.DAL.Entities;
using Golfscorecard.DAL.Interface;

namespace GolfScorecard.BL.Interface.Implementation
{
    public class ScorecardService : IScorecardService
    {
        private readonly IScorecard _scorecardRepo;

        public ScorecardService(IScorecard scorecardRepo)
        {
            _scorecardRepo = scorecardRepo;
        }

        public Tuple<bool, string> Validate(Scorecard scorecard)
        {
            if (scorecard.PlayerOne == null || scorecard.PlayerTwo == null || scorecard.PlayerThree == null || scorecard.PlayerFour == null)
            {
                return new Tuple<bool, string>(false, "Please enter all scores");
            }
            if (scorecard.HoleNumber < 1 || scorecard.HoleNumber > 18)
            {
                return new Tuple<bool, string>(false, "Please enter a valid hole number");
            }
            return new Tuple<bool, string>(true, "");
        }

        public Scorecard AddScorecard(Scorecard scorecard)
        {
            _scorecardRepo.Add(scorecard);
            _scorecardRepo.Save();

            return scorecard;
        }

        public Scorecard GetScoreCard(int id)
        {
            return _scorecardRepo.Find(id);
        }

        public IEnumerable<Scorecard> GetAllScorecards()
        {
            return _scorecardRepo.GetAll();
        }

        public Scorecard DeleteScorecard(int id)
        {
            if (_scorecardRepo.GetAll() == null)
            {
                throw new Exception("ERROR Deleting");
            }
            var scorecard = _scorecardRepo.Find(id);
            if (scorecard != null)
            {
                _scorecardRepo.Remove(scorecard);
            }

            _scorecardRepo.Save();

            return scorecard;
        }

        public Scorecard UpdateScoreCard(Scorecard scorecard)
        {
            _scorecardRepo.Update(scorecard);
            _scorecardRepo.Save();

            return scorecard;
        }


    }
}

