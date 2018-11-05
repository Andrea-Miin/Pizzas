using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Pizza : EntityBase
    {
        public string Name { get; set; }
        public virtual ICollection<Ingredient> Id_Ingredient { get; set; }
        public virtual ICollection<Comment> Id_Comment { get; set; }
        public byte[] Photo { get; set; }
        public decimal Price { get; set; }
    }
}
