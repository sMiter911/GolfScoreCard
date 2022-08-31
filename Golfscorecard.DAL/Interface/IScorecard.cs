using Golfscorecard.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golfscorecard.DAL.Interface
{
    public interface IScorecard : IRepository<Scorecard>
    {
    }
}
