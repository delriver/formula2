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
    public class RaceRepository : Repository<Race>, IRaceRepository
    {
        private readonly ApplicationDbContext _db;

        public RaceRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        public void Update(Race obj)
        {
            _db.Races.Update(obj);
        }
    }
}
