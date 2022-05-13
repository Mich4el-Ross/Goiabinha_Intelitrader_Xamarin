using System;

namespace Mobile.Model
{
    public class User
    {
        public Guid Id { get; set; } = new Guid();

        public string FirstName { get; set; }

        public string SurName { get; set; }

        public int Age { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    }
}
