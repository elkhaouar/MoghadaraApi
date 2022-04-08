using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moghadara.Bll.ServiceAbstractions
{
    public interface IServices<t>
    {
        public IEnumerable<t> GetAll();
        public t GetById(int id);
        public void Post(t model);
        public void Put(t model, int id);
        public void Delete(int id);
    }
}
