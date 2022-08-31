using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Golfscorecard.DAL.Entities;
using Golfscorecard.DAL.Interface.Implementation;
using Golfscorecard.DAL.Interface;
using GolfScorecard.BL.Interface;

namespace GolfScorecard.UI.Controllers
{
    public class ScorecardsController : Controller
    {
        private readonly IScorecardService _scorecardService;

        public ScorecardsController(IScorecardService scorecardService)
        {
            _scorecardService = scorecardService;
        }

        // GET: Scorecards
        public async Task<IActionResult> Index()
        {
            return View(_scorecardService.GetAllScorecards());
        }

        // GET: Scorecards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _scorecardService.GetAllScorecards() == null)
            {
                return NotFound();
            }

            var scorecard = _scorecardService.GetScoreCard(id.Value);
            if (scorecard == null)
            {
                return NotFound();
            }

            return View(scorecard);
        }

        // GET: Scorecards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Scorecards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ScorecardId,HoleNumber,PlayerOne,PlayerTwo,PlayerThree,PlayerFour")] Scorecard scorecard)
        {
            if (ModelState.IsValid)
            {
                var validationCheck = _scorecardService.Validate(scorecard);

                if(!validationCheck.Item1)
                    throw new Exception(validationCheck.Item2);

                _scorecardService.AddScorecard(scorecard);
                
                return RedirectToAction(nameof(Index));
            }
            return View(scorecard);
        }

        // GET: Scorecards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _scorecardService.GetAllScorecards() == null)
            {
                return NotFound();
            }

            var scorecard = _scorecardService.GetScoreCard(id.Value);
            if (scorecard == null)
            {
                return NotFound();
            }
            return View(scorecard);
        }

        // POST: Scorecards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ScorecardId,HoleNumber,PlayerOne,PlayerTwo,PlayerThree,PlayerFour")] Scorecard scorecard)
        {
            if (id != scorecard.ScorecardId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _scorecardService.UpdateScoreCard(scorecard);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScorecardExists(scorecard.ScorecardId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(scorecard);
        }

        // GET: Scorecards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _scorecardService.GetAllScorecards() == null)
            {
                return NotFound();
            }

            var scorecard = _scorecardService.GetScoreCard(id.Value);
            if (scorecard == null)
            {
                return NotFound();
            }

            return View(scorecard);
        }

        // POST: Scorecards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            _scorecardService.DeleteScorecard(id);

            return RedirectToAction(nameof(Index));
        }

        private bool ScorecardExists(int id)
        {
          return (_scorecardService.GetAllScorecards()?.Any(e => e.ScorecardId == id)).GetValueOrDefault();
        }
    }
}
