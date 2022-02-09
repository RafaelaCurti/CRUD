using System;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public int Telephone { get; set; }
        public bool Active { get; set; }
        public DateTime DateRegister { get; set; }
    }
}
