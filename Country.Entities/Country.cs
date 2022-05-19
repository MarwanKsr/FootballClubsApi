using System;
using System.Collections;
using System.Collections.Generic;

namespace Catalog.Entities
{
    public class Country : IEntity 
    {
        public string Name { get; set; }
        public int Id { get ; set ; }
        public ICollection<Club> Clubs { get; set; }
    }
}
