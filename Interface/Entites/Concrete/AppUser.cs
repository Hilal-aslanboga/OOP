using Interface.Entites.Abstract;
using Interface.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entites.Concrete
{
    public class AppUser : BaseEntity<int>
    {
        public override int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }

        public Role Role { get; set; }
    }
}
