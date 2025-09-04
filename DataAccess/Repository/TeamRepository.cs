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
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        private readonly ApplicationDbContext _db;

        public TeamRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        public void Update(Team obj)
        {
            _db.Teams.Update(obj);
        }
    }
}
