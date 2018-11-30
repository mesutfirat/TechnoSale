using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TechnoSale.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace TechnoSale.Entities.Concrete
{
    public class Rol : IEntity
    {
        public Rol()
        {
            this.user_rol = new List<user_rol>();
        }

        [Key]
        public int rol_id { get; set; }
        public string rol_adi { get; set; }
        public virtual ICollection<user_rol> user_rol { get; set; }
    }
}
