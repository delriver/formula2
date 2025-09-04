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
    public class DriverCompetitionRepository : Repository<DriverCompetition>, IDriverCompetitionRepository
    {
        private readonly ApplicationDbContext _db;

        public DriverCompetitionRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        public void Update(DriverCompetition obj)
        {
            _db.DriverCompetitions.Update(obj);
        }
    }
}
