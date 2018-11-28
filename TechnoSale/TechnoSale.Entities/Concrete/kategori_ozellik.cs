using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Core.Entities;

namespace TechnoSale.Entities.Concrete
{
    public class kategori_ozellik : IEntity
    {
        public int kategori_id { get; set; }
        public int ozellik_id { get; set; }
    }
}
