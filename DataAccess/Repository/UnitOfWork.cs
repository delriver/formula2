using DataAccess.Data;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public ICompetitionRepository Competition { get; private set; }
        public ICategoryRepository Category { get; private set; }
        public ICircuitRepository Circuit { get; private set; }
        public ICountryRepository Country { get; private set; }
        public IDriverCompetitionRepository DriverCompetition { get; private set; }
        public IDriverRepository Driver { get; private set; }
        public IFastLapRepository FastLap { get; private set; }
        public IRaceRepository Race { get; private set; }
        public IStatsRepository Stats { get; private set; }
        public ITeamRepository Team { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Competition = new CompetitionRepository(_db);
            Category = new CategoryRepository(_db);
            Circuit = new CircuitRepository(_db);
            Country = new CountryRepository(_db);
            DriverCompetition = new DriverCompetitionRepository(_db);
            Driver = new DriverRepository(_db);
            FastLap = new FastLapRepository(_db);
            Race = new RaceRepository(_db);
            Stats = new StatsRepository(_db);
            Team = new TeamRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public Microsoft.EntityFrameworkCore.DbContext GetContext()
        {
            return this._db;
        }
    }
}
