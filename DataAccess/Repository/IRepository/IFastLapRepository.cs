using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IFastLapRepository : IRepository<FastLap>
    {
        void Update(FastLap obj);
    }
}
