using System;

namespace Country.Entities
{
    public class Country : IEntity 
    {
        public string Name { get; set; }
        public int Id { get ; set ; }
    }
}
