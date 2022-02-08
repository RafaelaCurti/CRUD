using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public int Telephone { get; set; }
        public bool Active { get; set; }
    }
}
