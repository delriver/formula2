using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        public ICompetitionRepository Competition { get; }
        public ICategoryRepository Category { get; }
        public ICircuitRepository Circuit { get; }
        public ICountryRepository Country { get; }
        public IDriverCompetitionRepository DriverCompetition { get; }
        public IDriverRepository Driver { get; }
        public IFastLapRepository FastLap { get; }
        public IRaceRepository Race { get; }
        public IStatsRepository Stats { get; }
        public ITeamRepository Team { get; }

        void Save();

        Microsoft.EntityFrameworkCore.DbContext GetContext();
    }
}
