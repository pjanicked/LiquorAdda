using LiquorAdda.Core.InterfaceRepository;
using LiquorAdda.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquorAdda.Core.Repository
{
    public class LiquorRepository : GenericRepository<Liquor>, ILiquorRepository
    {
    }
}
