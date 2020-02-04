using LiquorAdda.Core.InterfaceRepository;
using LiquorAdda.Core.Models;
using LiquorAdda.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquorAdda.Core.Operation
{
    public class LiquorOperation
    {
        private ILiquorRepository _liquorRepository;

        public LiquorOperation()
        {
            _liquorRepository = new LiquorRepository();
        }

        public IList<Liquor> GetLiquorList()
        {
            var liquorList = _liquorRepository.GetSelectList();
            return liquorList;
        }
    }
}
