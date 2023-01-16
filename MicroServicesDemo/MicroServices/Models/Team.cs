﻿namespace MicroServices.Models
{
    public class Team
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Member> Members { get; set; }

        public Team()
        {
            this.Members = new List<Member>();
        }

        public Team(string name) : this()
        {
            this.Name = name;
        }

        public Team(string name, Guid id) : this(name)
        {
            this.Id = id;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
