using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class StatsRepository : Repository<Stats>, IStatsRepository
    {
        private readonly ApplicationDbContext _db;

        public StatsRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        public void Update(Stats obj)
        {
            _db.Stats.Update(obj);
        }
    }
}
