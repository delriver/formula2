using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CompetitionRepository : Repository<Competition>, ICompetitionRepository
    {
        private readonly ApplicationDbContext _db;

        public CompetitionRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        public void Update(Competition obj)
        {
            var objFromDb = _db.Competitions.FirstOrDefault(c => c.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.Description = obj.Description;
            }
        }
    }
}
