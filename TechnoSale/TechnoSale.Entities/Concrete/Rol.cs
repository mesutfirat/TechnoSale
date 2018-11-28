using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Core.Entities;

namespace TechnoSale.Entities.Concrete
{
    public class Rol : IEntity
    {
        public Rol()
        {
            this.User = new List<User>();
        }

        public int rol_id { get; set; }
        public string rol_adi { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
